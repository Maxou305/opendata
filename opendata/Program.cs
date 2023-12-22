using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace opendata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            WebRequest request = WebRequest.Create("http://data.mobilites-m.fr/api/linesNear/json?x=5.7317390&y=45.1847290&dist=100&details=true");
            WebResponse response = request.GetResponse();

            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            
            string responseString = reader.ReadToEnd();
            List<TransportLine> json = JsonConvert.DeserializeObject<List<TransportLine>>(responseString);

            foreach (TransportLine line in json)
            {
                Console.WriteLine("id : "+line.id);
            }




            //Char[] read = new Char[256];

            ////Read 256 charcters at a time.    
            //int count = reader.Read(read, 0, 256);
            //while (count > 0)
            //{
            //    // Dump the 256 characters on a string and display the string onto the console.
            //    String str = new String(read, 0, count);
            //    Console.Write(str);
            //    count = reader.Read(read, 0, 256);
            //}
            Console.WriteLine();

            reader.Close();
            stream.Close();
            response.Close();
        }
    }
}
