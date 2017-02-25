// BukgetPluginView.cs in bukkitgui2/bukkitgui2
// Created 2014/08/06
// 
// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
// If a copy of the MPL was not distributed with this file,
// you can obtain one at http://mozilla.org/MPL/2.0/.
// 
// ©Bertware, visit http://bertware.net

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using MetroFramework.Forms;
using Net.Bertware.Bukkitgui2.AddOn.Plugins.Bukget.api3;
using Net.Bertware.Bukkitgui2.AddOn.Plugins.Spiget.api2;
using Net.Bertware.Bukkitgui2.Core;
using Net.Bertware.Bukkitgui2.Core.Util;

namespace Net.Bertware.Bukkitgui2.AddOn.Plugins.Spiget
{
	public partial class SpigetPluginView : MetroForm
	{
		public SpigetPluginView()
		{
			InitializeComponent();
		}

		private SpigetResource _plugin;

		/// <summary>
		///     Location of the installed plugin, if any
		/// </summary>
		private string _currentPluginVersionPath = "";

		public SpigetResource Plugin
		{
			get { return _plugin; }
			set
			{
				_plugin = value;
				LoadPlugin(_plugin);
			}
		}

		public String CurrentPluginVersionPath
		{
			get { return _currentPluginVersionPath; }
			set
			{
				if (!string.IsNullOrEmpty(value)) value = new FileInfo(value).FullName;
				_currentPluginVersionPath = value;
			}
		}

		private void LoadPlugin(SpigetResource plugin)
		{
			string detail = Locale.Tr("Name:") + " " + plugin.Name +
                            Environment.NewLine +
                            Environment.NewLine +
			                Locale.Tr("Contributors(s):") + " " + plugin.Contributors +
			                Environment.NewLine +
			                Environment.NewLine +
			                Locale.Tr("Tag:") + " " + plugin.Tag + Environment.NewLine;
			lblPluginDetail.Text = detail;

            // Download versions
		    api2.Spiget.GetResourceVersions(plugin);
            LoadVersions(plugin.VersionList);
		}

		private void LoadVersions(IEnumerable<SpigetVersion> list)
		{
			slvVersions.Items.Clear();
			foreach (SpigetVersion version in list)
			{
				string[] text =
				{
					version.Name,
					"Dummy Date"
				};

				ListViewItem lvi = new ListViewItem(text) {Tag = version.Id};
				slvVersions.Items.Add(lvi);
			}
		}

		private void BtnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnDownload_Click(object sender, EventArgs e)
		{
			if (slvVersions.SelectedItems.Count < 0) return;

			int versionNumber =(int) slvVersions.SelectedItems[0].Tag;

			foreach (SpigetVersion version in _plugin.VersionList)
			{
			    if (version.Id.Equals(versionNumber))
			    {
			        Process.Start("https://spigotmc.org/resources/" + Plugin.Id + "/download?version=" + version.Id);
			    }
			}
		}
	}
}