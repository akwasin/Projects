using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_10
{
    class Cat : Animal
    {
        private string djur = "katt";
        // public string MyProperty { get; set; } = "cat"; 
        // prop tab tab

        public override void PrintInfo()
        {
            Console.WriteLine($"Djur: {djur}, Name: {Name}");
        }

        public override string ToString() => $"Djur: {djur}, " + base.ToString();
    }
}
