using System.Globalization;
using System.IO;
using System.Net;

namespace OpendataLibrary
{
    public class Request : IAPI
    {
        private string _response;
        
        public Request(double lon, double lat, int radius)
        {
            _response = GetRequestFromMetroAPI(lon, lat, radius);
        }

        public string GetResponse()
        {
            return _response;
        }

        private string GetRequestFromMetroAPI(double lon, double lat, int radius)
        {
            string url = string.Format(CultureInfo.InvariantCulture, "http://data.mobilites-m.fr/api/linesNear/json?x={0}&y={1}&dist={2}&details=true", lon, lat, radius);
            return DoRequest(url);
        }

        private string DoRequest(string url)
        {
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();

            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);

            string responseString = reader.ReadToEnd();

            reader.Close();
            stream.Close();
            response.Close();

            return responseString;
        }
    }
}
