using System.Windows.Forms;

namespace PairsAssignment
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.miniToolStrip = new System.Windows.Forms.ToolStrip();
            this.GameDropdown = new System.Windows.Forms.ToolStripDropDownButton();
            this.NewGameButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveGameButton = new System.Windows.Forms.ToolStripMenuItem();
            this.RetrieveGameButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsDropdown = new System.Windows.Forms.ToolStripDropDownButton();
            this.SizeSelector = new System.Windows.Forms.ToolStripMenuItem();
            this.Size6Button = new System.Windows.Forms.ToolStripMenuItem();
            this.Size10Button = new System.Windows.Forms.ToolStripMenuItem();
            this.Size16Button = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpDropdown = new System.Windows.Forms.ToolStripDropDownButton();
            this.AboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.Player1NameInput = new System.Windows.Forms.TextBox();
            this.Player2NameInput = new System.Windows.Forms.TextBox();
            this.PairsFoundLbl1 = new System.Windows.Forms.Label();
            this.PairsFoundLbl2 = new System.Windows.Forms.Label();
            this.CardsSelected1 = new System.Windows.Forms.GroupBox();
            this.CardSelected12 = new System.Windows.Forms.PictureBox();
            this.CardSelected11 = new System.Windows.Forms.PictureBox();
            this.CardsSelected2 = new System.Windows.Forms.GroupBox();
            this.CardSelected22 = new System.Windows.Forms.PictureBox();
            this.CardSelected21 = new System.Windows.Forms.PictureBox();
            this.CopyrightLabel = new System.Windows.Forms.Label();
            this.CardGrid = new System.Windows.Forms.TableLayoutPanel();
            this.BackgroundImage = new System.Windows.Forms.PictureBox();
            this.YourTurn1 = new System.Windows.Forms.PictureBox();
            this.YourTurn2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Player1NameLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Player2NameLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.miniToolStrip.SuspendLayout();
            this.CardsSelected1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardSelected12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardSelected11)).BeginInit();
            this.CardsSelected2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardSelected22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardSelected21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YourTurn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YourTurn2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.CanOverflow = false;
            this.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.miniToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.GameDropdown, this.SettingsDropdown, this.HelpDropdown });
            this.miniToolStrip.Location = new System.Drawing.Point(0, 0);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(1338, 27);
            this.miniToolStrip.TabIndex = 0;
            // 
            // GameDropdown
            // 
            this.GameDropdown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.GameDropdown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.NewGameButton, this.toolStripSeparator1, this.SaveGameButton, this.RetrieveGameButton, this.toolStripSeparator2, this.ExitButton });
            this.GameDropdown.Image = ((System.Drawing.Image)(resources.GetObject("GameDropdown.Image")));
            this.GameDropdown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GameDropdown.Name = "GameDropdown";
            this.GameDropdown.Size = new System.Drawing.Size(61, 24);
            this.GameDropdown.Text = "Game";
            // 
            // NewGameButton
            // 
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(175, 24);
            this.NewGameButton.Text = "New Game";
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(172, 6);
            // 
            // SaveGameButton
            // 
            this.SaveGameButton.Name = "SaveGameButton";
            this.SaveGameButton.Size = new System.Drawing.Size(175, 24);
            this.SaveGameButton.Text = "Save Game";
            this.SaveGameButton.Click += new System.EventHandler(this.SaveGameButton_Click);
            // 
            // RetrieveGameButton
            // 
            this.RetrieveGameButton.Name = "RetrieveGameButton";
            this.RetrieveGameButton.Size = new System.Drawing.Size(175, 24);
            this.RetrieveGameButton.Text = "Retrieve Game";
            this.RetrieveGameButton.Click += new System.EventHandler(this.RetrieveGameButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(172, 6);
            // 
            // ExitButton
            // 
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(175, 24);
            this.ExitButton.Text = "Exit";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SettingsDropdown
            // 
            this.SettingsDropdown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SettingsDropdown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.SizeSelector });
            this.SettingsDropdown.Image = ((System.Drawing.Image)(resources.GetObject("SettingsDropdown.Image")));
            this.SettingsDropdown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SettingsDropdown.Name = "SettingsDropdown";
            this.SettingsDropdown.Size = new System.Drawing.Size(75, 24);
            this.SettingsDropdown.Text = "Settings";
            // 
            // SizeSelector
            // 
            this.SizeSelector.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SizeSelector.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.Size6Button, this.Size10Button, this.Size16Button });
            this.SizeSelector.Name = "SizeSelector";
            this.SizeSelector.Size = new System.Drawing.Size(105, 24);
            this.SizeSelector.Text = "Size";
            // 
            // Size6Button
            // 
            this.Size6Button.Checked = true;
            this.Size6Button.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Size6Button.Name = "Size6Button";
            this.Size6Button.Size = new System.Drawing.Size(125, 24);
            this.Size6Button.Text = "6 x 6";
            this.Size6Button.Click += new System.EventHandler(this.GridSizeClick);
            // 
            // Size10Button
            // 
            this.Size10Button.Name = "Size10Button";
            this.Size10Button.Size = new System.Drawing.Size(125, 24);
            this.Size10Button.Text = "10 x 10";
            this.Size10Button.Click += new System.EventHandler(this.GridSizeClick);
            // 
            // Size16Button
            // 
            this.Size16Button.Name = "Size16Button";
            this.Size16Button.Size = new System.Drawing.Size(125, 24);
            this.Size16Button.Text = "16 x 16";
            this.Size16Button.Click += new System.EventHandler(this.GridSizeClick);
            // 
            // HelpDropdown
            // 
            this.HelpDropdown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.HelpDropdown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.AboutButton });
            this.HelpDropdown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HelpDropdown.Name = "HelpDropdown";
            this.HelpDropdown.Size = new System.Drawing.Size(54, 24);
            this.HelpDropdown.Text = "Help";
            // 
            // AboutButton
            // 
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(119, 24);
            this.AboutButton.Text = "About";
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // Player1NameInput
            // 
            this.Player1NameInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Player1NameInput.Location = new System.Drawing.Point(3, 31);
            this.Player1NameInput.Name = "Player1NameInput";
            this.Player1NameInput.Size = new System.Drawing.Size(228, 22);
            this.Player1NameInput.TabIndex = 3;
            // 
            // Player2NameInput
            // 
            this.Player2NameInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Player2NameInput.Location = new System.Drawing.Point(3, 31);
            this.Player2NameInput.Name = "Player2NameInput";
            this.Player2NameInput.Size = new System.Drawing.Size(228, 22);
            this.Player2NameInput.TabIndex = 4;
            // 
            // PairsFoundLbl1
            // 
            this.PairsFoundLbl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.PairsFoundLbl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PairsFoundLbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PairsFoundLbl1.ForeColor = System.Drawing.Color.White;
            this.PairsFoundLbl1.Location = new System.Drawing.Point(3, 79);
            this.PairsFoundLbl1.Name = "PairsFoundLbl1";
            this.PairsFoundLbl1.Size = new System.Drawing.Size(228, 33);
            this.PairsFoundLbl1.TabIndex = 5;
            this.PairsFoundLbl1.Text = "Pairs Found: 0";
            // 
            // PairsFoundLbl2
            // 
            this.PairsFoundLbl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.PairsFoundLbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PairsFoundLbl2.ForeColor = System.Drawing.Color.White;
            this.PairsFoundLbl2.Location = new System.Drawing.Point(3, 81);
            this.PairsFoundLbl2.Name = "PairsFoundLbl2";
            this.PairsFoundLbl2.Size = new System.Drawing.Size(228, 35);
            this.PairsFoundLbl2.TabIndex = 6;
            this.PairsFoundLbl2.Text = "Pairs Found: 0";
            // 
            // CardsSelected1
            // 
            this.CardsSelected1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.CardsSelected1.Controls.Add(this.CardSelected12);
            this.CardsSelected1.Controls.Add(this.CardSelected11);
            this.CardsSelected1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CardsSelected1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardsSelected1.ForeColor = System.Drawing.Color.White;
            this.CardsSelected1.Location = new System.Drawing.Point(3, 352);
            this.CardsSelected1.Name = "CardsSelected1";
            this.CardsSelected1.Size = new System.Drawing.Size(228, 533);
            this.CardsSelected1.TabIndex = 7;
            this.CardsSelected1.TabStop = false;
            this.CardsSelected1.Text = "Cards Selected";
            // 
            // CardSelected12
            // 
            this.CardSelected12.Location = new System.Drawing.Point(34, 305);
            this.CardSelected12.Name = "CardSelected12";
            this.CardSelected12.Size = new System.Drawing.Size(160, 208);
            this.CardSelected12.TabIndex = 1;
            this.CardSelected12.TabStop = false;
            // 
            // CardSelected11
            // 
            this.CardSelected11.Location = new System.Drawing.Point(34, 45);
            this.CardSelected11.Name = "CardSelected11";
            this.CardSelected11.Size = new System.Drawing.Size(160, 208);
            this.CardSelected11.TabIndex = 0;
            this.CardSelected11.TabStop = false;
            // 
            // CardsSelected2
            // 
            this.CardsSelected2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.CardsSelected2.Controls.Add(this.CardSelected22);
            this.CardsSelected2.Controls.Add(this.CardSelected21);
            this.CardsSelected2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CardsSelected2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardsSelected2.ForeColor = System.Drawing.Color.White;
            this.CardsSelected2.Location = new System.Drawing.Point(3, 353);
            this.CardsSelected2.Name = "CardsSelected2";
            this.CardsSelected2.Size = new System.Drawing.Size(228, 532);
            this.CardsSelected2.TabIndex = 8;
            this.CardsSelected2.TabStop = false;
            this.CardsSelected2.Text = "Cards Selected";
            // 
            // CardSelected22
            // 
            this.CardSelected22.Location = new System.Drawing.Point(36, 304);
            this.CardSelected22.Name = "CardSelected22";
            this.CardSelected22.Size = new System.Drawing.Size(160, 208);
            this.CardSelected22.TabIndex = 3;
            this.CardSelected22.TabStop = false;
            // 
            // CardSelected21
            // 
            this.CardSelected21.Location = new System.Drawing.Point(36, 44);
            this.CardSelected21.Name = "CardSelected21";
            this.CardSelected21.Size = new System.Drawing.Size(160, 208);
            this.CardSelected21.TabIndex = 2;
            this.CardSelected21.TabStop = false;
            // 
            // CopyrightLabel
            // 
            this.CopyrightLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CopyrightLabel.ForeColor = System.Drawing.Color.White;
            this.CopyrightLabel.Location = new System.Drawing.Point(1070, 920);
            this.CopyrightLabel.Name = "CopyrightLabel";
            this.CopyrightLabel.Size = new System.Drawing.Size(234, 20);
            this.CopyrightLabel.TabIndex = 9;
            this.CopyrightLabel.Text = "Copyright © 2022 James Lloyd";
            this.CopyrightLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CardGrid
            // 
            this.CardGrid.ColumnCount = 6;
            this.CardGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.CardGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.CardGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.CardGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.CardGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.CardGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.CardGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CardGrid.Location = new System.Drawing.Point(295, 29);
            this.CardGrid.Name = "CardGrid";
            this.CardGrid.RowCount = 6;
            this.CardGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.CardGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.CardGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.CardGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.CardGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.CardGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.CardGrid.Size = new System.Drawing.Size(743, 888);
            this.CardGrid.TabIndex = 10;
            // 
            // BackgroundImage
            // 
            this.BackgroundImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackgroundImage.BackgroundImage")));
            this.BackgroundImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackgroundImage.Location = new System.Drawing.Point(295, 49);
            this.BackgroundImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackgroundImage.Name = "BackgroundImage";
            this.BackgroundImage.Size = new System.Drawing.Size(743, 950);
            this.BackgroundImage.TabIndex = 5;
            this.BackgroundImage.TabStop = false;
            // 
            // YourTurn1
            // 
            this.YourTurn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.YourTurn1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("YourTurn1.BackgroundImage")));
            this.YourTurn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.YourTurn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.YourTurn1.Location = new System.Drawing.Point(16, 3);
            this.YourTurn1.Name = "YourTurn1";
            this.YourTurn1.Size = new System.Drawing.Size(194, 109);
            this.YourTurn1.TabIndex = 11;
            this.YourTurn1.TabStop = false;
            // 
            // YourTurn2
            // 
            this.YourTurn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.YourTurn2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("YourTurn2.BackgroundImage")));
            this.YourTurn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.YourTurn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.YourTurn2.Location = new System.Drawing.Point(16, 3);
            this.YourTurn2.Name = "YourTurn2";
            this.YourTurn2.Size = new System.Drawing.Size(194, 107);
            this.YourTurn2.TabIndex = 12;
            this.YourTurn2.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.Controls.Add(this.CopyrightLabel, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.CardGrid, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 5, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.814699F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.15247F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1338, 940);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.Player1NameLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.CardsSelected1, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.Player1NameInput, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.PairsFoundLbl1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(29, 29);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.20442F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.856354F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.756906F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.281768F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.70166F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.977901F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.77348F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(234, 888);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // Player1NameLabel
            // 
            this.Player1NameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Player1NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1NameLabel.ForeColor = System.Drawing.Color.White;
            this.Player1NameLabel.Location = new System.Drawing.Point(3, 0);
            this.Player1NameLabel.Name = "Player1NameLabel";
            this.Player1NameLabel.Size = new System.Drawing.Size(228, 28);
            this.Player1NameLabel.TabIndex = 0;
            this.Player1NameLabel.Text = "Player 1 Name";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel4.Controls.Add(this.YourTurn1, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 196);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(228, 115);
            this.tableLayoutPanel4.TabIndex = 8;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.Player2NameLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.Player2NameInput, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.CardsSelected2, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.PairsFoundLbl2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1070, 29);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.20442F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.966851F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.977901F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.834254F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.48066F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.20442F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.22099F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(234, 888);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // Player2NameLabel
            // 
            this.Player2NameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Player2NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2NameLabel.ForeColor = System.Drawing.Color.White;
            this.Player2NameLabel.Location = new System.Drawing.Point(3, 0);
            this.Player2NameLabel.Name = "Player2NameLabel";
            this.Player2NameLabel.Size = new System.Drawing.Size(228, 28);
            this.Player2NameLabel.TabIndex = 0;
            this.Player2NameLabel.Text = "Player 2 Name";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel5.Controls.Add(this.YourTurn2, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 206);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(228, 113);
            this.tableLayoutPanel5.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1338, 940);
            this.Controls.Add(this.miniToolStrip);
            this.Controls.Add(this.BackgroundImage);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Pairs";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.MainForm_Resize);
            this.miniToolStrip.ResumeLayout(false);
            this.miniToolStrip.PerformLayout();
            this.CardsSelected1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CardSelected12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardSelected11)).EndInit();
            this.CardsSelected2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CardSelected22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardSelected21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YourTurn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YourTurn2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;

        private System.Windows.Forms.Label Player2NameLabel;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;

        private System.Windows.Forms.Label Player1NameLabel;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        private System.Windows.Forms.PictureBox YourTurn2;

        private System.Windows.Forms.PictureBox YourTurn1;

        private System.Windows.Forms.PictureBox BackgroundImage;

        private System.Windows.Forms.TableLayoutPanel CardGrid;

        private System.Windows.Forms.PictureBox CardSelected11;
        private System.Windows.Forms.PictureBox CardSelected12;
        private System.Windows.Forms.PictureBox CardSelected21;
        private System.Windows.Forms.Label CopyrightLabel;

        private System.Windows.Forms.PictureBox CardSelected22;

        private System.Windows.Forms.GroupBox CardsSelected1;
        private System.Windows.Forms.GroupBox CardsSelected2;

        private System.Windows.Forms.Label PairsFoundLbl2;

        private System.Windows.Forms.TextBox Player1NameInput;
        private System.Windows.Forms.TextBox Player2NameInput;
        private System.Windows.Forms.Label PairsFoundLbl1;

        private System.Windows.Forms.ToolStripMenuItem AboutButton;

        private System.Windows.Forms.ToolStripDropDownButton HelpDropdown;

        private System.Windows.Forms.ToolStripMenuItem SizeSelector;
        private System.Windows.Forms.ToolStripMenuItem Size6Button;
        private System.Windows.Forms.ToolStripMenuItem Size10Button;
        private System.Windows.Forms.ToolStripMenuItem Size16Button;

        private System.Windows.Forms.ToolStripDropDownButton SettingsDropdown;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ExitButton;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem SaveGameButton;
        private System.Windows.Forms.ToolStripMenuItem RetrieveGameButton;

        private System.Windows.Forms.ToolStripDropDownButton GameDropdown;
        private System.Windows.Forms.ToolStripMenuItem NewGameButton;

        private System.Windows.Forms.ToolStrip miniToolStrip;

        #endregion
    }
}

