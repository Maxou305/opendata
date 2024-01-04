using Newtonsoft.Json;
using System.Collections.Generic;

namespace OpendataLibrary
{
    public class TransportLine
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("lon")]
        public double Lon { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lines")]
        public List<string> Lines { get; set; }

        public TransportLine(string id, string name, double lon, double lat, List<string> lines)
        {
            this.Id = id;
            this.Name = name;
            this.Lon = lon;
            this.Lat = lat;
            this.Lines = lines;
        }
    }
}