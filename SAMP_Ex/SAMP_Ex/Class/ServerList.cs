using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SAMP_Ex
{
    class ServerList : DataGridView
    {
        public Image LockedImage { get; set; }
        public Image UnlockedImage { get; set; }

        public ServerList() : base()
        {
            this.RowHeadersVisible = false;
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            System.Windows.Forms.DataGridViewImageColumn lockColumn = new System.Windows.Forms.DataGridViewImageColumn();
            lockColumn.Image = LockedImage;

            this.Columns.Add(lockColumn);
            lockColumn.HeaderText = "Locked";
            lockColumn.Name = "locked";

            this.Columns.Add("hostname", "Hostname");
            this.Columns.Add("players", "Players");
            this.Columns.Add("ping", "Ping");
            this.Columns.Add("mode", "Mode");
            this.Columns.Add("language", "Language");

            this.Columns["locked"].Width = 20;
            this.Columns["locked"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

        }

        /// <summary>
        /// Add a server to the server list
        /// </summary>
        /// <param name="server">A server instance</param>
        public void AddServer(Server server)
        {
            if (server.HasPassword)
            {
                this.Rows.Add(LockedImage,
                server.Hostname,
                server.Players + "/" + server.MaxPlayers,
                server.Ping.ToString(),
                server.Gamemode,
                server.Language);
            }
            else
            {
                this.Rows.Add(UnlockedImage,
                server.Hostname,
                server.Players + "/" + server.MaxPlayers,
                server.Ping.ToString(),
                server.Gamemode,
                server.Language);
            }
        }
    }
}
