namespace SAMP_Ex
{
    partial class settingsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingsWindow));
            this.lbl_gtaDir = new System.Windows.Forms.Label();
            this.fileDialog_gtaSaExe = new System.Windows.Forms.OpenFileDialog();
            this.txtBox_gtaPath = new System.Windows.Forms.TextBox();
            this.btn_openFileDiag = new System.Windows.Forms.Button();
            this.lbl_setNick = new System.Windows.Forms.Label();
            this.txtBox_setNick = new System.Windows.Forms.TextBox();
            this.btn_accept = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_gtaDir
            // 
            this.lbl_gtaDir.AutoSize = true;
            this.lbl_gtaDir.Location = new System.Drawing.Point(9, 25);
            this.lbl_gtaDir.Name = "lbl_gtaDir";
            this.lbl_gtaDir.Size = new System.Drawing.Size(164, 13);
            this.lbl_gtaDir.TabIndex = 0;
            this.lbl_gtaDir.Text = "Change GTA installation directory";
            // 
            // txtBox_gtaPath
            // 
            this.txtBox_gtaPath.Location = new System.Drawing.Point(36, 41);
            this.txtBox_gtaPath.Name = "txtBox_gtaPath";
            this.txtBox_gtaPath.Size = new System.Drawing.Size(351, 20);
            this.txtBox_gtaPath.TabIndex = 1;
            // 
            // btn_openFileDiag
            // 
            this.btn_openFileDiag.BackgroundImage = global::SAMP_Ex.Properties.Resources.folder;
            this.btn_openFileDiag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_openFileDiag.FlatAppearance.BorderSize = 0;
            this.btn_openFileDiag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_openFileDiag.Location = new System.Drawing.Point(393, 41);
            this.btn_openFileDiag.Name = "btn_openFileDiag";
            this.btn_openFileDiag.Size = new System.Drawing.Size(28, 20);
            this.btn_openFileDiag.TabIndex = 2;
            this.btn_openFileDiag.UseVisualStyleBackColor = true;
            this.btn_openFileDiag.Click += new System.EventHandler(this.btn_openFileDiag_Click);
            // 
            // lbl_setNick
            // 
            this.lbl_setNick.AutoSize = true;
            this.lbl_setNick.Location = new System.Drawing.Point(9, 87);
            this.lbl_setNick.Name = "lbl_setNick";
            this.lbl_setNick.Size = new System.Drawing.Size(128, 13);
            this.lbl_setNick.TabIndex = 3;
            this.lbl_setNick.Text = "Change default nickname";
            // 
            // txtBox_setNick
            // 
            this.txtBox_setNick.Location = new System.Drawing.Point(36, 103);
            this.txtBox_setNick.Name = "txtBox_setNick";
            this.txtBox_setNick.Size = new System.Drawing.Size(100, 20);
            this.txtBox_setNick.TabIndex = 4;
            // 
            // btn_accept
            // 
            this.btn_accept.Location = new System.Drawing.Point(265, 169);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(75, 23);
            this.btn_accept.TabIndex = 5;
            this.btn_accept.Text = "Accept";
            this.btn_accept.UseVisualStyleBackColor = true;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(346, 169);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // settingsWindow
            // 
            this.AcceptButton = this.btn_accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 204);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_accept);
            this.Controls.Add(this.txtBox_setNick);
            this.Controls.Add(this.lbl_setNick);
            this.Controls.Add(this.btn_openFileDiag);
            this.Controls.Add(this.txtBox_gtaPath);
            this.Controls.Add(this.lbl_gtaDir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "settingsWindow";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_gtaDir;
        private System.Windows.Forms.OpenFileDialog fileDialog_gtaSaExe;
        private System.Windows.Forms.TextBox txtBox_gtaPath;
        private System.Windows.Forms.Button btn_openFileDiag;
        private System.Windows.Forms.Label lbl_setNick;
        private System.Windows.Forms.TextBox txtBox_setNick;
        private System.Windows.Forms.Button btn_accept;
        private System.Windows.Forms.Button btn_cancel;
    }
}