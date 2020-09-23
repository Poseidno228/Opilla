using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Opilla.WineStyle
{
    class Classic : WineParser, IParserOneLiter
    {
        public Classic() { }
        public Classic(string name, double volume, string bottle) : base(name, volume, bottle)
        {

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
