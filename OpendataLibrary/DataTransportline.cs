using Newtonsoft.Json;
using System.Collections.Generic;

namespace OpendataLibrary
{
    public class DataTransportline
    {
        private List<TransportLine> _data;

        public List<TransportLine> Data { get => _data; }

        public DataTransportline(double x, double y)
            : this(new Request(x, y))
        {            
        }

        internal DataTransportline(IAPI data)
        {
            _data = deserialize(data.GetResponse());
        }
        public List<string> getNames()
        {
            List<string> names = new List<string>();
            foreach (TransportLine transportLine in Data)
            {
                names.Add(transportLine.name);
            }
            return names;
        }
        public List<List<string>> getLines()
        {
            List<List<string>> lines = new List<List<string>>();
            foreach (TransportLine transportLine in Data)
            {
                lines.Add(transportLine.lines);
            }
            return lines;
        }
        public List<TransportLine> deserialize(string data) {
            return JsonConvert.DeserializeObject<List<TransportLine>>(data);
        }
    }
}
