using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Opilla.WineStyle
{
    class Classic : WineParser, IParserOneLiter
    {
        public Classic() { }
        public Classic(string name, DateTime time, string source, int volume, string manufacturer, string bottle, int shelfLife) : base(name, time, source, volume, manufacturer, bottle, shelfLife)
        {
            if (volume == 0.5)
                base.Price = GetPrice();
            else
                base.Price = GetPriceForLiter();
            base.Style = this.GetStyle();
            base.Degree = this.GetDegree();
        }
        public override double GetDegree()
        {
            Regex regex = new Regex(@"\d.\d{1}");
            string s = GetHtmlDocument(new Uri("https://winestyle.com.ua/beer/opillia/")).
                DocumentNode.
                SelectSingleNode("//html/body/div[@class='body-wrapper']/div[@class='main-wrapper']/div[@class='container container-fluid']/div[@class='main-content main-content-filters']/div[@class='center-content']/div[@class='items-container ']/form[@data-prodid='81379']/div[@class='item-block-content']/div[@class='info-container']/ul/li[7]")?.
                InnerText;
            return Convert.
                ToDouble(regex.Match(s).
                ToString().
                Replace(".", ","));
        }

        public override double GetPrice()
        {
            base.formID = 81379;
            return base.GetPrice();
        }

        public override double GetPriceForLiter()
        {
            return Convert.ToDouble(base.
                GetHtmlDocument(new Uri("https://winestyle.com.ua/beer/opillia/")).
                DocumentNode.
                SelectSingleNode("//html/body/div[@class='body-wrapper']/div[@class='main-wrapper']/div[@class='container container-fluid']/div[@class='main-content main-content-filters']/div[@class='center-content']/div[@class='items-container ']/form[@data-prodid='81381']/div[1]/div[2]/div[1]/div[1]/div[2]")
                .InnerText.Replace(" грн", ""));
        }

        public override string GetStyle()
        {
            string s = GetHtmlDocument(new Uri("https://winestyle.com.ua/beer/opillia/")).
                DocumentNode.
                SelectSingleNode($"//html/body/div[@class='body-wrapper']/div[@class='main-wrapper']/div[@class='container container-fluid']/div[@class='main-content main-content-filters']/div[@class='center-content']/div[@class='items-container ']/form[@data-prodid='81379']/div[@class='item-block-content']/div[@class='info-container']/ul/li[5]")?.
                InnerText;
            string rez = "";
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (char.IsUpper(s[i + 1]))
                {
                    rez += s[i];
                    continue;
                }
                if (!char.IsWhiteSpace(s[i]))
                {
                    rez += s[i];
                }
            }
            return rez.Trim();
        }
    }
}
