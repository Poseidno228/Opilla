using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Opilla.WineStyle
{
    abstract  class WineParser : Opilla, IParserOneLiter
    {
        public WineParser() { }
        public WineParser(string name, DateTime time, string source, decimal volume, string manufacturer, string bottle, int shelfLife) : base(name, time, source, volume, manufacturer, bottle, shelfLife)
        {

        }
        public virtual double GetDegree()
        {
            Regex regex = new Regex(@"\d");
            Regex regex2 = new Regex(@"\d.\d{1}");
            string s = GetHtmlDocument(new Uri("https://winestyle.com.ua/beer/opillia/")).
                DocumentNode.
                SelectSingleNode($"//html/body/div[@class='body-wrapper']/div[@class='main-wrapper']/div[@class='container container-fluid']/div[@class='main-content main-content-filters']/div[@class='center-content']/div[@class='items-container ']/form[@data-prodid='{this.formID}']/div[@class='item-block-content']/div[@class='info-container']/ul/li[7]")?.
                InnerText;
            return Convert.
                ToDouble((regex.Match(s) == null ? regex2.Match(s) : regex.Match(s)).
                ToString().
                Replace(".", ","));
        }
        protected int formID = 0;
        public virtual double GetPrice()
        {
            return Convert.ToDouble(GetHtmlDocument(new Uri("https://winestyle.com.ua/beer/opillia/")).
                DocumentNode.
                SelectSingleNode($"//html/body/div[@class='body-wrapper']/div[@class='main-wrapper']/div[@class='container container-fluid']/div[@class='main-content main-content-filters']/div[@class='center-content']/div[@class='items-container ']/form[@data-prodid='{this.formID}']/div[@class='item-block-content']/div[@class='right-block']/div[@class='left-tablet']/div[@class='price-container ']/div[@class='price ']").
                InnerText.
                Replace(" грн", "")
                .Replace(".", ","));
        }

        public virtual string GetStyle()
        {
            string s = GetHtmlDocument(new Uri("https://winestyle.com.ua/beer/opillia/")).
                 DocumentNode.
                 SelectSingleNode($"//html/body/div[@class='body-wrapper']/div[@class='main-wrapper']/div[@class='container container-fluid']/div[@class='main-content main-content-filters']/div[@class='center-content']/div[@class='items-container ']/form[@data-prodid='{this.formID}']/div[@class='item-block-content']/div[@class='info-container']/ul/li[5]")?.
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

        public virtual double GetPriceForLiter()
        {
            return Convert.
                ToDouble(GetHtmlDocument(new Uri("https://winestyle.com.ua/beer/opillia/")).
                DocumentNode.
                SelectSingleNode($"//html/body/div[@class='body-wrapper']/div[@class='main-wrapper']/div[@class='container container-fluid']/div[@class='main-content main-content-filters']/div[@class='center-content']/div[@class='items-container ']/form[@data-prodid='{this.formID}']/div/div[@class='right-block']/div[@class='left-tablet']/div[@class='price-container ']/div[2]")?.
                InnerText.
                Replace(" грн", "").
                Replace(".", ","));
        }
    }
}
