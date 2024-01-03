using System.Globalization;
using System.IO;
using System.Net;

namespace OpendataLibrary
{
    public class Request : IAPI
    {
        private string _response;
        
        public Request(double x, double y)
        {
            _response = GetRequestFromAPI(x, y);
        }

        public string GetResponse()
        {
            return _response;
        }

        private string GetRequestFromAPI(double x, double y)
        {
            string url = string.Format(CultureInfo.InvariantCulture, "http://data.mobilites-m.fr/api/linesNear/json?x={0}&y={1}&dist={2}&details=true", x, y, 500);
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
