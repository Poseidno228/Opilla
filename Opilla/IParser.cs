using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Opilla
{
    interface IParser
    {
        double GetPrice();
        double GetDegree();
        string GetStyle();
    }
}
