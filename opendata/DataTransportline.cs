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
        public DataTransportline(IAPI data)
        {
            _data = data.GetResponse();
        }
        public List<string> getNames()
        {
            List<string> names = new List<string>();
            foreach (TransportLine transportLine in _data)
            {
                names.Add(transportLine.name);
            }
            return names;
        }
        public List<TransportLine> getData() { return _data; }

    }
}
