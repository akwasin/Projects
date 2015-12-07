using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_8
{
    class Bike : Vehicle
    {
        public int Spokes { get; set; }
        public override string ToString()
        {
            return string.Format("Spokes: {0} Resten: {1}", Spokes, base.ToString()); // erik får förklara bakom kulisserna
        }
    }
}
