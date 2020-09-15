using System;
using System.Collections.Generic;
using System.Text;

namespace Opilla.WineStyle
{
    class Classic : Opilla, IParserOneLiter
    {
        public Classic(string name, DateTime time, string source, int volume, string manufacturer, string bottle, int shelfLife) : base(name, time, source, volume, manufacturer, bottle, shelfLife)
        {
            if (volume == 0.5)
                base.Price = GetPrice();
            else
                base.Price = GetPriceForLiter();
            base.Style = this.GetStyle();
            base.Degree = this.GetDegree();
        }
        public double GetDegree()
        {
            throw new NotImplementedException();
        }

        public double GetPrice()
        {
            throw new NotImplementedException();
        }

        public double GetPriceForLiter()
        {
            throw new NotImplementedException();
        }

        public string GetStyle()
        {
            throw new NotImplementedException();
        }
    }
}
