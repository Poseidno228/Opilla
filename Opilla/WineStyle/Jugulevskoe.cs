using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace Opilla.WineStyle
{
    class Jugulevskoe : WineParser, IParserOneLiter
    {
        public Jugulevskoe()
        {
        }

        public Jugulevskoe(string name, DateTime time, string source, int volume, string manufacturer, string bottle, int shelfLife) : base(name, time, source, volume, manufacturer, bottle, shelfLife)
        {
            if (volume == 0.5)
                base.Price = GetPrice();
            else
                base.Price = GetPriceForLiter();
            base.Degree = this.GetDegree();
            base.Style = this.GetStyle();
        }
        public override double GetDegree()
        {
            base.formID = 81382;
            return base.GetDegree();
        }

        public override double GetPrice()
        {
            base.formID = 81382;
            return base.GetPrice();
        }

        public override double GetPriceForLiter()
        {
            base.formID = 81384;
            return base.GetPriceForLiter();
        }

        public override string GetStyle()
        {
            base.formID = 81384;
            return base.GetStyle();
        }
    }
}
