using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_10
{
    class Dog : Animal
    {
        private string djur = "hund";
        // public string MyProperty { get; set; } = "cat"; 
        // prop tab tab

        public override void PrintInfo()
        {
            Console.WriteLine($"Djur: {djur}, Name: {Name}");
        }
    }
}
