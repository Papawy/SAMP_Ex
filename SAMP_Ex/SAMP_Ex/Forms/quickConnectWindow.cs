using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAMP_Ex
{
    public partial class quickConnectWindow : Form
    {
        public quickConnectWindow()
        {
            InitializeComponent();
            txtBox_nickname.Text = ConfigFile.GetUserConfig("defaultnick");
        }

        private void btn_quickCon_Click(object sender, EventArgs e)
        {

            lbl_error.Text = "Error : ";
            bool errorOccured = false;
            if(!Utils.IsValidIpAddress(Utils.ParseIPFromIPPort(txtBox_hostAddr.Text)))
            {
                lbl_error.Text += "invalid host address ";
                errorOccured = true;
            }
            if (txtBox_nickname.Text.Length == 0)
            {
                lbl_error.Text += "invalid nickname";
                errorOccured = true;
            }

            if (errorOccured) { ShowErrorLabel(5000); return; }

            if(chckBox_debugMode.Checked)
                GTAUtils.LaunchGTAInjected(Utils.ParseIPFromIPPort(txtBox_hostAddr.Text), Utils.ParsePortFromIPPort(txtBox_hostAddr.Text), txtBox_nickname.Text, txtBox_password.Text, true);
            else
                GTAUtils.LaunchGTAInjected(Utils.ParseIPFromIPPort(txtBox_hostAddr.Text), Utils.ParsePortFromIPPort(txtBox_hostAddr.Text), txtBox_nickname.Text, txtBox_password.Text);

            this.Close();
            return;
        }

        public async void ShowErrorLabel(int timeInMilliseconds)
        {
            lbl_error.Visible = true;
            await Task.Delay(timeInMilliseconds);
            lbl_error.Visible = false;
        }
    }
}
