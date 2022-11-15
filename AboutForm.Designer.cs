using System.ComponentModel;

namespace PairsAssignment;

partial class AboutForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
        this.pictureBox1 = new System.Windows.Forms.PictureBox();
        this.label1 = new System.Windows.Forms.Label();
        this.AboutOkay = new System.Windows.Forms.Button();
        this.textBox1 = new System.Windows.Forms.TextBox();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        this.SuspendLayout();
        // 
        // pictureBox1
        // 
        this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
        this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        this.pictureBox1.Location = new System.Drawing.Point(27, 19);
        this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
        this.pictureBox1.Name = "pictureBox1";
        this.pictureBox1.Size = new System.Drawing.Size(292, 373);
        this.pictureBox1.TabIndex = 0;
        this.pictureBox1.TabStop = false;
        // 
        // label1
        // 
        this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label1.ForeColor = System.Drawing.Color.White;
        this.label1.Location = new System.Drawing.Point(357, 19);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(414, 62);
        this.label1.TabIndex = 1;
        this.label1.Text = "Pairs";
        // 
        // AboutOkay
        // 
        this.AboutOkay.ForeColor = System.Drawing.Color.Black;
        this.AboutOkay.Location = new System.Drawing.Point(304, 408);
        this.AboutOkay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
        this.AboutOkay.Name = "AboutOkay";
        this.AboutOkay.Size = new System.Drawing.Size(156, 38);
        this.AboutOkay.TabIndex = 3;
        this.AboutOkay.Text = "OK";
        this.AboutOkay.UseVisualStyleBackColor = true;
        this.AboutOkay.Click += new System.EventHandler(this.AboutOkay_Click);
        // 
        // textBox1
        // 
        this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
        this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.textBox1.ForeColor = System.Drawing.Color.White;
        this.textBox1.Location = new System.Drawing.Point(357, 83);
        this.textBox1.Multiline = true;
        this.textBox1.Name = "textBox1";
        this.textBox1.ReadOnly = true;
        this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.textBox1.Size = new System.Drawing.Size(377, 309);
        this.textBox1.TabIndex = 4;
        this.textBox1.Text = resources.GetString("textBox1.Text");
        // 
        // AboutForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
        this.ClientSize = new System.Drawing.Size(767, 458);
        this.Controls.Add(this.textBox1);
        this.Controls.Add(this.AboutOkay);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.pictureBox1);
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
        this.Name = "AboutForm";
        this.Text = "About";
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.TextBox textBox1;

    private System.Windows.Forms.Button AboutOkay;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.PictureBox pictureBox1;

    #endregion
}