using System.ComponentModel;

namespace PairsAssignment;

partial class PlayerNameEntry
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        this.NameEntryLabel = new System.Windows.Forms.Label();
        this.NameEntry = new System.Windows.Forms.TextBox();
        this.OkayButton = new System.Windows.Forms.Button();
        this.CancelButton = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // NameEntryLabel
        // 
        this.NameEntryLabel.ForeColor = System.Drawing.Color.White;
        this.NameEntryLabel.Location = new System.Drawing.Point(12, 9);
        this.NameEntryLabel.Name = "NameEntryLabel";
        this.NameEntryLabel.Size = new System.Drawing.Size(229, 22);
        this.NameEntryLabel.TabIndex = 0;
        this.NameEntryLabel.Text = "Please enter a name for player X:";
        // 
        // NameEntry
        // 
        this.NameEntry.Location = new System.Drawing.Point(15, 38);
        this.NameEntry.Name = "NameEntry";
        this.NameEntry.Size = new System.Drawing.Size(214, 22);
        this.NameEntry.TabIndex = 1;
        // 
        // OkayButton
        // 
        this.OkayButton.Location = new System.Drawing.Point(247, 9);
        this.OkayButton.Name = "OkayButton";
        this.OkayButton.Size = new System.Drawing.Size(77, 24);
        this.OkayButton.TabIndex = 2;
        this.OkayButton.Text = "OK";
        this.OkayButton.UseVisualStyleBackColor = true;
        this.OkayButton.Click += new System.EventHandler(this.Close);
        // 
        // CancelButton
        // 
        this.CancelButton.Location = new System.Drawing.Point(247, 37);
        this.CancelButton.Name = "CancelButton";
        this.CancelButton.Size = new System.Drawing.Size(77, 24);
        this.CancelButton.TabIndex = 3;
        this.CancelButton.Text = "Cancel";
        this.CancelButton.UseVisualStyleBackColor = true;
        this.CancelButton.Click += new System.EventHandler(this.Close);
        // 
        // PlayerNameEntry
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
        this.ClientSize = new System.Drawing.Size(339, 75);
        this.Controls.Add(this.CancelButton);
        this.Controls.Add(this.OkayButton);
        this.Controls.Add(this.NameEntry);
        this.Controls.Add(this.NameEntryLabel);
        this.Name = "PlayerNameEntry";
        this.Text = "Enter Name";
        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlayerNameEntry_KeyDown);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.TextBox NameEntry;
    private System.Windows.Forms.Button OkayButton;
    private System.Windows.Forms.Button CancelButton;

    private System.Windows.Forms.Label NameEntryLabel;

    #endregion
}