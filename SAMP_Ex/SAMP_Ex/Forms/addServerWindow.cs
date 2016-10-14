using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;

namespace SAMP_Ex
{
    public partial class addServerWindow : Form
    {
        public addServerWindow()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(Utils.IsValidIpAddress(Utils.ParseIPFromIPPort(txtBox_serverip.Text)) && Utils.IsValidPort(Utils.ParsePortFromIPPort(txtBox_serverip.Text)))
            {
                string defaultnick = txtBox_defaultnick.Text;
                if (String.IsNullOrWhiteSpace(txtBox_defaultnick.Text))
                    defaultnick = ConfigFile.GetUserConfig("defaultnick");

               if(! FavFile.AddServer(new Server(txtBox_serverip.Text, defaultnick), defaultnick))
                {
                    lbl_error.Text = "Something is broken (maybe you already have this server ?) !";
                    ShowErrorLabel(3000);
                }
                else
                {
                    FavFile.GenerateFavList();
                    FavFile.Save();
                    this.Close();
                }
            }
            else
            {
                lbl_error.Text = "Incorrect IP Format";
                ShowErrorLabel(3000);
            }                     
        }

        public async void ShowErrorLabel(int timeInMilliseconds)
        {
            lbl_error.Visible = true;
            await Task.Delay(timeInMilliseconds);
            lbl_error.Visible = false;
        }
    }
}
