﻿using System;
using System.Net;
using OpendataLibrary;


namespace opendata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            DataTransportline transportLines = new DataTransportline(5.73119705178461, 45.184446886268645);

            foreach (TransportStop line in transportLines.Data)
            {
                Console.WriteLine("id : " + line.Id);
            }
        }
    }
}
