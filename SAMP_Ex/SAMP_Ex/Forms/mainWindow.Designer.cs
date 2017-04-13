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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.menuStrip_main = new System.Windows.Forms.MenuStrip();
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
            this.tabCtrl_serversLists = new System.Windows.Forms.TabControl();
            this.tab_favorites = new System.Windows.Forms.TabPage();
            this.tab_internet = new System.Windows.Forms.TabPage();
            this.tab_hosted = new System.Windows.Forms.TabPage();
            this.toolStrip_quickBtn = new System.Windows.Forms.ToolStrip();
            this.toolStripBtn_connect = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtn_addServer = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtn_deleteServer = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtn_refreshServer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtn_copyServerInfos = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtn_editServerInfos = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtn_settings = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtn_sampSite = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtn_about = new System.Windows.Forms.ToolStripButton();
            this.grpBox_serverInfos = new System.Windows.Forms.GroupBox();
            this.grpBox_filters = new System.Windows.Forms.GroupBox();
            this.tableLayout_filterAndServerInfo = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer_main = new System.Windows.Forms.SplitContainer();
            this.grid_serverList = new SAMP_Ex.ServerList();
            this.splitContainer_serverInfo = new System.Windows.Forms.SplitContainer();
            this.grid_playerList = new System.Windows.Forms.DataGridView();
            this.grid_serverInfo = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripTxtBox_nickname = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLbl_name = new System.Windows.Forms.ToolStripLabel();
            this.chckBox_useNicknameDefault = new System.Windows.Forms.CheckBox();
            this.menuStrip_main.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabCtrl_serversLists.SuspendLayout();
            this.toolStrip_quickBtn.SuspendLayout();
            this.tableLayout_filterAndServerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_main)).BeginInit();
            this.splitContainer_main.Panel1.SuspendLayout();
            this.splitContainer_main.Panel2.SuspendLayout();
            this.splitContainer_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_serverList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_serverInfo)).BeginInit();
            this.splitContainer_serverInfo.Panel1.SuspendLayout();
            this.splitContainer_serverInfo.Panel2.SuspendLayout();
            this.splitContainer_serverInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_playerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_serverInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip_main
            // 
            this.menuStrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_files,
            this.quickConnectToolStripMenuItem,
            this.menu_servers,
            this.menu_tools,
            this.menu_help});
            this.menuStrip_main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_main.Name = "menuStrip_main";
            this.menuStrip_main.Size = new System.Drawing.Size(1284, 24);
            this.menuStrip_main.TabIndex = 2;
            this.menuStrip_main.Text = "mainMenu";
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
            this.menuItm_quit.Image = global::SAMP_Ex.Properties.Resources.exit_1;
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
            this.menuItm_connect.Image = global::SAMP_Ex.Properties.Resources.play_button;
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
            this.menuItm_addServer.Image = global::SAMP_Ex.Properties.Resources.add1;
            this.menuItm_addServer.Name = "menuItm_addServer";
            this.menuItm_addServer.Size = new System.Drawing.Size(146, 22);
            this.menuItm_addServer.Text = "Add server";
            // 
            // menuItm_deleteServer
            // 
            this.menuItm_deleteServer.Image = global::SAMP_Ex.Properties.Resources.garbage_2;
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
            this.menuItm_settings.Image = global::SAMP_Ex.Properties.Resources.settings_6;
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
            this.statusStrip1.AllowMerge = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLbl_prayForGtaM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 639);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1284, 22);
            this.statusStrip1.SizingGrip = false;
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
            // tabCtrl_serversLists
            // 
            this.tabCtrl_serversLists.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabCtrl_serversLists.Controls.Add(this.tab_favorites);
            this.tabCtrl_serversLists.Controls.Add(this.tab_internet);
            this.tabCtrl_serversLists.Controls.Add(this.tab_hosted);
            this.tabCtrl_serversLists.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabCtrl_serversLists.ItemSize = new System.Drawing.Size(90, 18);
            this.tabCtrl_serversLists.Location = new System.Drawing.Point(0, 616);
            this.tabCtrl_serversLists.Name = "tabCtrl_serversLists";
            this.tabCtrl_serversLists.Padding = new System.Drawing.Point(20, 5);
            this.tabCtrl_serversLists.SelectedIndex = 0;
            this.tabCtrl_serversLists.Size = new System.Drawing.Size(1284, 23);
            this.tabCtrl_serversLists.TabIndex = 4;
            this.tabCtrl_serversLists.TabStop = false;
            this.tabCtrl_serversLists.SelectedIndexChanged += new System.EventHandler(this.tabCtrl_serversLists_SelectedIndexChanged);
            // 
            // tab_favorites
            // 
            this.tab_favorites.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_favorites.Location = new System.Drawing.Point(4, 4);
            this.tab_favorites.Name = "tab_favorites";
            this.tab_favorites.Padding = new System.Windows.Forms.Padding(3);
            this.tab_favorites.Size = new System.Drawing.Size(1276, 0);
            this.tab_favorites.TabIndex = 0;
            this.tab_favorites.Text = "Favorites";
            this.tab_favorites.UseVisualStyleBackColor = true;
            // 
            // tab_internet
            // 
            this.tab_internet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_internet.Location = new System.Drawing.Point(4, 4);
            this.tab_internet.Name = "tab_internet";
            this.tab_internet.Padding = new System.Windows.Forms.Padding(3);
            this.tab_internet.Size = new System.Drawing.Size(1276, 0);
            this.tab_internet.TabIndex = 1;
            this.tab_internet.Text = "Internet";
            this.tab_internet.UseVisualStyleBackColor = true;
            // 
            // tab_hosted
            // 
            this.tab_hosted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_hosted.Location = new System.Drawing.Point(4, 4);
            this.tab_hosted.Name = "tab_hosted";
            this.tab_hosted.Padding = new System.Windows.Forms.Padding(3);
            this.tab_hosted.Size = new System.Drawing.Size(1276, 0);
            this.tab_hosted.TabIndex = 2;
            this.tab_hosted.Text = "Hosted";
            this.tab_hosted.UseVisualStyleBackColor = true;
            // 
            // toolStrip_quickBtn
            // 
            this.toolStrip_quickBtn.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip_quickBtn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtn_connect,
            this.toolStripSeparator5,
            this.toolStripBtn_addServer,
            this.toolStripBtn_deleteServer,
            this.toolStripBtn_refreshServer,
            this.toolStripSeparator6,
            this.toolStripBtn_copyServerInfos,
            this.toolStripBtn_editServerInfos,
            this.toolStripSeparator8,
            this.toolStripBtn_settings,
            this.toolStripSeparator7,
            this.toolStripBtn_sampSite,
            this.toolStripBtn_about,
            this.toolStripSeparator9,
            this.toolStripLbl_name,
            this.toolStripTxtBox_nickname});
            this.toolStrip_quickBtn.Location = new System.Drawing.Point(0, 24);
            this.toolStrip_quickBtn.Name = "toolStrip_quickBtn";
            this.toolStrip_quickBtn.Size = new System.Drawing.Size(1284, 25);
            this.toolStrip_quickBtn.TabIndex = 6;
            this.toolStrip_quickBtn.Text = "toolStrip1";
            // 
            // toolStripBtn_connect
            // 
            this.toolStripBtn_connect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtn_connect.Image = global::SAMP_Ex.Properties.Resources.play_button;
            this.toolStripBtn_connect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn_connect.Name = "toolStripBtn_connect";
            this.toolStripBtn_connect.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtn_connect.Text = "toolStripBtn_connect";
            this.toolStripBtn_connect.ToolTipText = "Connect";
            this.toolStripBtn_connect.Click += new System.EventHandler(this.toolStripBtn_connect_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.AutoSize = false;
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(10, 25);
            // 
            // toolStripBtn_addServer
            // 
            this.toolStripBtn_addServer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtn_addServer.Image = global::SAMP_Ex.Properties.Resources.add1;
            this.toolStripBtn_addServer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn_addServer.Name = "toolStripBtn_addServer";
            this.toolStripBtn_addServer.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtn_addServer.Text = "toolStripBtn_addServer";
            this.toolStripBtn_addServer.ToolTipText = "Add server";
            this.toolStripBtn_addServer.Click += new System.EventHandler(this.toolStripBtn_addServer_Click);
            // 
            // toolStripBtn_deleteServer
            // 
            this.toolStripBtn_deleteServer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtn_deleteServer.Image = global::SAMP_Ex.Properties.Resources.garbage_2;
            this.toolStripBtn_deleteServer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn_deleteServer.Name = "toolStripBtn_deleteServer";
            this.toolStripBtn_deleteServer.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtn_deleteServer.Text = "toolStripBtn_deleteServer";
            this.toolStripBtn_deleteServer.ToolTipText = "Delete server";
            this.toolStripBtn_deleteServer.Click += new System.EventHandler(this.toolStripBtn_deleteServer_Click);
            // 
            // toolStripBtn_refreshServer
            // 
            this.toolStripBtn_refreshServer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtn_refreshServer.Image = global::SAMP_Ex.Properties.Resources.reload1;
            this.toolStripBtn_refreshServer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn_refreshServer.Name = "toolStripBtn_refreshServer";
            this.toolStripBtn_refreshServer.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtn_refreshServer.Text = "toolStripBtn_refreshServer";
            this.toolStripBtn_refreshServer.ToolTipText = "Refresh server list";
            this.toolStripBtn_refreshServer.Click += new System.EventHandler(this.toolStripBtn_refreshServer_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.AutoSize = false;
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(10, 25);
            // 
            // toolStripBtn_copyServerInfos
            // 
            this.toolStripBtn_copyServerInfos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtn_copyServerInfos.Image = global::SAMP_Ex.Properties.Resources.copy;
            this.toolStripBtn_copyServerInfos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn_copyServerInfos.Name = "toolStripBtn_copyServerInfos";
            this.toolStripBtn_copyServerInfos.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtn_copyServerInfos.Text = "toolStripBtn_copyServerInfos";
            this.toolStripBtn_copyServerInfos.ToolTipText = "Copy server informations";
            // 
            // toolStripBtn_editServerInfos
            // 
            this.toolStripBtn_editServerInfos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtn_editServerInfos.Image = global::SAMP_Ex.Properties.Resources.edit;
            this.toolStripBtn_editServerInfos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn_editServerInfos.Name = "toolStripBtn_editServerInfos";
            this.toolStripBtn_editServerInfos.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtn_editServerInfos.Text = "toolStripBtn_editServerInfos";
            this.toolStripBtn_editServerInfos.ToolTipText = "Edit server informations";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.AutoSize = false;
            this.toolStripSeparator8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(10, 25);
            // 
            // toolStripBtn_settings
            // 
            this.toolStripBtn_settings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtn_settings.Image = global::SAMP_Ex.Properties.Resources.settings_6;
            this.toolStripBtn_settings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn_settings.Name = "toolStripBtn_settings";
            this.toolStripBtn_settings.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtn_settings.Text = "toolStripBtn_settings";
            this.toolStripBtn_settings.ToolTipText = "Settings";
            this.toolStripBtn_settings.Click += new System.EventHandler(this.menuItm_settings_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.AutoSize = false;
            this.toolStripSeparator7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(10, 25);
            // 
            // toolStripBtn_sampSite
            // 
            this.toolStripBtn_sampSite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtn_sampSite.Image = global::SAMP_Ex.Properties.Resources.home;
            this.toolStripBtn_sampSite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn_sampSite.Name = "toolStripBtn_sampSite";
            this.toolStripBtn_sampSite.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtn_sampSite.Text = "toolStripBtn_sampSite";
            this.toolStripBtn_sampSite.ToolTipText = "SAMP website";
            // 
            // toolStripBtn_about
            // 
            this.toolStripBtn_about.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtn_about.Image = global::SAMP_Ex.Properties.Resources.idea;
            this.toolStripBtn_about.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn_about.Name = "toolStripBtn_about";
            this.toolStripBtn_about.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtn_about.Text = "toolStripBtn_about";
            this.toolStripBtn_about.ToolTipText = "About this launcher";
            this.toolStripBtn_about.Click += new System.EventHandler(this.menuItm_about_Click);
            // 
            // grpBox_serverInfos
            // 
            this.grpBox_serverInfos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBox_serverInfos.Location = new System.Drawing.Point(303, 3);
            this.grpBox_serverInfos.Name = "grpBox_serverInfos";
            this.grpBox_serverInfos.Size = new System.Drawing.Size(978, 106);
            this.grpBox_serverInfos.TabIndex = 7;
            this.grpBox_serverInfos.TabStop = false;
            this.grpBox_serverInfos.Text = "Server info :";
            // 
            // grpBox_filters
            // 
            this.grpBox_filters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBox_filters.Location = new System.Drawing.Point(3, 3);
            this.grpBox_filters.Name = "grpBox_filters";
            this.grpBox_filters.Size = new System.Drawing.Size(294, 106);
            this.grpBox_filters.TabIndex = 0;
            this.grpBox_filters.TabStop = false;
            this.grpBox_filters.Text = "Filters";
            // 
            // tableLayout_filterAndServerInfo
            // 
            this.tableLayout_filterAndServerInfo.ColumnCount = 2;
            this.tableLayout_filterAndServerInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayout_filterAndServerInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayout_filterAndServerInfo.Controls.Add(this.grpBox_filters, 0, 0);
            this.tableLayout_filterAndServerInfo.Controls.Add(this.grpBox_serverInfos, 1, 0);
            this.tableLayout_filterAndServerInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayout_filterAndServerInfo.Location = new System.Drawing.Point(0, 504);
            this.tableLayout_filterAndServerInfo.Name = "tableLayout_filterAndServerInfo";
            this.tableLayout_filterAndServerInfo.RowCount = 1;
            this.tableLayout_filterAndServerInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout_filterAndServerInfo.Size = new System.Drawing.Size(1284, 112);
            this.tableLayout_filterAndServerInfo.TabIndex = 8;
            // 
            // splitContainer_main
            // 
            this.splitContainer_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_main.Location = new System.Drawing.Point(0, 49);
            this.splitContainer_main.Name = "splitContainer_main";
            // 
            // splitContainer_main.Panel1
            // 
            this.splitContainer_main.Panel1.Controls.Add(this.grid_serverList);
            // 
            // splitContainer_main.Panel2
            // 
            this.splitContainer_main.Panel2.Controls.Add(this.splitContainer_serverInfo);
            this.splitContainer_main.Size = new System.Drawing.Size(1284, 455);
            this.splitContainer_main.SplitterDistance = 1017;
            this.splitContainer_main.TabIndex = 10;
            // 
            // grid_serverList
            // 
            this.grid_serverList.AllowUserToAddRows = false;
            this.grid_serverList.AllowUserToDeleteRows = false;
            this.grid_serverList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grid_serverList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_serverList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_serverList.BackgroundColor = System.Drawing.Color.White;
            this.grid_serverList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_serverList.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_serverList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_serverList.Location = new System.Drawing.Point(0, 0);
            this.grid_serverList.LockedImage = global::SAMP_Ex.Properties.Resources.locked_colour;
            this.grid_serverList.LockHeaderImage = global::SAMP_Ex.Properties.Resources.locked;
            this.grid_serverList.MultiSelect = false;
            this.grid_serverList.Name = "grid_serverList";
            this.grid_serverList.ReadOnly = true;
            this.grid_serverList.RowHeadersVisible = false;
            this.grid_serverList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_serverList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grid_serverList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_serverList.ShowEditingIcon = false;
            this.grid_serverList.Size = new System.Drawing.Size(1017, 455);
            this.grid_serverList.TabIndex = 1;
            this.grid_serverList.UnlockedImage = global::SAMP_Ex.Properties.Resources.unlocked_colour;
            this.grid_serverList.UpdateTimerInterval = 0D;
            // 
            // splitContainer_serverInfo
            // 
            this.splitContainer_serverInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_serverInfo.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_serverInfo.Name = "splitContainer_serverInfo";
            this.splitContainer_serverInfo.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_serverInfo.Panel1
            // 
            this.splitContainer_serverInfo.Panel1.Controls.Add(this.grid_playerList);
            // 
            // splitContainer_serverInfo.Panel2
            // 
            this.splitContainer_serverInfo.Panel2.Controls.Add(this.grid_serverInfo);
            this.splitContainer_serverInfo.Size = new System.Drawing.Size(263, 455);
            this.splitContainer_serverInfo.SplitterDistance = 180;
            this.splitContainer_serverInfo.TabIndex = 0;
            // 
            // grid_playerList
            // 
            this.grid_playerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_playerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_playerList.Location = new System.Drawing.Point(0, 0);
            this.grid_playerList.Name = "grid_playerList";
            this.grid_playerList.Size = new System.Drawing.Size(263, 180);
            this.grid_playerList.TabIndex = 0;
            // 
            // grid_serverInfo
            // 
            this.grid_serverInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_serverInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_serverInfo.Location = new System.Drawing.Point(0, 0);
            this.grid_serverInfo.Name = "grid_serverInfo";
            this.grid_serverInfo.Size = new System.Drawing.Size(263, 271);
            this.grid_serverInfo.TabIndex = 0;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Locked";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Hostname";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Players";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Players";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Ping";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Mode";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Language";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // toolStripTxtBox_nickname
            // 
            this.toolStripTxtBox_nickname.Name = "toolStripTxtBox_nickname";
            this.toolStripTxtBox_nickname.Size = new System.Drawing.Size(150, 25);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLbl_name
            // 
            this.toolStripLbl_name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripLbl_name.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLbl_name.Name = "toolStripLbl_name";
            this.toolStripLbl_name.Size = new System.Drawing.Size(61, 22);
            this.toolStripLbl_name.Text = "Nickname";
            // 
            // chckBox_useNicknameDefault
            // 
            this.chckBox_useNicknameDefault.AutoSize = true;
            this.chckBox_useNicknameDefault.BackColor = System.Drawing.SystemColors.Control;
            this.chckBox_useNicknameDefault.Location = new System.Drawing.Point(468, 27);
            this.chckBox_useNicknameDefault.Name = "chckBox_useNicknameDefault";
            this.chckBox_useNicknameDefault.Size = new System.Drawing.Size(102, 17);
            this.chckBox_useNicknameDefault.TabIndex = 11;
            this.chckBox_useNicknameDefault.Text = "Use it by default";
            this.chckBox_useNicknameDefault.UseVisualStyleBackColor = false;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.chckBox_useNicknameDefault);
            this.Controls.Add(this.splitContainer_main);
            this.Controls.Add(this.tableLayout_filterAndServerInfo);
            this.Controls.Add(this.toolStrip_quickBtn);
            this.Controls.Add(this.tabCtrl_serversLists);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_main;
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "mainWindow";
            this.Text = "SAMP Ex";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainWindow_FormClosing);
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.menuStrip_main.ResumeLayout(false);
            this.menuStrip_main.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabCtrl_serversLists.ResumeLayout(false);
            this.toolStrip_quickBtn.ResumeLayout(false);
            this.toolStrip_quickBtn.PerformLayout();
            this.tableLayout_filterAndServerInfo.ResumeLayout(false);
            this.splitContainer_main.Panel1.ResumeLayout(false);
            this.splitContainer_main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_main)).EndInit();
            this.splitContainer_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_serverList)).EndInit();
            this.splitContainer_serverInfo.Panel1.ResumeLayout(false);
            this.splitContainer_serverInfo.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_serverInfo)).EndInit();
            this.splitContainer_serverInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_playerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_serverInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip_main;
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
        private System.Windows.Forms.TabControl tabCtrl_serversLists;
        private System.Windows.Forms.TabPage tab_favorites;
        private System.Windows.Forms.TabPage tab_internet;
        private System.Windows.Forms.TabPage tab_hosted;
        private System.Windows.Forms.ToolStrip toolStrip_quickBtn;
        private System.Windows.Forms.ToolStripButton toolStripBtn_addServer;
        private System.Windows.Forms.ToolStripButton toolStripBtn_connect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripBtn_deleteServer;
        private System.Windows.Forms.ToolStripButton toolStripBtn_refreshServer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripBtn_copyServerInfos;
        private System.Windows.Forms.ToolStripButton toolStripBtn_editServerInfos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton toolStripBtn_settings;
        private System.Windows.Forms.GroupBox grpBox_serverInfos;
        private System.Windows.Forms.GroupBox grpBox_filters;
        private System.Windows.Forms.TableLayoutPanel tableLayout_filterAndServerInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripBtn_sampSite;
        private System.Windows.Forms.ToolStripButton toolStripBtn_about;
        private System.Windows.Forms.SplitContainer splitContainer_main;
        private System.Windows.Forms.SplitContainer splitContainer_serverInfo;
        private System.Windows.Forms.DataGridView grid_playerList;
        private System.Windows.Forms.DataGridView grid_serverInfo;
        private SAMP_Ex.ServerList grid_serverList;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripLabel toolStripLbl_name;
        private System.Windows.Forms.ToolStripTextBox toolStripTxtBox_nickname;
        private System.Windows.Forms.CheckBox chckBox_useNicknameDefault;
    }
}

