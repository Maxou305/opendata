using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace opendata
{
    public class Request : IRequest
    {
        private string _x;
        private string _y;
        private List<TransportLine> _response;

        public Request()
        {
            _response = GetRequestFromAPI("5.7317390", "45.1847290");
        }
        public Request(string x, string y) { _x = x; _y = y; }

        public List<TransportLine> GetResponse()
        {
            return _response;
        }

        public List<TransportLine> GetRequestFromAPI(string x, string y)
        {
            WebRequest request = WebRequest.Create("http://data.mobilites-m.fr/api/linesNear/json?x=" + x + "&y=" + y + "&dist=100&details=true");
            WebResponse response = request.GetResponse();

            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);

            string responseString = reader.ReadToEnd();

            reader.Close();
            stream.Close();
            response.Close();
            return JsonConvert.DeserializeObject<List<TransportLine>>(responseString);
        }














    }
}
