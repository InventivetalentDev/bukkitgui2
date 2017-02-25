// BukgetPluginsControl.cs in bukkitgui2/bukkitgui2
// Created 2014/06/18
// Last edited at 2015/09/01 10:16
// ©Bertware, visit http://bertware.net

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MetroFramework.Controls;
using Microsoft.VisualBasic.Logging;
using Net.Bertware.Bukkitgui2.AddOn.Plugins.Bukget.api3;
using Net.Bertware.Bukkitgui2.AddOn.Plugins.Spiget.api2;

namespace Net.Bertware.Bukkitgui2.AddOn.Plugins.Spiget
{
	public partial class SpigetPluginsControl : MetroUserControl
	{
		private Dictionary<int, SpigetResource> _plugins;

		public SpigetPluginsControl()
		{
			InitializeComponent();
		    Dictionary<int, SpigetCategory> categories = api2.Spiget.GetCategories();
			foreach (KeyValuePair <int, SpigetCategory> category in categories)
			{
				cbCategories.Items.Add(category.Value.Id.ToString() + " - "+ category.Value.Name);
                System.Console.WriteLine(category.Value.Name);
			}
			api2.Spiget.NewPluginsLoaded += UpdatePluginsDictionary;
		}

		private void UpdatePluginsDictionary(Dictionary<int, SpigetResource> currentlyLoadedPlugins)
		{
			_plugins = currentlyLoadedPlugins;
			ShowPlugins();
            System.Console.WriteLine(_plugins.ToString());
		}

		private void SpigetPluginsControl_VisibleChanged(object sender, EventArgs e)
		{
			if (!Visible || (_plugins != null && _plugins.Count >= 1)) return;
			api2.Spiget.GetMostDownloadedResources(100);
		}

		private void ShowPlugins()
		{
			slvPlugins.Items.Clear();
			foreach (SpigetResource p in _plugins.Values)
			{
				string[] contents = {p.Name, p.Tag, p.Version, String.Join(", ", p.TestedVersions) };
				ListViewItem i = new ListViewItem(contents) { Tag = p.Id };
				slvPlugins.Items.Add(i);
			}
		}


		private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
		{
			api2.Spiget.GetResourcesByCategory(cbCategories.SelectedItem.ToString());
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			api2.Spiget.SearchResources(txtSearchText.Text, 50);
		}

		private void ShowPluginInfo(object sender, EventArgs e)
		{
			if (slvPlugins.SelectedItems.Count < 0) return;
			foreach (ListViewItem item in slvPlugins.SelectedItems)
			{
				int main =(int) item.Tag;
				api2.Spiget.CurrentlyLoadedPlugins[main].ShowVersionDialog();
			}
		}

		/// <summary>
		///     Install the selected plugins on button press
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="eventArgs"></param>
		private void InstallSelectedPlugins(object sender, EventArgs eventArgs)
		{
			if (slvPlugins.SelectedItems.Count < 0) return;
			foreach (ListViewItem item in slvPlugins.SelectedItems)
			{
				int main = (int) item.Tag;
				api2.Spiget.CurrentlyLoadedPlugins[main].InstallLatestVersion();
			}
		}

		private void slvPlugins_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool selected = slvPlugins.SelectedItems.Count > 0;
		    bool canInstall = true;
		    foreach (ListViewItem item in slvPlugins.SelectedItems)
		    {
                int main = (int) item.Tag;
		        if (api2.Spiget.CurrentlyLoadedPlugins[main].External)
		        {
		            canInstall = false;
		        }

            }

		    btnInfo.Enabled = selected;

		    btnInstall.Text = canInstall ? "Install" : "Download";
			btnInstall.Enabled = selected;
		}

		private void txtSearchText_KeyDown(object sender, KeyEventArgs e)
		{
			// TODO: prevent beep noise on enter
			if (e.KeyCode != Keys.Enter) return;
			e.Handled = true;
			btnSearch_Click(sender, e);
		}

		private void CBtnRefresh_Click(object sender, EventArgs e)
		{
			// Event handlers will do the rest
			// Just load most popular, there's search etc for other stuff
			api2.Spiget.GetMostDownloadedResources(30);
		}

		private void CBtnViewOnline_Click(object sender, EventArgs e)
		{
			if (slvPlugins.SelectedItems.Count < 0) return;
			foreach (ListViewItem item in slvPlugins.SelectedItems)
			{
				int main = (int) item.Tag;
				api2.Spiget.CurrentlyLoadedPlugins[main].OpenSpigotPage();
			}
		}

		private void CtxPlugins_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			CtxPlugins.Enabled = (slvPlugins.SelectedItems.Count > 0);
		}
	}
}