using Newtonsoft.Json;
using System.Collections.Generic;

namespace OpendataLibrary
{
    public class TransportLine
    {
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("lon")]
        public double lon { get; set; }

        [JsonProperty("lat")]
        public double lat { get; set; }

        [JsonProperty("lines")]
        public List<string> lines { get; set; }

        public TransportLine(string id, string name, double lon, double lat, List<string> lines)
        {
            this.id = id;
            this.name = name;
            this.lon = lon;
            this.lat = lat;
            this.lines = lines;
        }
    }
}