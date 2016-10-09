using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

using System.Diagnostics;

namespace SAMP_Ex
{
    class ServerList : DataGridView
    {
        protected System.Timers.Timer updateTimer;

        protected List<Server> SourceList;

        public Image LockedImage { get; set; }
        public Image UnlockedImage { get; set; }
        public Image LockHeaderImage { get; set; }
        
        public int UpdateTimerInterval { get; set; }

        public ServerList() : base()
        {
            this.RowHeadersVisible = false;
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.ReadOnly = true;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            System.Windows.Forms.DataGridViewImageColumn lockColumn = new System.Windows.Forms.DataGridViewImageColumn();
            lockColumn.Image = LockHeaderImage;
            lockColumn.HeaderText = "Locked";
            lockColumn.Name = "locked";
            lockColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;


            this.AutoGenerateColumns = true;

            this.Columns.Add(lockColumn);

            /*this.Columns.Add("Hostname", "Hostname");
            this.Columns.Add("players", "Players");
            this.Columns.Add("ping", "Ping");
            this.Columns.Add("mode", "Mode");
            this.Columns.Add("language", "Language");*/

            this.Columns["locked"].Width = 20;
            this.Columns["locked"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Columns["locked"].Resizable = DataGridViewTriState.False;

            this.CellPainting += ImageCellPainting;
            this.RowsAdded += ServerRowsAdded;
            this.CellFormatting += ServerCellFormatting;

            //updateTimer.Interval = UpdateTimerInterval;

        }

        /// <summary>
        /// Add a server to the server list
        /// </summary>
        /// <param name="server">A server instance</param>
        public void AddServer(Server server)
        {
            this.SourceList.Add(server);
           /* if (server.HasPassword)
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
            }*/
        }

        public void AddServerList(List<Server> serverList)
        {
            this.SourceList = serverList;
            this.DataSource = serverList;
            this.Columns["Hostname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        public Server GetSelectedServer() { return (Server)this.Rows[this.CurrentCell.RowIndex].DataBoundItem; }

        protected void ImageCellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex == -1)
            {
                e.PaintBackground(e.ClipBounds, false);

                e.Graphics.DrawImage(LockHeaderImage, e.CellBounds);
                e.Handled = true;
            }
        }

        protected void ServerRowsAdded(object sender, System.Windows.Forms.DataGridViewRowsAddedEventArgs e)
        {
            for (int index = e.RowIndex; index <= e.RowIndex + e.RowCount - 1; index++)
            {
                DataGridViewRow row = this.Rows[index];
                Server servAdded = (Server)row.DataBoundItem;

                if(servAdded.HasPassword)
                {
                    row.Cells["locked"].Value = LockedImage;
                }
                else
                {
                    row.Cells["locked"].Value = UnlockedImage;
                }
                foreach(DataGridViewCell cell in row.Cells)
                {
                    Debug.WriteLine(this.Columns[cell.ColumnIndex].Name.ToString());
                }
            }
        }

        protected void ServerCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(this.Columns[e.ColumnIndex].Name == "Players")
            {
                Server servAdded = (Server)this.Rows[e.RowIndex].DataBoundItem;
                e.Value = servAdded.Players + "/" + servAdded.MaxPlayers;
            }
        }

        public void UpdateTimerTick(object sender, EventArgs e)
        {
            
        }

        public void StartUpdateTimer()
        {
            
        }
    }
}
