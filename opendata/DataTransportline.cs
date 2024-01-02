using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opendata
{
    public class DataTransportline
    {
        private List<TransportLine> _data;

        public List<TransportLine> Data { get => _data; }

        public DataTransportline(IAPI data)
        {
            _data = data.GetResponse();
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
    }
}
