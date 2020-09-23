using Opilla.WineStyle;
using System;
using System.Threading.Tasks;
using System.Threading;

namespace Opilla
{
    class Novus<T> : Opilla, IParser
        where T:WineParser
    {
        public Novus()
        {
        }
        public Novus(string name, double volume, string bottle) : base(name, volume, bottle)
        {
            Source = "Novus";
            base.Price = this.GetPrice();
            base.Style = this.GetStyle();
            base.Degree = this.GetDegree();
        }
        //https://novus.zakaz.ua/uk/products/04820004580188/beer-opillya-500ml-ukraine/
        private T GetBeer()

        {
            if (Name == "Опілля Корифей")
            {
                url = @"https://novus.zakaz.ua/uk/products/04820004580188/beer-opillya-500ml-ukraine/";
                return new KorifeiWineStyle() as T;
            }
            else if (Name == "Опілля Класичне")
            {
                url = @"https://novus.zakaz.ua/uk/products/04820158670148/beer-opillya-500ml/";
                return new Classic() as T;
            }
            else if (Name == "Опілля Жигулівське")
            {
                url = @"https://novus.zakaz.ua/uk/products/04820109550147/beer-opillya-500ml-ukraine/";
                return new Jugulevskoe() as T;
            }
            else
                throw new Exception("Такого пива тут немає");
        }
        public double GetDegree()
        {
            return GetBeer().GetDegree();
        }
        string url = "";
        public double GetPrice()
        {//https://novus.zakaz.ua/uk/products/04820004580188/beer-opillya-500ml-ukraine/ Корифей
         //https://novus.zakaz.ua/uk/products/04820109550147/beer-opillya-500ml-ukraine/ Жигулівське
         //https://novus.zakaz.ua/uk/products/04820158670148/beer-opillya-500ml/ Класичне
            GetBeer();
            return Convert.
                ToDouble(
                GetHtmlDocument(
                    new Uri(url)).
                    DocumentNode.
                    SelectSingleNode("//html/body/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[2]/h6[1]/span[1]")?.
                    InnerText.
                    ToString().
                    Replace(".",","));
        }

        public string GetStyle()
        {
            return GetBeer().GetStyle();
        }
    }
}
