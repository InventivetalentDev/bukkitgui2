using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Jayrock.Json;

namespace Net.Bertware.Bukkitgui2.AddOn.Plugins.Spiget.api2
{
    public class SpigetResource
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public string Tag { get; private set; }

        public string Contributors { get; private set; }

        public string[] TestedVersions { get; private set; }

        public bool External { get; private set; }

        public string Version { get; set; }

        public List<SpigetVersion> VersionList { get; set; }


        public SpigetResource(JsonObject json)
        {
            Id =  Convert.ToInt32(json["id"].ToString());
            Name = (string) json["name"];
            Tag = (string) json["tag"];
            if (json["contributors"] != null)
            {
                Contributors = (string) json["contributors"];
            }
            else
            {
                Contributors = "";
            }

            if (json["external"] != null)
            {
                External = (bool) json["external"];
            }
            else
            {
                External = true;
            }

            if (json["testedVersions"] != null)
            {
                JsonArray testedVersions = (JsonArray) json["testedVersions"];
                object[] objectVersionArray = testedVersions.ToArray();
                TestedVersions = new string[objectVersionArray.Length];
                for (int i = 0; i < objectVersionArray.Length; i++)
                {
                    TestedVersions[i] = (string) objectVersionArray[i];
                }
            }
            else
            {
                TestedVersions = new string[0];
            }
        }

        /// <summary>
        ///     Show a dialog with plugin info & versions
        /// </summary>
        public void ShowVersionDialog(string currentPluginVersionPath = "")
        {
            SpigetPluginView pluginView = new SpigetPluginView
            {
                Plugin = this,
                CurrentPluginVersionPath = currentPluginVersionPath
            };
            pluginView.ShowDialog();
        }

        /// <summary>
        ///     Install the latest plugin version
        /// </summary>
        public void InstallLatestVersion(string targetlocation = "")
        {
            if (External)
            {
                OpenSpigotPage();
            }
            else
            {
                //TODO install
            }
        }

        /// <summary>
        /// Open the SpigotMC page in the default browser
        /// </summary>
        public void OpenSpigotPage()
        {
            Process.Start("https://r.spiget.org/" + Id);
        }
    }
}
