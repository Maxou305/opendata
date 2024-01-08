using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace OpendataLibrary
{
    public class DataTransportline : ObservableCollection<TransportStop>
    {
        private List<TransportStop> _data;

        public List<TransportStop> Data { get => _data; }

        public DataTransportline(double lon, double lat, int radius)
            : this(new Request(lon, lat, radius))
        {
        }

        internal DataTransportline(IAPI data)
        {
            _data = deserialize(data.GetResponse());
        }
        public List<string> getNames()
        {
            List<string> names = new List<string>();
            foreach (TransportStop transportLine in Data)
            {
                if (!names.Contains(transportLine.Name))
                {
                    names.Add(transportLine.Name);
                }
            }
            return names;
        }
        public List<List<string>> getLines()
        {
            List<List<string>> lines = new List<List<string>>();
            foreach (TransportStop transportLine in Data)
            {
                lines.Add(transportLine.Lines);
            }
            return lines;
        }
        public List<TransportStop> deserialize(string data)
        {
            return JsonConvert.DeserializeObject<List<TransportStop>>(data);
        }
    }
}
