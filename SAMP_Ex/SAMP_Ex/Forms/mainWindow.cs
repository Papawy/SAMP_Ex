using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;

namespace SAMP_Ex
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
            if(ConfigFile.Load("config.xml") == false)
            {
                Utils.CreateDefaultConfigFile(System.IO.Directory.GetCurrentDirectory() + @"\\config.xml");
            }
            if (FavFile.Load("favlist.xml") == false)
            {
                Utils.CreateDefaultFavList(System.IO.Directory.GetCurrentDirectory() + @"\\favlist.xml");
            }          
            
            Server myServ = new Server("s2.gta-multiplayer.cz:7777", ConfigFile.GetUserConfig("defaultnick"));

            grid_serverList.UpdateTimerInterval = 3000;

            toolStripTxtBox_nickname.Text = ConfigFile.GetUserConfig("defaultnick");

            WebLists.Load("http://monitor.sacnr.com/list/masterlist.txt", "http://monitor.sacnr.com/list/hostedlist.txt");
            FavFile.GenerateFavList();

            grid_serverList.AddServerList(FavFile.FavList);

            grid_serverList.StartUpdateTimer();
        }


        private void InitializeServerGridView()
        {
            grid_serverList.AutoGenerateColumns = true;
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {

        }

        private void menuItm_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuItm_site_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.sa-mp.com/");
        }

        private void quickConnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quickConnectWindow quickConForm = new quickConnectWindow();
            quickConForm.Show();
        }

        private void menuItm_about_Click(object sender, EventArgs e)
        {
            aboutWindow aboutForm = new aboutWindow();
            aboutForm.Show();
        }

        private void menuItm_settings_Click(object sender, EventArgs e)
        {
            settingsWindow settingsForm = new settingsWindow();
            settingsForm.Show();
        }

        private void statusLbl_prayForGtaM_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://gtamaster.eu/");
        }

        private void mainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            grid_serverList.StopUpdateTimer();
        }

        private void toolStripBtn_connect_Click(object sender, EventArgs e)
        {
            int nickOption = 0; // for debug purpose
            string nick = ConfigFile.GetUserConfig("defaultnick");
            if (chckBox_useNicknameDefault.Checked && (!String.IsNullOrWhiteSpace(toolStripTxtBox_nickname.Text)))
            {
                nickOption = 1;
                nick = toolStripTxtBox_nickname.Text;
            }
            else if(!String.IsNullOrWhiteSpace( grid_serverList.GetSelectedServer().Nickname))
            {
                nickOption = 2;
                nick = grid_serverList.GetSelectedServer().Nickname;
            }
            Debug.WriteLine("Version : " + grid_serverList.GetSelectedServer().GetVersion());
            Debug.WriteLine("Nickname used ("+nickOption+") : " + nick);
            GTAUtils.ConnectClientTo(grid_serverList.GetSelectedServer(), nick, false);
        }

        private void tabCtrl_serversLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tabctrl = (TabControl)sender;

            switch(tabctrl.SelectedIndex)
            {
                case 0:
                    {
                        grid_serverList.AddServerList(FavFile.FavList);
                        break;
                    }
                case 1:
                    {
                        grid_serverList.AddServerList(WebLists.InternetList);
                        break;
                    }
                case 2:
                    {
                        grid_serverList.AddServerList(WebLists.HostedList);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void toolStripBtn_refreshServer_Click(object sender, EventArgs e)
        {
            grid_serverList.UpdateVisibleServers();
        }

        private void toolStripBtn_addServer_Click(object sender, EventArgs e)
        {
            addServerWindow addServerForm = new addServerWindow();
            addServerForm.Show();          
        }

        private void toolStripBtn_deleteServer_Click(object sender, EventArgs e)
        {
            if (tabCtrl_serversLists.SelectedIndex == 0)
            {
                FavFile.DeleteServer(grid_serverList.GetSelectedServer());
                FavFile.Save();
            }              
        }
    }
}
