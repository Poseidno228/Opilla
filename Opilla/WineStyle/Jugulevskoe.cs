using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Opilla.WineStyle
{
    class Jugulevskoe : Opilla, IParserOneLiter
    {
        public Jugulevskoe(string name, DateTime time, string source, int volume, string manufacturer, string bottle, int shelfLife) : base(name, time, source, volume, manufacturer, bottle, shelfLife)
        {
            if (volume == 0.5)
                base.Price = GetPrice();
            else
                base.Price = GetPriceForLiter();
            base.Degree = this.GetDegree();
            base.Style = this.GetStyle();
        }
        public double GetDegree()
        {
            string s = base.
                GetHtmlDocument(new Uri("https://winestyle.com.ua/beer/opillia/")).
                DocumentNode.
                SelectNodes("")
                .Count.
                ToString();
            Console.WriteLine(s);
            return 0;
        }

        public double GetPrice()
        {
            return 0;
        }

        public double GetPriceForLiter()
        {
            return 0;
        }

        public string GetStyle()
        {
            return "";
        }
    }
}
