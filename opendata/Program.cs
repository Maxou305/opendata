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

            DataTransportline transportLines = new DataTransportline(new Request("5.73119705178461", "45.184446886268645"));
            foreach (TransportLine line in transportLines.Data)
            {
                Console.WriteLine("id : " + line.id);
            }            
        }
    }
}
