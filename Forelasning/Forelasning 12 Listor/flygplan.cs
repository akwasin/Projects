using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_12_Listor
{
    class Flygplan
    {
        public int Seats { get; set; }
        public int Pilots { get; set; }

        public Flygplan(int seats, int pilots)
        {
            Seats = seats;
            Pilots = pilots;
        }

        public override string ToString()
        {
            return $"Seats: {Seats}, Pilots {Pilots}";
        }
    }
}
