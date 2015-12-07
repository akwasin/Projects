using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_8
{
    class Vehicle
    {
        public int Wheels { get; set; }
        public int Passengers { get; set; }

        public void PrintVehicle()
        {
            Console.WriteLine($"Basklassen säger \r\n Wheels: {Wheels}, Passengers: {Passengers}");
        }

        // public override string ToString() => $"Basklassen säger \r\n Wheels: {Wheels}, Passengers: {Passengers}";

        public override string ToString()
        {
            return $"Basklassen säger \r\n Wheels: {Wheels}, Passengers: {Passengers}";
        }
    }

    /*
    Finns det två klasser med samma attribut skapa då en basklass och lägg dem i den.
    det som skiljer de åt läggs i separerade underklasser/subklasser
        */

}
