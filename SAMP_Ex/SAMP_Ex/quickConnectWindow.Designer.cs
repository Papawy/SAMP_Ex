namespace SAMP_Ex
{
    partial class quickConnectWindow
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
            this.lbl_hostAddr = new System.Windows.Forms.Label();
            this.txtBox_hostAddr = new System.Windows.Forms.TextBox();
            this.txtBox_port = new System.Windows.Forms.TextBox();
            this.lbl_port = new System.Windows.Forms.Label();
            this.txtBox_nickname = new System.Windows.Forms.TextBox();
            this.lbl_nickname = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.lbl_error = new System.Windows.Forms.Label();
            this.btn_quickCon = new System.Windows.Forms.Button();
            this.chckBox_debugMode = new System.Windows.Forms.CheckBox();
            this.txtBox_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_hostAddr
            // 
            this.lbl_hostAddr.AutoSize = true;
            this.lbl_hostAddr.Location = new System.Drawing.Point(10, 20);
            this.lbl_hostAddr.Name = "lbl_hostAddr";
            this.lbl_hostAddr.Size = new System.Drawing.Size(69, 13);
            this.lbl_hostAddr.TabIndex = 0;
            this.lbl_hostAddr.Text = "Host address";
            // 
            // txtBox_hostAddr
            // 
            this.txtBox_hostAddr.Location = new System.Drawing.Point(40, 35);
            this.txtBox_hostAddr.Name = "txtBox_hostAddr";
            this.txtBox_hostAddr.Size = new System.Drawing.Size(100, 20);
            this.txtBox_hostAddr.TabIndex = 1;
            this.txtBox_hostAddr.Text = "127.0.0.1";
            // 
            // txtBox_port
            // 
            this.txtBox_port.Location = new System.Drawing.Point(42, 85);
            this.txtBox_port.Name = "txtBox_port";
            this.txtBox_port.Size = new System.Drawing.Size(100, 20);
            this.txtBox_port.TabIndex = 3;
            this.txtBox_port.Text = "7777";
            // 
            // lbl_port
            // 
            this.lbl_port.AutoSize = true;
            this.lbl_port.Location = new System.Drawing.Point(12, 70);
            this.lbl_port.Name = "lbl_port";
            this.lbl_port.Size = new System.Drawing.Size(50, 13);
            this.lbl_port.TabIndex = 2;
            this.lbl_port.Text = "Host port";
            // 
            // txtBox_nickname
            // 
            this.txtBox_nickname.Location = new System.Drawing.Point(42, 138);
            this.txtBox_nickname.Name = "txtBox_nickname";
            this.txtBox_nickname.Size = new System.Drawing.Size(100, 20);
            this.txtBox_nickname.TabIndex = 5;
            // 
            // lbl_nickname
            // 
            this.lbl_nickname.AutoSize = true;
            this.lbl_nickname.Location = new System.Drawing.Point(12, 123);
            this.lbl_nickname.Name = "lbl_nickname";
            this.lbl_nickname.Size = new System.Drawing.Size(55, 13);
            this.lbl_nickname.TabIndex = 4;
            this.lbl_nickname.Text = "Nickname";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(10, 181);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(29, 13);
            this.lbl_error.TabIndex = 6;
            this.lbl_error.Text = "Error";
            this.lbl_error.Visible = false;
            // 
            // btn_quickCon
            // 
            this.btn_quickCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quickCon.Location = new System.Drawing.Point(75, 210);
            this.btn_quickCon.Name = "btn_quickCon";
            this.btn_quickCon.Size = new System.Drawing.Size(150, 40);
            this.btn_quickCon.TabIndex = 7;
            this.btn_quickCon.Text = "Connect !";
            this.btn_quickCon.UseVisualStyleBackColor = true;
            this.btn_quickCon.Click += new System.EventHandler(this.btn_quickCon_Click);
            // 
            // chckBox_debugMode
            // 
            this.chckBox_debugMode.AutoSize = true;
            this.chckBox_debugMode.Location = new System.Drawing.Point(220, 141);
            this.chckBox_debugMode.Name = "chckBox_debugMode";
            this.chckBox_debugMode.Size = new System.Drawing.Size(87, 17);
            this.chckBox_debugMode.TabIndex = 8;
            this.chckBox_debugMode.Text = "Debug mode";
            this.chckBox_debugMode.UseVisualStyleBackColor = true;
            // 
            // txtBox_password
            // 
            this.txtBox_password.Location = new System.Drawing.Point(205, 85);
            this.txtBox_password.Name = "txtBox_password";
            this.txtBox_password.Size = new System.Drawing.Size(100, 20);
            this.txtBox_password.TabIndex = 10;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(175, 70);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(99, 13);
            this.lbl_password.TabIndex = 9;
            this.lbl_password.Text = "Password (optional)";
            // 
            // quickConnectWindow
            // 
            this.AcceptButton = this.btn_quickCon;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 261);
            this.Controls.Add(this.txtBox_password);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.chckBox_debugMode);
            this.Controls.Add(this.btn_quickCon);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.txtBox_nickname);
            this.Controls.Add(this.lbl_nickname);
            this.Controls.Add(this.txtBox_port);
            this.Controls.Add(this.lbl_port);
            this.Controls.Add(this.txtBox_hostAddr);
            this.Controls.Add(this.lbl_hostAddr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "quickConnectWindow";
            this.Text = "Quick Connect";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_hostAddr;
        private System.Windows.Forms.TextBox txtBox_hostAddr;
        private System.Windows.Forms.TextBox txtBox_port;
        private System.Windows.Forms.Label lbl_port;
        private System.Windows.Forms.TextBox txtBox_nickname;
        private System.Windows.Forms.Label lbl_nickname;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Button btn_quickCon;
        private System.Windows.Forms.CheckBox chckBox_debugMode;
        private System.Windows.Forms.TextBox txtBox_password;
        private System.Windows.Forms.Label lbl_password;
    }
}