using System;
using System.Collections.Generic;
using System.Text;

namespace Opilla
{
    interface IParser
    {
        double GetPrice();
        double GetDegree();
        string GetStyle();
    }
}
