using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace opendata
{
    public class Request : IAPI
    {
        private List<TransportLine> _response;

        public Request()
        {
            _response = GetRequestFromAPI(5.7317390, 45.1847290);
        }
        public Request(double x, double y)
        {
            _response = GetRequestFromAPI(x, y);
        }

        public List<TransportLine> GetResponse()
        {
            return _response;
        }

        public List<TransportLine> GetRequestFromAPI(double x, double y)
        {
            string url = string.Format(CultureInfo.InvariantCulture, "http://data.mobilites-m.fr/api/linesNear/json?x={0}&y={1}&dist={2}&details=true", x, y, 500);
            WebRequest request = WebRequest.Create(url);
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
