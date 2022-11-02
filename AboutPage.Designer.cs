using System.ComponentModel;

namespace PairsAssignment;

partial class AboutPage
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutPage));
        this.pictureBox1 = new System.Windows.Forms.PictureBox();
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.AboutOkay = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        this.SuspendLayout();
        // 
        // pictureBox1
        // 
        this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
        this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        this.pictureBox1.Location = new System.Drawing.Point(30, 24);
        this.pictureBox1.Name = "pictureBox1";
        this.pictureBox1.Size = new System.Drawing.Size(329, 466);
        this.pictureBox1.TabIndex = 0;
        this.pictureBox1.TabStop = false;
        // 
        // label1
        // 
        this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label1.ForeColor = System.Drawing.Color.White;
        this.label1.Location = new System.Drawing.Point(402, 24);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(466, 77);
        this.label1.TabIndex = 1;
        this.label1.Text = "Pairs";
        // 
        // label2
        // 
        this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label2.ForeColor = System.Drawing.Color.White;
        this.label2.Location = new System.Drawing.Point(402, 101);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(437, 389);
        this.label2.TabIndex = 2;
        this.label2.Text = resources.GetString("label2.Text");
        // 
        // AboutOkay
        // 
        this.AboutOkay.ForeColor = System.Drawing.Color.Black;
        this.AboutOkay.Location = new System.Drawing.Point(342, 510);
        this.AboutOkay.Name = "AboutOkay";
        this.AboutOkay.Size = new System.Drawing.Size(175, 48);
        this.AboutOkay.TabIndex = 3;
        this.AboutOkay.Text = "OK";
        this.AboutOkay.UseVisualStyleBackColor = true;
        this.AboutOkay.Click += new System.EventHandler(this.AboutOkay_Click);
        // 
        // AboutPage
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
        this.ClientSize = new System.Drawing.Size(863, 573);
        this.Controls.Add(this.AboutOkay);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.pictureBox1);
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.Name = "AboutPage";
        this.Text = "About";
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Button AboutOkay;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.PictureBox pictureBox1;

    #endregion
}