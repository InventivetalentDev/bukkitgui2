﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jayrock.Json;

namespace Net.Bertware.Bukkitgui2.AddOn.Plugins.Spiget.api2
{
    public class SpigetVersion
    {

        public int Id { get; private set; }

        public string Name { get; private set; }

        public long ReleasedDate { get; private set; }

        public SpigetVersion(JsonObject json)
        {
            Id = Convert.ToInt32(json["id"].ToString());
            Name = (string) json["name"];
            ReleasedDate = Convert.ToInt64(json["releaseDate"].ToString());
        }



    }
}
