using Opilla.WineStyle;
using System;
using System.Collections.Generic;
using System.Text;

namespace Opilla.Novus
{
    class Novus : Opilla, IParser
    {
        public Novus()
        {
        }

        //https://novus.zakaz.ua/uk/products/04820004580188/beer-opillya-500ml-ukraine/
        private V GetBeer<V>()
            where V : Opilla

        {
            if (Name == "Опілля Корифей")
                return new KorifeiWineStyle() as V;
            else if (Name == "Опілля Класичне")
                return new Classic() as V;
            else if (Name == "")
                return new Jugulevskoe() as V;
            else
                throw new Exception("Такого пива тут немає");
        }
        public double GetDegree()
        {
            throw new NotImplementedException();
        }

        public double GetPrice()
        {
            throw new NotImplementedException();
        }

        public string GetStyle()
        {
            throw new NotImplementedException();
        }
    }
}
