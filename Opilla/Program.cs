using System;
using System.Net;
using System.IO;
using HtmlAgilityPack;
using System.Linq;
using Opilla.WineStyle;
using System.Text.RegularExpressions;
//https://morepiva.ua/kyiv/pivo/vkusnoe-pivo/svetloe/pivo-opillya-korifey.html
//https://novus.zakaz.ua/uk/products/04820004580188/beer-opillya-500ml-ukraine/
////html/body/div[@class='body-wrapper']/div[@class='main-wrapper']/div[@class='container container-fluid']/div[@class='main-content main-content-filters']/div[@class='center-content']/div[@class='items-container ']/form[@data-prodid='81379']/div

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
