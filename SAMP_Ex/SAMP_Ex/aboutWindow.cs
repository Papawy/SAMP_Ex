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
    public partial class aboutWindow : Form
    {
        public aboutWindow()
        {
            InitializeComponent();
            richText_about.SelectAll();
            richText_about.SelectionAlignment = HorizontalAlignment.Center;
            richText_about.DeselectAll();
        }

        private void aboutWindow_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void richText_about_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void aboutWindow_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
