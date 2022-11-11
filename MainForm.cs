using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PairsAssignment
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Game _game;
        private void NewGameButton_Click(object sender, EventArgs e)
        {
            _game.StartGame();
        }
        
        private void GridSizeClick(object sender, EventArgs e)
        {
            int size = 6;  // 6x6 by default
            if (sender == Size10Button) size = 10;
            if (sender == Size16Button) size = 16;
            
            // set the current size tick icon and then set as currently selected
            Size6Button.Checked = Size10Button.Checked = Size16Button.Checked = false;
            ((ToolStripMenuItem)sender).Checked = true;
            _game.ResizeGrid(size);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // fill the list of card images with images from files
            for (int i = 1; i < 57; i++) Cards.AllCards.Add(GetImageFile("images\\" + i + ".png"));

            _game = new Game(this, CardGrid, CardSelected11, CardSelected12, CardSelected21, CardSelected22, PairsFoundLbl1,
                PairsFoundLbl2, Player1NameInput, Player2NameInput, YourTurn1, YourTurn2);

            YourTurn1.Visible = YourTurn2.Visible = false;
            
            _game.SaveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";  // filter json files
            _game.OpenFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";

            _addControl = BackgroundImage;
            _removeControl = CardGrid;
            SwapCenterControl();
        }

        private Control _addControl;
        private Control _removeControl;
        public void SwapCenterControl()
        {
            MainTLP.Controls.Remove(_removeControl);
            MainTLP.Controls.Add(_addControl, 3, 1);
            (_addControl, _removeControl) = (_removeControl, _addControl);
        }

        private void SaveGameButton_Click(object sender, EventArgs e)
        {
            _game.SaveGameToFile();
        }

        private void RetrieveGameButton_Click(object sender, EventArgs e)
        {
            _game.LoadGameFromFile();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // ask the user if they'd like to save before exiting, if yes then save, then exit the app.
            DialogResult result = MessageBox.Show("Would you like to save before exiting?", "Exit Game", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes) _game.SaveGameToFile();
            Application.Exit();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            AboutPage aboutPage = new();
            aboutPage.StartPosition = FormStartPosition.CenterParent;
            aboutPage.ShowDialog(this);
        }
        
        /// <summary>Shorthand for getting an image from a relative file path.</summary>
        /// <param name="relativePath">The path from the .exe path.</param>
        /// <returns>Image at that path.</returns>
        private static Image GetImageFile(string relativePath)
        {
            return Image.FromFile(Path.Combine(Directory.GetCurrentDirectory(), relativePath));
        }

        /// <summary>Fix the edge button sizes, then resize images on the buttons to the button size, when resizing the form.</summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event arguments.</param>
        private void MainForm_Resize(object sender, EventArgs e)
        {
            _game.EdgeResizeFix();  // fix button sizes, then fix image sizes
            foreach (Button card in CardGrid.Controls) card.Image = new Bitmap(card.Image, card.Width, card.Height);
        }
    }
}
