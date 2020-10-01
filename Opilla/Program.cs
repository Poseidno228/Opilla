using System;
using System.Net;
using System.IO;
using Opilla.WineStyle;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;

namespace Opilla
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
            Console.WriteLine("Start4");
            while (true)
            {
                Console.WriteLine(2341234);
               // UPDSent.Send();
                Console.WriteLine(DateTime.Now.Subtract(date).TotalMilliseconds);
                Thread.Sleep(60 * 60 * 1000 * 12);
            }
        }
        public static string GetHtml(Uri uri)
        {

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}
