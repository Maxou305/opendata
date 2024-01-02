using opendata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpendataLibrary;

namespace OpendataTests
{
    public class FakeRequest : IAPI
    {
        private List<TransportLine> _response;

        public FakeRequest() {
            _response = new List<TransportLine>();
        }

        public List<TransportLine> GetResponse()
        {
            _response.Add(new TransportLine("Test0", "Toto", 45.548564, 5.545648, new List<string>()));
            return _response;
        }
    }
}
