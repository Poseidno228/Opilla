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
            base.formID = 81379;
            return base.GetDegree();
        }

        public override double GetPrice()
        {
            base.formID = 81379;
            return base.GetPrice();
        }

        public override double GetPriceForLiter()
        {
            base.formID = 81381;
            return base.GetPriceForLiter();
        }

        public override string GetStyle()
        {
            base.formID = 81379;
            return base.GetStyle();          
        }
    }
}
