using Newtonsoft.Json;
using System.Collections.Generic;

namespace OpendataLibrary
{
    public class TransportStop
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
    }
}