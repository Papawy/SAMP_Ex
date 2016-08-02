namespace SAMP_Ex
{
    partial class mainWindow
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.grid_ServerList = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_files = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItm_importFavoritesList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItm_exportFavoritesList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItm_importFavoritesListFromSAMP = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItm_exportFavoritesListToSAMPLauncherFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItm_quit = new System.Windows.Forms.ToolStripMenuItem();
            this.quickConnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_servers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItm_connect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItm_addServer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItm_deleteServer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItm_refreshInfos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItm_copyServerInfos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItm_setProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_tools = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItm_settings = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_help = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItm_site = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItm_about = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLbl_prayForGtaM = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grid_ServerList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_ServerList
            // 
            this.grid_ServerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_ServerList.Location = new System.Drawing.Point(12, 54);
            this.grid_ServerList.Name = "grid_ServerList";
            this.grid_ServerList.Size = new System.Drawing.Size(660, 424);
            this.grid_ServerList.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_files,
            this.quickConnectToolStripMenuItem,
            this.menu_servers,
            this.menu_tools,
            this.menu_help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_files
            // 
            this.menu_files.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItm_importFavoritesList,
            this.menuItm_exportFavoritesList,
            this.toolStripSeparator1,
            this.menuItm_importFavoritesListFromSAMP,
            this.menuItm_exportFavoritesListToSAMPLauncherFormat,
            this.toolStripSeparator2,
            this.menuItm_quit});
            this.menu_files.Name = "menu_files";
            this.menu_files.Size = new System.Drawing.Size(42, 20);
            this.menu_files.Text = "Files";
            // 
            // menuItm_importFavoritesList
            // 
            this.menuItm_importFavoritesList.Image = global::SAMP_Ex.Properties.Resources.download_1;
            this.menuItm_importFavoritesList.Name = "menuItm_importFavoritesList";
            this.menuItm_importFavoritesList.Size = new System.Drawing.Size(313, 22);
            this.menuItm_importFavoritesList.Text = "Import favorites list";
            // 
            // menuItm_exportFavoritesList
            // 
            this.menuItm_exportFavoritesList.Image = global::SAMP_Ex.Properties.Resources.upload_1;
            this.menuItm_exportFavoritesList.Name = "menuItm_exportFavoritesList";
            this.menuItm_exportFavoritesList.Size = new System.Drawing.Size(313, 22);
            this.menuItm_exportFavoritesList.Text = "Export favorites list";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(310, 6);
            // 
            // menuItm_importFavoritesListFromSAMP
            // 
            this.menuItm_importFavoritesListFromSAMP.Image = global::SAMP_Ex.Properties.Resources.download_1;
            this.menuItm_importFavoritesListFromSAMP.Name = "menuItm_importFavoritesListFromSAMP";
            this.menuItm_importFavoritesListFromSAMP.Size = new System.Drawing.Size(313, 22);
            this.menuItm_importFavoritesListFromSAMP.Text = "Import favorites list from SAMP Launcher";
            // 
            // menuItm_exportFavoritesListToSAMPLauncherFormat
            // 
            this.menuItm_exportFavoritesListToSAMPLauncherFormat.Image = global::SAMP_Ex.Properties.Resources.upload_1;
            this.menuItm_exportFavoritesListToSAMPLauncherFormat.Name = "menuItm_exportFavoritesListToSAMPLauncherFormat";
            this.menuItm_exportFavoritesListToSAMPLauncherFormat.Size = new System.Drawing.Size(313, 22);
            this.menuItm_exportFavoritesListToSAMPLauncherFormat.Text = "Export favorites list to SAMP Launcher format";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(310, 6);
            // 
            // menuItm_quit
            // 
            this.menuItm_quit.Image = global::SAMP_Ex.Properties.Resources.logout;
            this.menuItm_quit.Name = "menuItm_quit";
            this.menuItm_quit.Size = new System.Drawing.Size(313, 22);
            this.menuItm_quit.Text = "Quit";
            this.menuItm_quit.Click += new System.EventHandler(this.menuItm_quit_Click);
            // 
            // quickConnectToolStripMenuItem
            // 
            this.quickConnectToolStripMenuItem.Name = "quickConnectToolStripMenuItem";
            this.quickConnectToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.quickConnectToolStripMenuItem.Text = "Quick Connect !";
            this.quickConnectToolStripMenuItem.Click += new System.EventHandler(this.quickConnectToolStripMenuItem_Click);
            // 
            // menu_servers
            // 
            this.menu_servers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItm_connect,
            this.toolStripSeparator3,
            this.menuItm_addServer,
            this.menuItm_deleteServer,
            this.menuItm_refreshInfos,
            this.toolStripSeparator4,
            this.menuItm_copyServerInfos,
            this.menuItm_setProperties});
            this.menu_servers.Name = "menu_servers";
            this.menu_servers.Size = new System.Drawing.Size(56, 20);
            this.menu_servers.Text = "Servers";
            // 
            // menuItm_connect
            // 
            this.menuItm_connect.Image = global::SAMP_Ex.Properties.Resources.next_1;
            this.menuItm_connect.Name = "menuItm_connect";
            this.menuItm_connect.Size = new System.Drawing.Size(146, 22);
            this.menuItm_connect.Text = "Connect";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(143, 6);
            // 
            // menuItm_addServer
            // 
            this.menuItm_addServer.Image = global::SAMP_Ex.Properties.Resources.next;
            this.menuItm_addServer.Name = "menuItm_addServer";
            this.menuItm_addServer.Size = new System.Drawing.Size(146, 22);
            this.menuItm_addServer.Text = "Add server";
            // 
            // menuItm_deleteServer
            // 
            this.menuItm_deleteServer.Image = global::SAMP_Ex.Properties.Resources.garbage;
            this.menuItm_deleteServer.Name = "menuItm_deleteServer";
            this.menuItm_deleteServer.Size = new System.Drawing.Size(146, 22);
            this.menuItm_deleteServer.Text = "Delete server";
            // 
            // menuItm_refreshInfos
            // 
            this.menuItm_refreshInfos.Image = global::SAMP_Ex.Properties.Resources.reload;
            this.menuItm_refreshInfos.Name = "menuItm_refreshInfos";
            this.menuItm_refreshInfos.Size = new System.Drawing.Size(146, 22);
            this.menuItm_refreshInfos.Text = "Refresh infos";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(143, 6);
            // 
            // menuItm_copyServerInfos
            // 
            this.menuItm_copyServerInfos.Image = global::SAMP_Ex.Properties.Resources.copy;
            this.menuItm_copyServerInfos.Name = "menuItm_copyServerInfos";
            this.menuItm_copyServerInfos.Size = new System.Drawing.Size(146, 22);
            this.menuItm_copyServerInfos.Text = "Copy infos";
            // 
            // menuItm_setProperties
            // 
            this.menuItm_setProperties.Image = global::SAMP_Ex.Properties.Resources.edit;
            this.menuItm_setProperties.Name = "menuItm_setProperties";
            this.menuItm_setProperties.Size = new System.Drawing.Size(146, 22);
            this.menuItm_setProperties.Text = "Set properties";
            // 
            // menu_tools
            // 
            this.menu_tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItm_settings});
            this.menu_tools.Name = "menu_tools";
            this.menu_tools.Size = new System.Drawing.Size(47, 20);
            this.menu_tools.Text = "Tools";
            // 
            // menuItm_settings
            // 
            this.menuItm_settings.Image = global::SAMP_Ex.Properties.Resources.settings;
            this.menuItm_settings.Name = "menuItm_settings";
            this.menuItm_settings.Size = new System.Drawing.Size(116, 22);
            this.menuItm_settings.Text = "Settings";
            this.menuItm_settings.Click += new System.EventHandler(this.menuItm_settings_Click);
            // 
            // menu_help
            // 
            this.menu_help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItm_site,
            this.menuItm_about});
            this.menu_help.Name = "menu_help";
            this.menu_help.Size = new System.Drawing.Size(44, 20);
            this.menu_help.Text = "Help";
            // 
            // menuItm_site
            // 
            this.menuItm_site.Image = global::SAMP_Ex.Properties.Resources.house;
            this.menuItm_site.Name = "menuItm_site";
            this.menuItm_site.Size = new System.Drawing.Size(107, 22);
            this.menuItm_site.Text = "Site";
            this.menuItm_site.Click += new System.EventHandler(this.menuItm_site_Click);
            // 
            // menuItm_about
            // 
            this.menuItm_about.Image = global::SAMP_Ex.Properties.Resources.magnifying_glass;
            this.menuItm_about.Name = "menuItm_about";
            this.menuItm_about.Size = new System.Drawing.Size(107, 22);
            this.menuItm_about.Text = "About";
            this.menuItm_about.Click += new System.EventHandler(this.menuItm_about_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLbl_prayForGtaM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(984, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLbl_prayForGtaM
            // 
            this.statusLbl_prayForGtaM.Name = "statusLbl_prayForGtaM";
            this.statusLbl_prayForGtaM.Size = new System.Drawing.Size(112, 17);
            this.statusLbl_prayForGtaM.Text = "#PrayForGTAMaster";
            this.statusLbl_prayForGtaM.Click += new System.EventHandler(this.statusLbl_prayForGtaM_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grid_ServerList);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainWindow";
            this.Text = "SAMP Ex";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_ServerList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_ServerList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_files;
        private System.Windows.Forms.ToolStripMenuItem menuItm_importFavoritesListFromSAMP;
        private System.Windows.Forms.ToolStripMenuItem menuItm_importFavoritesList;
        private System.Windows.Forms.ToolStripMenuItem menuItm_exportFavoritesList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuItm_exportFavoritesListToSAMPLauncherFormat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuItm_quit;
        private System.Windows.Forms.ToolStripMenuItem menu_servers;
        private System.Windows.Forms.ToolStripMenuItem menuItm_connect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuItm_addServer;
        private System.Windows.Forms.ToolStripMenuItem menuItm_deleteServer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem menuItm_refreshInfos;
        private System.Windows.Forms.ToolStripMenuItem menuItm_copyServerInfos;
        private System.Windows.Forms.ToolStripMenuItem menuItm_setProperties;
        private System.Windows.Forms.ToolStripMenuItem menu_tools;
        private System.Windows.Forms.ToolStripMenuItem menu_help;
        private System.Windows.Forms.ToolStripMenuItem menuItm_site;
        private System.Windows.Forms.ToolStripMenuItem menuItm_about;
        private System.Windows.Forms.ToolStripMenuItem menuItm_settings;
        private System.Windows.Forms.ToolStripMenuItem quickConnectToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLbl_prayForGtaM;
    }
}

