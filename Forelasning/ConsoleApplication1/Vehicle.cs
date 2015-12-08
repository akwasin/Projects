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
        // utifrån detta kan vi inte sätta ett default värde i basklassen med abstract
        // virtual innebär att subklass Kan sätta värdet på propertyn
        // med override kan man använda base.tostring() för att sätta ett värde
        public abstract void Print();
    }

    class Car : Vehicle
    {
        public override void Print() {
            Console.WriteLine("Skriver ut texten i Car klassen");
        }
    }
}
