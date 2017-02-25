using System.Windows.Forms;
using MetroFramework.Controls;
using Net.Bertware.Bukkitgui2.Core;

namespace Net.Bertware.Bukkitgui2.AddOn.Plugins.Spiget
{
    partial class SpigetPluginsControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.slvPlugins = new Net.Bertware.Bukkitgui2.Controls.SortableListView.SortableListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVersion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGameVersion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnInstall = new MetroFramework.Controls.MetroButton();
            this.btnInfo = new MetroFramework.Controls.MetroButton();
            this.lblBrowse = new MetroFramework.Controls.MetroLabel();
            this.cbCategories = new MetroFramework.Controls.MetroComboBox();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.lblSearch = new MetroFramework.Controls.MetroLabel();
            this.txtSearchText = new MetroFramework.Controls.MetroTextBox();
            this.metroStyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.CtxPlugins = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.CBtnMoreInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.CBtnInstallLatest = new System.Windows.Forms.ToolStripMenuItem();
            this.CBtnViewOnline = new System.Windows.Forms.ToolStripMenuItem();
            this.CBtnRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxPlugins.SuspendLayout();
            this.SuspendLayout();
            // 
            // slvPlugins
            // 
            this.slvPlugins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroStyleExtender.SetApplyMetroTheme(this.slvPlugins, true);
            this.slvPlugins.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colDescription,
            this.colVersion,
            this.colGameVersion});
            this.slvPlugins.FullRowSelect = true;
            this.slvPlugins.Location = new System.Drawing.Point(3, 40);
            this.slvPlugins.Name = "slvPlugins";
            this.slvPlugins.Size = new System.Drawing.Size(774, 368);
            this.slvPlugins.TabIndex = 0;
            this.slvPlugins.UseCompatibleStateImageBehavior = false;
            this.slvPlugins.View = System.Windows.Forms.View.Details;
            this.slvPlugins.SelectedIndexChanged += new System.EventHandler(this.slvPlugins_SelectedIndexChanged);
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 120;
            // 
            // colDescription
            // 
            this.colDescription.Text = "Tag";
            this.colDescription.Width = 360;
            // 
            // colVersion
            // 
            this.colVersion.Text = "Version";
            this.colVersion.Width = 120;
            // 
            // colGameVersion
            // 
            this.colGameVersion.Text = "Tested Versions";
            this.colGameVersion.Width = 120;
            // 
            // btnInstall
            // 
            this.btnInstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInstall.Enabled = false;
            this.btnInstall.Location = new System.Drawing.Point(702, 414);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(75, 23);
            this.btnInstall.TabIndex = 1;
            this.btnInstall.Text = "Install";
            this.btnInstall.UseSelectable = true;
            this.btnInstall.Click += new System.EventHandler(this.InstallSelectedPlugins);
            // 
            // btnInfo
            // 
            this.btnInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfo.Enabled = false;
            this.btnInfo.Location = new System.Drawing.Point(621, 414);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 23);
            this.btnInfo.TabIndex = 3;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseSelectable = true;
            this.btnInfo.Click += new System.EventHandler(this.ShowPluginInfo);
            // 
            // lblBrowse
            // 
            this.lblBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBrowse.Location = new System.Drawing.Point(404, 6);
            this.lblBrowse.Name = "lblBrowse";
            this.lblBrowse.Size = new System.Drawing.Size(130, 21);
            this.lblBrowse.TabIndex = 17;
            this.lblBrowse.Text = "Browse category:";
            // 
            // cbCategories
            // 
            this.cbCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.ItemHeight = 23;
            this.cbCategories.Location = new System.Drawing.Point(540, 3);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(237, 29);
            this.cbCategories.TabIndex = 16;
            this.cbCategories.UseSelectable = true;
            this.cbCategories.SelectedIndexChanged += new System.EventHandler(this.cbCategories_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(307, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 24);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.Location = new System.Drawing.Point(3, 6);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(120, 21);
            this.lblSearch.TabIndex = 14;
            this.lblSearch.Text = "Search plugins:";
            // 
            // txtSearchText
            // 
            this.txtSearchText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchText.Lines = new string[0];
            this.txtSearchText.Location = new System.Drawing.Point(129, 6);
            this.txtSearchText.MaxLength = 32767;
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.PasswordChar = '\0';
            this.txtSearchText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchText.SelectedText = "";
            this.txtSearchText.Size = new System.Drawing.Size(172, 20);
            this.txtSearchText.TabIndex = 13;
            this.txtSearchText.UseSelectable = true;
            this.txtSearchText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchText_KeyDown);
            // 
            // CtxPlugins
            // 
            this.CtxPlugins.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CBtnMoreInfo,
            this.CBtnInstallLatest,
            this.CBtnViewOnline,
            this.CBtnRefresh});
            this.CtxPlugins.Name = "CtxPlugins";
            this.CtxPlugins.Size = new System.Drawing.Size(178, 92);
            this.CtxPlugins.Opening += new System.ComponentModel.CancelEventHandler(this.CtxPlugins_Opening);
            // 
            // CBtnMoreInfo
            // 
            this.CBtnMoreInfo.Name = "CBtnMoreInfo";
            this.CBtnMoreInfo.Size = new System.Drawing.Size(177, 22);
            this.CBtnMoreInfo.Text = "More info";
            this.CBtnMoreInfo.Click += new System.EventHandler(this.ShowPluginInfo);
            // 
            // CBtnInstallLatest
            // 
            this.CBtnInstallLatest.Name = "CBtnInstallLatest";
            this.CBtnInstallLatest.Size = new System.Drawing.Size(177, 22);
            this.CBtnInstallLatest.Text = "Install latest version";
            this.CBtnInstallLatest.Click += new System.EventHandler(this.InstallSelectedPlugins);
            // 
            // CBtnViewOnline
            // 
            this.CBtnViewOnline.Name = "CBtnViewOnline";
            this.CBtnViewOnline.Size = new System.Drawing.Size(177, 22);
            this.CBtnViewOnline.Text = "View online";
            this.CBtnViewOnline.Click += new System.EventHandler(this.CBtnViewOnline_Click);
            // 
            // CBtnRefresh
            // 
            this.CBtnRefresh.Name = "CBtnRefresh";
            this.CBtnRefresh.Size = new System.Drawing.Size(177, 22);
            this.CBtnRefresh.Text = "Refresh";
            this.CBtnRefresh.Click += new System.EventHandler(this.CBtnRefresh_Click);
            // 
            // SpigetPluginsControl
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ContextMenuStrip = this.CtxPlugins;
            this.Controls.Add(this.lblBrowse);
            this.Controls.Add(this.cbCategories);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearchText);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnInstall);
            this.Controls.Add(this.slvPlugins);
            this.Name = "SpigetPluginsControl";
            this.Size = new System.Drawing.Size(780, 440);
            this.VisibleChanged += new System.EventHandler(this.SpigetPluginsControl_VisibleChanged);
            this.CtxPlugins.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.SortableListView.SortableListView slvPlugins;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colDescription;
        private System.Windows.Forms.ColumnHeader colVersion;
        private System.Windows.Forms.ColumnHeader colGameVersion;
        private MetroButton btnInstall;
        private MetroButton btnInfo;
        private MetroLabel lblBrowse;
        private MetroComboBox cbCategories;
        private MetroButton btnSearch;
        private MetroLabel lblSearch;
        private MetroTextBox txtSearchText;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender;
        private MetroContextMenu CtxPlugins;
        private ToolStripMenuItem CBtnMoreInfo;
        private ToolStripMenuItem CBtnInstallLatest;
        private ToolStripMenuItem CBtnViewOnline;
        private ToolStripMenuItem CBtnRefresh;
    }
}
