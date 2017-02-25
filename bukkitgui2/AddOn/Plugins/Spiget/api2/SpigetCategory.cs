using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jayrock.Json;
using Jayrock.Json.Conversion;

namespace Net.Bertware.Bukkitgui2.AddOn.Plugins.Spiget.api2
{
    class SpigetCategory
    {

        public int Id { get; private set; }
        
        public string Name { get; set; }


        public SpigetCategory(JsonObject json)
        {
            Id = Convert.ToInt32(json["id"].ToString());
            Name = (string) json["name"];
        }
    }
}
