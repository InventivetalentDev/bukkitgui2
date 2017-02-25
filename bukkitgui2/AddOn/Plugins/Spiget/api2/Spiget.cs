using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jayrock.Json;
using Jayrock.Json.Conversion;
using Net.Bertware.Bukkitgui2.Core.Util.Web;

namespace Net.Bertware.Bukkitgui2.AddOn.Plugins.Spiget.api2
{
    class Spiget
    {

        public delegate void PluginsLoadedEventArgs(Dictionary<int, SpigetResource> currentlyLoadedPlugins);

        public static event PluginsLoadedEventArgs NewPluginsLoaded;

        private static Dictionary<int, SpigetCategory> CachedCategories = new Dictionary<int, SpigetCategory>();
    

        private static Dictionary<int, SpigetResource> _currentlyLoadedPlugins;

        private const int DEFAULT_COUNT = 10000;

        private static void RaiseNewPluginsLoaded()
        {
            PluginsLoadedEventArgs handler = NewPluginsLoaded;
            if (handler != null)
            {
                handler.Invoke(CurrentlyLoadedPlugins);
            }
        }

        /// <summary>
        ///     Dictionary with currently loaded plugins, key: namespace, value: plugin
        /// </summary>
        public static Dictionary<int, SpigetResource> CurrentlyLoadedPlugins
        {
            get
            {
                if (_currentlyLoadedPlugins != null) return _currentlyLoadedPlugins;
                _currentlyLoadedPlugins = GetMostDownloadedResources(20);
                return _currentlyLoadedPlugins;
            }
            private set { _currentlyLoadedPlugins = value; }
        }

        public static Dictionary<int, SpigetCategory> GetCategories()
        {
            if (CachedCategories.Count > 0)
            {
                // Categories change rarely, so downloading them once should be enough
                return CachedCategories;
            }

            JsonArray jsonArray = GetJsonArray("https://api.spiget.org/v2/categories?size=100");
            Dictionary<int, SpigetCategory> parsed = new Dictionary<int, SpigetCategory>();

            foreach (JsonObject jsonObject in jsonArray)
            {
                SpigetCategory category = new SpigetCategory(jsonObject);
                parsed.Add(category.Id, category);
            }
            CachedCategories = parsed;
            return CachedCategories;
        }

        public static Dictionary<int, SpigetResource> GetMostDownloadedResources(int amount = DEFAULT_COUNT)
        {
            return ParseResourceList("https://api.spiget.org/v2/resources?sort=-downloads&size=" + amount);
        }

        public static Dictionary<int, SpigetResource> GetResourcesByCategory(string categoryName, int amount = DEFAULT_COUNT)
        {
            return ParseResourceList("https://api.spiget.org/v2/categories/" + categoryName + "/resources?size=" + amount);
        }

        public static Dictionary<int, SpigetResource> SearchResources(string query, int amount = DEFAULT_COUNT)
        {
            if (query.Length == 0)
            {
                return GetMostDownloadedResources(100);// return the default result if nothing is searched
            }
            return ParseResourceList("https://api.spiget.org/v2/search/resources/" + query + "?size=" + amount);
        }

        public static Dictionary<string, SpigetVersion> GetResourceVersions(SpigetResource resource, int amount = DEFAULT_COUNT)
        {
            JsonArray jsonArray = GetJsonArray("https://api.spiget.org/v2/resources/" + resource.Id + "/versions?sort=-name&size=" + amount);
            Dictionary<string, SpigetVersion> parsed = new Dictionary<string, SpigetVersion>();

            foreach (JsonObject jsonObject in jsonArray)
            {
                SpigetVersion version = new SpigetVersion(jsonObject);
                parsed.Add(version.Name +" (#" + version.Id+")", version);
            }

            resource.VersionList = parsed.Values.ToList();

            return parsed;
        }

        private static Dictionary<int, SpigetResource> ParseResourceList(string url)
        {
            JsonArray jsonArray = GetJsonArray(url);
            Dictionary<int, SpigetResource> parsed = new Dictionary<int, SpigetResource>();

            foreach(JsonObject jsonObject in jsonArray)
            {
                SpigetResource resource = new SpigetResource(jsonObject);

                // Extra fields TODO

                parsed.Add(resource.Id, resource);
            }
            CurrentlyLoadedPlugins = parsed;

            RaiseNewPluginsLoaded();

            return CurrentlyLoadedPlugins;
        }

        private static JsonArray GetJsonArray(String url)
        {
            string data = WebUtil.RetrieveString(url);
            return JsonConvert.Import<JsonArray>(data);
        }

        private static JsonObject GetJsonObject(String url)
        {
            string data = WebUtil.RetrieveString(url);
            return JsonConvert.Import<JsonObject>(data);
        }
    }
}
