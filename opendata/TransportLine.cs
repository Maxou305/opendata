using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace opendata
{
    public class TransportLine

    
    {
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("lon")]
        public string lon { get; set; }

        [JsonProperty("lat")]
        public string lat { get; set; }

        [JsonProperty("lines")]
        public List<string> lines { get; set; }
    
    public TransportLine() { }
    }
}