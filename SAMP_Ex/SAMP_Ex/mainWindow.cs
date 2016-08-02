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

namespace SAMP_Ex
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
            if(ConfigFile.Load("config.xml") == false)
            {
                //System.IO.File.Create(System.IO.Directory.GetCurrentDirectory() + @"\\config.xml");

                XDocument doc = new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XComment("Launcher configuration file"),
                    new XElement("configuration",
                        new XElement("user",
                            new XElement("defaultnick", ""),
                            new XElement("gtapath", GtaLauncher.GetGTADir()))));

                doc.Save(System.IO.Directory.GetCurrentDirectory() + @"\\config.xml");
            }

        }

        private void InitializeServerGridView()
        {
            grid_ServerList.AutoGenerateColumns = true;
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
    }
}
