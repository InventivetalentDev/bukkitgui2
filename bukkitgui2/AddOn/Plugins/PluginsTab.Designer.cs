using MetroFramework.Controls;
using Net.Bertware.Bukkitgui2.Core;

namespace Net.Bertware.Bukkitgui2.AddOn.Plugins
{
	partial class PluginsTab
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
			this.tabctrlPlugins = new MetroFramework.Controls.MetroTabControl();
			this.tabInstalled = new System.Windows.Forms.TabPage();
			this.installedCtrl = new Net.Bertware.Bukkitgui2.AddOn.Plugins.InstalledPlugins.InstalledPluginsControl();
			this.tabSpiget = new System.Windows.Forms.TabPage();
			this.spigetCtrl = new Net.Bertware.Bukkitgui2.AddOn.Plugins.Spiget.SpigetPluginsControl();
			this.tabctrlPlugins.SuspendLayout();
			this.tabInstalled.SuspendLayout();
			this.tabSpiget.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabctrlPlugins
			// 
			this.tabctrlPlugins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabctrlPlugins.Controls.Add(this.tabInstalled);
			this.tabctrlPlugins.Controls.Add(this.tabSpiget);
			this.tabctrlPlugins.Location = new System.Drawing.Point(0, 0);
			this.tabctrlPlugins.Name = "tabctrlPlugins";
			this.tabctrlPlugins.SelectedIndex = 0;
			this.tabctrlPlugins.Size = new System.Drawing.Size(800, 500);
			this.tabctrlPlugins.TabIndex = 0;
			this.tabctrlPlugins.UseSelectable = true;
			// 
			// tabInstalled
			// 
			this.tabInstalled.Controls.Add(this.installedCtrl);
			this.tabInstalled.Location = new System.Drawing.Point(4, 38);
			this.tabInstalled.Name = "tabInstalled";
			this.tabInstalled.Padding = new System.Windows.Forms.Padding(3);
			this.tabInstalled.Size = new System.Drawing.Size(792, 458);
			this.tabInstalled.TabIndex = 0;
			this.tabInstalled.Text = Locale.Tr("Installed plugins");
			this.tabInstalled.UseVisualStyleBackColor = true;
			// 
			// installedCtrl
			// 
			this.installedCtrl.BackColor = System.Drawing.Color.White;
			this.installedCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.installedCtrl.Location = new System.Drawing.Point(3, 3);
			this.installedCtrl.Name = "installedCtrl";
			this.installedCtrl.Size = new System.Drawing.Size(786, 452);
			this.installedCtrl.TabIndex = 0;
			this.installedCtrl.UseSelectable = true;
			// 
			// tabSpiget
			// 
			this.tabSpiget.Controls.Add(this.spigetCtrl);
			this.tabSpiget.Location = new System.Drawing.Point(4, 38);
			this.tabSpiget.Name = "tabSpiget";
			this.tabSpiget.Padding = new System.Windows.Forms.Padding(3);
			this.tabSpiget.Size = new System.Drawing.Size(792, 458);
			this.tabSpiget.TabIndex = 1;
			this.tabSpiget.Text = Locale.Tr("Available plugins");
			this.tabSpiget.UseVisualStyleBackColor = true;
			// 
			// spigetCtrl
			// 
			this.spigetCtrl.BackColor = System.Drawing.Color.White;
			this.spigetCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.spigetCtrl.Location = new System.Drawing.Point(3, 3);
			this.spigetCtrl.Name = "spigetCtrl";
			this.spigetCtrl.Size = new System.Drawing.Size(786, 452);
			this.spigetCtrl.TabIndex = 0;
			this.spigetCtrl.UseSelectable = true;
			// 
			// PluginsTab
			// 
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.tabctrlPlugins);
			this.Name = "PluginsTab";
			this.Size = new System.Drawing.Size(800, 500);
			this.tabctrlPlugins.ResumeLayout(false);
			this.tabInstalled.ResumeLayout(false);
			this.tabSpiget.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private MetroTabControl tabctrlPlugins;
		private System.Windows.Forms.TabPage tabInstalled;
		private InstalledPlugins.InstalledPluginsControl installedCtrl;
		private System.Windows.Forms.TabPage tabSpiget;
		private Spiget.SpigetPluginsControl spigetCtrl;
	}
}
