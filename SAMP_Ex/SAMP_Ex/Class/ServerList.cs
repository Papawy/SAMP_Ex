using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Net;
using System.Net.Sockets;

using System.Diagnostics;

namespace SAMP_Ex
{
    class ServerList : DataGridView
    {
        protected System.Timers.Timer updateTimer;
        protected System.Timers.Timer selectedServerTimer;

        protected BindingList<Server> SourceList;

        public Image LockedImage { get; set; }
        public Image UnlockedImage { get; set; }
        public Image LockHeaderImage { get; set; }
        
        public double UpdateTimerInterval { get; set; }
        public double UpdateSelectedTimerInterval { get; set; }

        public ServerList() : base()
        {
            this.RowHeadersVisible = false;
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.ReadOnly = true;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            this.ScrollBars = ScrollBars.Vertical;
            this.DoubleBuffered = true;

            System.Windows.Forms.DataGridViewImageColumn lockColumn = new System.Windows.Forms.DataGridViewImageColumn();
            lockColumn.Image = LockHeaderImage;
            lockColumn.HeaderText = "Locked";
            lockColumn.Name = "locked";
            lockColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

            this.Columns.Add(lockColumn);

            this.Columns["locked"].Width = 20;
            this.Columns["locked"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Columns["locked"].Resizable = DataGridViewTriState.False;

            this.AutoGenerateColumns = true;

            this.CellPainting += ImageCellPainting;
            this.RowsAdded += ServerRowsAdded;
            this.CellFormatting += ServerCellFormatting;
            this.DataBindingComplete += ApplyColumnStyle;
            this.SelectionChanged += this.UpdateSelectedServerTick;

			this.VirtualMode = false;

            updateTimer = new System.Timers.Timer();

            updateTimer.Interval = 3000;            
            updateTimer.Elapsed += this.UpdateTimerTick;

            selectedServerTimer = new System.Timers.Timer();

            selectedServerTimer.Interval = 500;
            selectedServerTimer.Elapsed += this.UpdateSelectedServerTick;

		}

        /// <summary>
        /// Add a server to the server list
        /// </summary>
        /// <param name="server">A server instance</param>
        public void AddServer(Server server)
        {
            this.SourceList.Add(server);

        }

        public void AddServerList(BindingList<Server> serverList)
        {
            this.SourceList = serverList;
            this.DataSource = serverList;
            this.Refresh();
			this.UpdateVisibleServers();

            foreach (DataGridViewColumn col in this.Columns)
            {
                if (col.Name != "locked")
                    this.AutoResizeColumn(col.Index);
            }
            
        }

        protected void ApplyColumnStyle(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.Columns["Hostname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Columns["Players"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Columns["Gamemode"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.Columns["MapName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.Columns["Language"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.Columns["Ping"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            this.Refresh();
            this.Update();
        }

		protected new void CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
		{
			Server tmpSrv = (Server)this.SourceList[e.RowIndex];

			switch (this.Columns[e.ColumnIndex].Name)
			{
				case "locked":
					if (tmpSrv.HasPassword)
						e.Value = LockedImage;
					else
						e.Value = UnlockedImage;
					break;
				case "Hostname":
					e.Value = tmpSrv.Hostname;
					break;
				case "Players":
					e.Value = tmpSrv.Players + "/" + tmpSrv.MaxPlayers;
					break;
				case "Gamemode":
					e.Value = tmpSrv.Gamemode;
					break;
				case "MapName":
					e.Value = tmpSrv.MapName;
					break;
				case "Language":
					e.Value = tmpSrv.Language;
					break;
				case "Ping":
					e.Value = tmpSrv.Ping;
					break;
			}
		}

        public Server GetSelectedServer() {
                try
                {
                    return (Server)this.Rows[this.CurrentCell.RowIndex].DataBoundItem;
                }
                catch
                {
                    return new Server("127.0.0.1:7777");
                }
             }

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

		[System.Obsolete("UpdateAllServers is deprecated because of performance issues, use UpdatedVisibleServers instead.")]
        public void UpdateAllServers()
        {
			if(SourceList.Count < 16)
			{
				(new System.Threading.Thread(() => {
					for (int i = 0; i < SourceList.Count; i++)
					{
						SourceList[i].TotalUpdate();
					}
				})).Start();
			}
			else
			{
			}
		}

		public void UpdateVisibleServers()
		{
			foreach(DataGridViewRow row in this.Rows)
			{
				if(row.Displayed)
				{
					(new System.Threading.Thread(() => {
						SourceList[row.Index].TotalUpdate();
					})).Start();
				}
			}
		}

        public void UpdateSelectedServerTick(object sender, EventArgs e)
        {
			(new System.Threading.Thread(() => {
				this.GetSelectedServer().UpdatePing();
			})).Start();
			MethodInvoker inv = delegate
            {
                this.Refresh();
                this.Update();
            };
            this.Invoke(inv);
        }

        public void UpdateTimerTick(object sender, EventArgs e)
        {
            this.UpdateVisibleServers();

            MethodInvoker inv = delegate
            {
                this.Refresh();
                this.Update();
                foreach (DataGridViewColumn col in this.Columns)
                {
                    if (col.Name != "locked")
                        this.AutoResizeColumn(col.Index);
                }
            };
            this.Invoke(inv);
            
        }

        public void StopUpdateTimer()
        {
            updateTimer.Stop();
        }

        public void StartUpdateTimer()
        {
            updateTimer.Start();
        }
    }
}
