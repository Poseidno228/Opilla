using System;
using System.Net;
using System.IO;
using Opilla.WineStyle;
using System.Collections.Generic;
using System.Text.Json;
namespace Opilla
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
            //List<Opilla> list = new List<Opilla>()
            //{
            //    new Novus<KorifeiWineStyle>("Опілля Корифей",0.5, "Скляна пляшка"),
            //    new Novus<Jugulevskoe>("Опілля Жигулівське",0.5, "Скляна пляшка"),
            //    new Novus<Classic>("Опілля Класичне",0.5, "Скляна пляшка"),
            //    new Classic("Опілля Класичне",0.5, "Скляна пляшка"),
            //    new Classic("Опілля Класичне", 1, "Пластикова пляшка"),
            //    new Jugulevskoe("Опілля Жигулівське", 0.5, "Скляна пляшка"),
            //    new Jugulevskoe("Опілля Жигулівське", 1, "Пластикова пляшка"),
            //    new KorifeiWineStyle("Опілля Корифей", 0.5, "Скляна пляшка"),
            //    new KorifeiWineStyle("Опілля Корифей", 1, "Пластикова пляшка")
            //};
            //foreach (var item in list)
            //{
            //    Console.WriteLine($"{item.Name}  -- {item.Price} -- {item.Style} -- {item.ShelfLife} -- {item.Source} -- {item.Degree}");
            //    Console.WriteLine();
            //}
           // Console.WriteLine(UPDSent.Serialize(list));
            UPDSent.Send();
            Console.WriteLine(DateTime.Now.Subtract(date).TotalMilliseconds);
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
