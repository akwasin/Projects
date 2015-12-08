using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_10
{
    abstract class Animal
    {
        public string Name { get; set; } // = "Defaultl värde";

        public abstract void PrintInfo();

        public override string ToString() => $"Name: {Name}";
    }
}
