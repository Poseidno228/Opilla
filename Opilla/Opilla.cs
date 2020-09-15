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

        protected Opilla(string name, DateTime time, string source, decimal volume, string manufacturer, string bottle, int shelfLife)
        {
            Name = name;
            Time = time;
            Source = source;
            Volume = volume;
            Manufacturer = manufacturer;
            Bottle = bottle;
            ShelfLife = shelfLife;
        }

        protected Opilla(string name, DateTime time, double degree, string source, decimal volume, string style, string manufacturer, string bottle, int shelfLife)
        {
            Name = name;
            Time = time;
            Degree = degree;
            Source = source;
            Volume = volume;
            Style = style;
            Manufacturer = manufacturer;
            Bottle = bottle;
            ShelfLife = shelfLife;
        }

        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime Time { get; set; }
        public double Degree { get; set; }
        public string Source { get; set; }
        public decimal Volume { get; set; }
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
