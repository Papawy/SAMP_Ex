namespace SAMP_Ex
{
    partial class aboutWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutWindow));
            this.richText_about = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richText_about
            // 
            this.richText_about.BackColor = System.Drawing.Color.White;
            this.richText_about.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richText_about.Cursor = System.Windows.Forms.Cursors.Default;
            this.richText_about.Location = new System.Drawing.Point(63, 157);
            this.richText_about.Name = "richText_about";
            this.richText_about.ReadOnly = true;
            this.richText_about.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richText_about.Size = new System.Drawing.Size(301, 92);
            this.richText_about.TabIndex = 0;
            this.richText_about.Text = "SAMP Ex launcher made by\nPapawy & S4t3k & all contributors\nIcons designed by Made" +
    "byoliver  and distributed by Flaticon\n\nfrom https://sa-mp-fr.com\n\nSpecial thanks" +
    " to the SAMP team";
            this.richText_about.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richText_about_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SAMP_Ex.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(63, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 127);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // aboutWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richText_about);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "aboutWindow";
            this.Text = "aboutWindow";
            this.Click += new System.EventHandler(this.aboutWindow_Click);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.aboutWindow_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richText_about;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}