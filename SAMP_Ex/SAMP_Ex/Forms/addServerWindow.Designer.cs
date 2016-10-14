namespace SAMP_Ex
{
    partial class addServerWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addServerWindow));
            this.txtBox_defaultnick = new System.Windows.Forms.TextBox();
            this.lbl_defaultnick = new System.Windows.Forms.Label();
            this.txtBox_serverip = new System.Windows.Forms.TextBox();
            this.lbl_serverip = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBox_defaultnick
            // 
            this.txtBox_defaultnick.Location = new System.Drawing.Point(42, 102);
            this.txtBox_defaultnick.Name = "txtBox_defaultnick";
            this.txtBox_defaultnick.Size = new System.Drawing.Size(218, 20);
            this.txtBox_defaultnick.TabIndex = 14;
            // 
            // lbl_defaultnick
            // 
            this.lbl_defaultnick.AutoSize = true;
            this.lbl_defaultnick.Location = new System.Drawing.Point(12, 87);
            this.lbl_defaultnick.Name = "lbl_defaultnick";
            this.lbl_defaultnick.Size = new System.Drawing.Size(101, 13);
            this.lbl_defaultnick.TabIndex = 13;
            this.lbl_defaultnick.Text = "Nickname (optional)";
            // 
            // txtBox_serverip
            // 
            this.txtBox_serverip.Location = new System.Drawing.Point(42, 52);
            this.txtBox_serverip.Name = "txtBox_serverip";
            this.txtBox_serverip.Size = new System.Drawing.Size(218, 20);
            this.txtBox_serverip.TabIndex = 12;
            // 
            // lbl_serverip
            // 
            this.lbl_serverip.AutoSize = true;
            this.lbl_serverip.Location = new System.Drawing.Point(12, 36);
            this.lbl_serverip.Name = "lbl_serverip";
            this.lbl_serverip.Size = new System.Drawing.Size(84, 13);
            this.lbl_serverip.TabIndex = 11;
            this.lbl_serverip.Text = "Server IP:PORT";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(76, 182);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(148, 48);
            this.btn_add.TabIndex = 15;
            this.btn_add.Text = "Add !";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(130, 142);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(29, 13);
            this.lbl_error.TabIndex = 16;
            this.lbl_error.Text = "Error";
            this.lbl_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_error.Visible = false;
            // 
            // addServerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 242);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txtBox_defaultnick);
            this.Controls.Add(this.lbl_defaultnick);
            this.Controls.Add(this.txtBox_serverip);
            this.Controls.Add(this.lbl_serverip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addServerWindow";
            this.Text = "Add a server to favorite list";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_defaultnick;
        private System.Windows.Forms.Label lbl_defaultnick;
        private System.Windows.Forms.TextBox txtBox_serverip;
        private System.Windows.Forms.Label lbl_serverip;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_error;
    }
}