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
    public partial class settingsWindow : Form
    { 
        public settingsWindow()
        {
            InitializeComponent();
            fileDialog_gtaSaExe.Filter = "Exe Files|*.exe";
            string gtaPath = ConfigFile.GetUserConfig("gtapath");
            if (gtaPath.Length == 0)
                txtBox_gtaPath.Text = GtaLauncher.GetGTADir();
            else
                txtBox_gtaPath.Text = gtaPath;

            txtBox_setNick.Text = ConfigFile.GetUserConfig("defaultnick");
        }

        private void btn_openFileDiag_Click(object sender, EventArgs e)
        {
            DialogResult result = fileDialog_gtaSaExe.ShowDialog();
            if(result == DialogResult.OK)
            {            
                txtBox_gtaPath.Text = System.IO.Path.GetDirectoryName(fileDialog_gtaSaExe.FileName);
            }
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            ConfigFile.SetUserConfig("gtapath", txtBox_gtaPath.Text);
            ConfigFile.SetUserConfig("defaultnick", txtBox_setNick.Text);
            ConfigFile.Save();
            Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
