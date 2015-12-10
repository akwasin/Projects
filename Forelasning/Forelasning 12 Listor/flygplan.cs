using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_12_Listor
{
    class Flygplan //: IComparable<flygplan>
    {
        public int Seats { get; internal set; } // access level på propertyn 
        public int Pilots { get; internal set; }

        public Flygplan(int seats, int pilots)
        {
            Seats = seats;
            Pilots = pilots;
        }

        public override string ToString()
        {
            return $"Seats: {Seats}, Pilots {Pilots}";
        }

       /* public int CompareTo(object obj)
        {
            Flygplan testPLane = (Flygplan) obj;
            // returnerar -1, 0 eller 1
            testPLane.Seats.CompareTo(this.Seats);
        }*/
    }
}
