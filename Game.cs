using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PairsAssignment
{
    public class Game
    {
        private int[,] _cards;
        private readonly TableLayoutPanel _cardGrid;
        private readonly PictureBox _cardSelected11, _cardSelected12, _cardSelected21, _cardSelected22, _backgroundImage;
        private readonly Label _pairsFoundLbl1, _pairsFoundLbl2;
        private readonly TextBox _p1NameInput, _p2NameInput;
        private readonly PictureBox _yourTurn1, _yourTurn2;
        private bool _gameActive, _playerOneTurn = true, _buttonsInactive = true;
        private int _p1Score, _p2Score;
        public readonly OpenFileDialog OpenFileDialog = new();
        public readonly SaveFileDialog SaveFileDialog = new();
        private readonly MainForm _mainForm;

        public Game(MainForm mainForm, TableLayoutPanel cardGrid, PictureBox cardSelected11, PictureBox cardSelected12,
            PictureBox cardSelected21, PictureBox cardSelected22, Label pairsFoundLbl1, Label pairsFoundLbl2,
            TextBox p1NameInput, TextBox p2NameInput, PictureBox yourTurn1, PictureBox yourTurn2, PictureBox backgroundImage)
        {
            _mainForm = mainForm;
            _cardGrid = cardGrid;
            _cardSelected11 = cardSelected11;
            _cardSelected12 = cardSelected12;
            _cardSelected21 = cardSelected21;
            _cardSelected22 = cardSelected22;
            _pairsFoundLbl1 = pairsFoundLbl1;
            _pairsFoundLbl2 = pairsFoundLbl2;
            _backgroundImage = backgroundImage;
            _p1NameInput = p1NameInput;
            _p2NameInput = p2NameInput;
            _yourTurn1 = yourTurn1;
            _yourTurn2 = yourTurn2;
        }
        
        /// <summary>Get the card ID of a button from the 2D array.</summary>
        /// <param name="button">The button who's ID to be retrieved.</param>
        /// <returns>An integer value ID of the index in the cards class.</returns>
        private int GetButtonId(Button button)
        {
            for (int row = 0; row < _cardGrid.RowCount; row++) for (int column = 0; column < _cardGrid.ColumnCount; column++) 
                if (_cardGrid.Controls[row * _cardGrid.ColumnCount + column] == button) return _cards[row, column];
            return -1;
        }

        /// <summary>Sets the value of a card in the cards array.</summary>
        /// <param name="position">The position of the card in the Card Grid Controls.</param>
        /// <param name="value">The value to set in the 2D array.</param>
        private void SetCardsValue(int position, int value)
        {
            _cards[position / _cardGrid.RowCount, position % _cardGrid.ColumnCount] = value;
        }

        /// <summary>Get the index of a button in the Card Grid Controls.</summary>
        /// <param name="button">The button who's index is to be found.</param>
        /// <returns>The index of the button as an integer.</returns>
        private int GetButtonIndex(Button button)
        {
            for (int index = 0; index < _cardGrid.Controls.Count; index++) if (_cardGrid.Controls[index] == button) return index;
            return -1;
        }

        /// <summary>Resize TableLayoutGrid which contains all the cards.</summary>
        /// <param name="size">The amount of rows and columns the grid should have.</param>
        public void ResizeGrid(int size)
        {
            if (_gameActive)  // during a game ask if they are sure then clear the grid or return
            {
                DialogResult result = MessageBox.Show("Resizing the grid during a game will clear the current game, are you sure you would like to continue?",
                    "Resize Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) ClearGame(true);
                else return;
            }
            
            // clear styles
            _cardGrid.RowStyles.Clear();
            _cardGrid.ColumnStyles.Clear();

            // set the maximum amount of rows and columns to the correct size
            _cardGrid.RowCount = size;
            _cardGrid.ColumnCount = size;

            // add the empty rows and columns
            for (int n = 0; n < size; n++)
            {
                // ReSharper disable once PossibleLossOfFraction
                _cardGrid.RowStyles.Add(new RowStyle(SizeType.Percent, (float) 1 / size));
                // ReSharper disable once PossibleLossOfFraction
                _cardGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, (float) 1 / size));
            }
        }

        /// <summary>Run this method to start the game, it resets everything and sets all required variables.</summary>
        public void StartGame()
        {
            if (_gameActive)  // during a game ask if they are sure then clear the grid or return
            {
                DialogResult result = MessageBox.Show("Starting a new game will clear the current game, are you sure you would like to continue?",
                    "New Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) ClearGame(true);
                else return;
            }
            
            // check if names are empty and force them to enter a name
            TextBox[] nameInputs = { _p1NameInput, _p2NameInput };
            for (int nameInput = 0; nameInput < nameInputs.Length; nameInput++)
            {
                if (nameInputs[nameInput].Text != "") continue;
                string newName = PlayerNameEntry.GetName(_mainForm, (nameInput+1).ToString());
                if (newName != null) nameInputs[nameInput].Text = newName;
                else return;
            }

            _backgroundImage.Visible = false;
            _gameActive = true;
            _buttonsInactive = true;
            _playerOneTurn = true;
            _p1Score = 0;
            _p2Score = 0;
            _yourTurn1.Visible = true;
            _yourTurn2.Visible = false;

            // create a new 2D of cards
            _cards = new int[_cardGrid.RowCount, _cardGrid.ColumnCount];
            int[,] randomCards = Cards.GetRandomPairs(_cardGrid.RowCount * _cardGrid.ColumnCount, _cardGrid.RowCount);
            FillCardGrid(randomCards);

            int showDuration = _cardGrid.RowCount switch
            {
                10 => 15000,  // 10 sec for 10x10
                16 => 20000,  // 20 sec for 16x16
                _ => 10000  // 10 sec by default (6x6)
            };

            // turn all the cards over after a given number of seconds
            Task.Run(async delegate
            {
                await Task.Delay(showDuration);
                foreach (Button cardButton in _cardGrid.Controls)
                {
                    cardButton.Image = new Bitmap(Cards.AllCards[55], new Size(cardButton.Width,cardButton.Height));
                    _buttonsInactive = false;
                }
            });
        }

        /// <summary>Fill the grid of cards with a list of card IDs.</summary>
        /// <param name="cardIds">A list of card IDs from 0-55 that will be assigned to the buttons.</param>
        private void FillCardGrid(int[,] cardIds)
        {
            // fill the grid with buttons as cards
            for (int row = 0; row < _cardGrid.RowCount; row++)
            {
                for (int column = 0; column < _cardGrid.ColumnCount; column++)
                {
                    // set each cell in the TableLayoutGrid to be a button with a card image that runs MakeTurn on click
                    Button cardButton = new();
                    cardButton.Dock = DockStyle.Fill;
                    cardButton.Margin = new Padding(25/_cardGrid.RowCount);
                    cardButton.FlatStyle = FlatStyle.Flat;
                    cardButton.FlatAppearance.BorderSize = 0;
                    cardButton.Click += MakeTurn;
                    _cardGrid.Controls.Add(cardButton, column, row);
                    _cards[row, column] = cardIds[row, column];
                    SetObjImg(cardButton, _cards[row, column]);
                }
            }

            EdgeResizeFix();
        }

        /// <summary>Correct the size of the last row and column to the same size as the first button.
        /// This is caused by TableLayoutPanels peculiar management of the percent size and padding.</summary>
        public void EdgeResizeFix()
        {
            // correct sizing of right column and bottom row by setting the width and height to the first button as they were larger due to TableLayoutPanel
            for (int index = 0; index < _cardGrid.Controls.Count; index++)
            {
                // check if the card is on the last row or column
                if (index % _cardGrid.RowCount != _cardGrid.RowCount - 1 && index < _cardGrid.Controls.Count - _cardGrid.RowCount) continue;
                _cardGrid.Controls[index].Dock = DockStyle.None;
                _cardGrid.Controls[index].Height = _cardGrid.Controls[0].Height;  // resize to first buttons size
                _cardGrid.Controls[index].Width = _cardGrid.Controls[0].Width;
            }
        }

        private Button _cardOne;
        private Button _cardTwo;

        /// <summary>Every time a card button is pressed this method runs to allow the player to make a turn.</summary>
        /// <param name="sender">The event object which called the method</param>
        /// <param name="e">Event arguments</param>
        private void MakeTurn(object sender, EventArgs e)
        {
            if (_buttonsInactive) return;  // dont allow buttons to be pressed when cards are shown at the start
            if (sender is not Button clickedButton) return;  // null check for IDE warnings
            if (GetButtonId(clickedButton) == 54) return;  // don't allow blue cards to be selected
            if (_cardOne == null) // choosing card 1
            {
                _cardOne = clickedButton;
                SetObjImg(_cardOne, GetButtonId(_cardOne));
                if (_cardOne == null) return;  // null check for IDE warnings
                SetObjImg(_playerOneTurn ? _cardSelected11 : _cardSelected21, GetButtonId(_cardOne));  // set selected
                return;
            }

            if (_cardTwo != null) return; // choosing card 2
            if (_cardOne == clickedButton) return;  // do not allow them to pick the same card
            _cardTwo = clickedButton;
            SetObjImg(_cardTwo, GetButtonId(_cardTwo));
            if (_cardTwo == null) return;  // null check for IDE warnings
            SetObjImg(_playerOneTurn ? _cardSelected12 : _cardSelected22, GetButtonId(_cardTwo)); // set selected

            // check if the pair is a match
            bool isPair = GetButtonId(_cardOne) == GetButtonId(_cardTwo);
            if (isPair)
            {
                // there is a pair
                if (_playerOneTurn) _pairsFoundLbl1.Text = "Pairs Found: " + ++_p1Score;
                else _pairsFoundLbl2.Text = "Pairs Found: " + ++_p2Score;
                
                // prevent clicking buttons of found cards by IDing them as 54
                SetCardsValue(GetButtonIndex(_cardOne), 54);
                SetCardsValue(GetButtonIndex(_cardTwo), 54);

                // check if total score equals maximum score to check if the game has ended
                if (_p1Score + _p2Score == _cardGrid.RowCount * _cardGrid.ColumnCount / 2)  // game finished
                {
                    if (_p1Score > _p2Score) MessageBox.Show(_p1NameInput.Text + " Won!");
                    else if (_p1Score < _p2Score) MessageBox.Show(_p2NameInput.Text + " Won!");
                    else MessageBox.Show("It was a draw!");
                    ClearGame(true);  // clear game once the messagebox is pressed so a new one can start
                }
                else  // game not finished
                {
                    _buttonsInactive = true;
                    // continue onto the next persons turn after a given amount of time
                    Task.Run(async delegate
                    {
                        await Task.Delay(10000);
                        NextTurn(54);
                    });
                }
            }
            else  // no pair
            {
                _buttonsInactive = true;
                // continue onto the next persons turn after a given amount of time
                Task.Run(async delegate
                {
                    await Task.Delay(10000);
                    NextTurn(55);
                });
            }
        }

        /// <summary>Clear the current turn in preparation for the next turn.</summary>
        /// <param name="cardColour">Red or blue depending on if the pair is correct or not.</param>
        private void NextTurn(int cardColour)
        {
            SetObjImg(_cardOne, cardColour);
            SetObjImg(_cardTwo, cardColour);
            _cardOne = null;
            _cardTwo = null;
            _cardSelected11.Image = null;  // clear the selected cards
            _cardSelected12.Image = null;
            _cardSelected21.Image = null;
            _cardSelected22.Image = null;
            _playerOneTurn = !_playerOneTurn; // flip turn value
            _buttonsInactive = false;  // allow cards to be pressed again


            (_yourTurn1.Visible, _yourTurn2.Visible) = (_yourTurn2.Visible, _yourTurn1.Visible);  // swap text values of your turn
        }

        /// <summary>Set a buttons image to the image of a card ID.</summary>
        /// <param name="button">The button who's image will be set.</param>
        /// <param name="cardId">The ID of the card from Cards.cs</param>
        private static void SetObjImg(ButtonBase button, int cardId)
        {
            button.Image = new Bitmap(Cards.AllCards[cardId], new Size(button.Width, button.Height));
        }
        
        /// <summary>Set a picture boxes image to the image of a card ID.</summary>
        /// <param name="pictureBox">The picture box who's image will be set.</param>
        /// <param name="cardId">The ID of the card from Cards.cs.</param>
        private static void SetObjImg(PictureBox pictureBox, int cardId)
        {
            pictureBox.Image = new Bitmap(Cards.AllCards[cardId], new Size(pictureBox.Width, pictureBox.Height));
        }

        /// <summary>Saves the game to a file using the GameData object.</summary>
        public void SaveGameToFile()
        {
            if (!_gameActive) return;  // no active game to save
            if (SaveFileDialog.ShowDialog() != DialogResult.OK) return;  // leave if the file path isn't okay
            string filePath = SaveFileDialog.FileName;
            GameData gameData = new GameData(_cards, _playerOneTurn,
                _p1Score, _p2Score, _p1NameInput.Text, _p2NameInput.Text);

            string jsonResult = JsonConvert.SerializeObject(gameData, Formatting.Indented);
            if (File.Exists(filePath)) File.Delete(filePath);
            using (StreamWriter streamWriter = new StreamWriter(filePath, true)) streamWriter.WriteLine(jsonResult);
            ClearGame(true);
        }

        /// <summary>Load a saved game from a file using the GameData object.</summary>
        public void LoadGameFromFile()
        {
            if (OpenFileDialog.ShowDialog() != DialogResult.OK) return;  // leave if the file path isn't okay
            string jsonText = File.ReadAllText(OpenFileDialog.FileName);
            GameData gameData = JsonConvert.DeserializeObject<GameData>(jsonText);
            
            if (gameData == null) return;  // no game in the save file

            ClearGame(false);
            
            _playerOneTurn = gameData.PlayerOneTurn;
            _p1NameInput.Text = gameData.P1Name;
            _p2NameInput.Text = gameData.P2Name;
            _p1Score = gameData.P1Score;
            _p2Score = gameData.P2Score;
            _pairsFoundLbl1.Text = "Pairs Found: " + _p1Score;
            _pairsFoundLbl2.Text = "Pairs Found: " + _p2Score;

            // refill the game panel with cards
            _cards = gameData.Cards;
            _backgroundImage.Visible = false;
            ResizeGrid((int) Math.Sqrt(_cards.Length));
            FillCardGrid(_cards);
            _gameActive = true;
            
            
            // turn all the cards apart from blue cards (id 54)
            foreach (Button cardButton in _cardGrid.Controls)
            {
                if (GetButtonId(cardButton) == 54) continue;
                cardButton.Image = new Bitmap(Cards.AllCards[55], new Size(cardButton.Width,cardButton.Height));
                _buttonsInactive = false;
            }
        }

        /// <summary>Reset all game variables.</summary>
        private void ClearGame(bool askResetNames)
        {
            // set names to nothing, pairs found to none, remove buttons, remove images in currently selected, set inactive
            DialogResult result = DialogResult.No;  // remove names by default
            if (askResetNames)
            {
                result = MessageBox.Show("Would you like to keep the currently set player names?",
                    "Player Names", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            if (result == DialogResult.No) _p1NameInput.Text = _p2NameInput.Text = "";
            
            _pairsFoundLbl1.Text = _pairsFoundLbl2.Text = "Pairs Found: 0";
            _cardGrid.Controls.Clear();  // remove all cards
            _cardSelected11.Image = _cardSelected12.Image = _cardSelected21.Image = _cardSelected22.Image = null;
            _gameActive = false;
            _yourTurn1.Visible = _yourTurn2.Visible = false;
            _backgroundImage.Visible = true;
        }
    }
}