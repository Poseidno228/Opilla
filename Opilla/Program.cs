using System;
using System.Net;
using System.IO;
using Opilla.WineStyle;
//https://morepiva.ua/kyiv/pivo/vkusnoe-pivo/svetloe/pivo-opillya-korifey.html
//https://novus.zakaz.ua/uk/products/04820004580188/beer-opillya-500ml-ukraine/
namespace Opilla
{
    class Program
    {
        static void Main(string[] args)
        {
             

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
