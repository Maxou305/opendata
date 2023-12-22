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

            Console.WriteLine(new Request().GetResponse()[0].name);

            //foreach (TransportLine line in json)
            //{
            //    Console.WriteLine("id : "+line.id);
            //}




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


        }
    }
}
