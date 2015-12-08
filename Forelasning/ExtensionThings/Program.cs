using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = MyStringExtension.Dotify("hej");
            var tal = MyStringExtension.Plussa(10);
            Console.WriteLine(10.Plussa());

            Console.WriteLine(name);
            Console.WriteLine("kalle".Dotify());
            Console.ReadLine();
        }
    }
}
