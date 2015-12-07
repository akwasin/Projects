using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_10
{
    abstract class Vehicle
    {
        // abstract innebär att vi lämnar över allt ansvar till underliggande subklasser
        public abstract void Print();
    }

    class Car : Vehicle
    {
        public override void Print() {
            Console.WriteLine("Skriver ut texten i Car klassen");
        }
    }
}
