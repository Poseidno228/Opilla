using System;
using System.Collections.Generic;
using System.Text;
using HtmlAgilityPack;
using System.Text.RegularExpressions;
using Opilla.WineStyle;

namespace Opilla.WineStyle
{
    class KorifeiWineStyle : WineParser, IParserOneLiter
    {
        public KorifeiWineStyle() { }
        public KorifeiWineStyle(string name, double volume, string bottle) : base(name, volume, bottle)
        {
           
        }
        public override double GetDegree()
        {
            base.formID = 81376;
            return base.GetDegree();
        }
        public override double GetPrice()
        {
            base.formID = 81376;
            return base.GetPrice();
        }
        public override double GetPriceForLiter()//1138
        {
            base.formID = 81377;
            return base.GetPriceForLiter();
        }
        public override string GetStyle()
        {
            base.formID = 81376;
            return base.GetStyle();
        }        
    }
}
