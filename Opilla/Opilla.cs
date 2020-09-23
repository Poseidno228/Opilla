using System;
using System.Collections.Generic;
using System.Text;
using HtmlAgilityPack;

namespace Opilla
{
    abstract class Opilla
    {
        protected Opilla()
        {
        }

        protected Opilla(string name, double volume, string bottle)
        {
            Name = name;
            Time = DateTime.Now;
            Volume = volume;
            Manufacturer = "Опілля, Україна";
            Bottle = bottle;
            ShelfLife = 30;
        }

        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime Time { get; set; }
        public double Degree { get; set; }
        public string Source { get; set; }
        public double Volume { get; set; }
        public string Style { get; set; }
        public string Manufacturer { get; set; }
        public string Bottle { get; set; }
        public int ShelfLife { get; set; }
        protected HtmlDocument GetHtmlDocument(Uri url)
        {
            string html = Program.GetHtml(url);
            HtmlDocument htmldoc = new HtmlDocument();
            htmldoc.LoadHtml(html);
            return htmldoc;
        }
    }
}
