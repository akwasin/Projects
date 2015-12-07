using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_5
{
    class TryMe
    {
        static void Main(string[] args)
        {
            //användaren skriver in ett tal:
            string text = "4 eller ngt liknande";
            //int nummer = 99;


            //bool validNumber = int.TryParse(text, out nummer);
            //if (validNumber)
            //{
            //    Console.WriteLine($"inget giltigt nummer {nummer}");
            //} else
            //{
            //    Console.WriteLine($"det är ett nummer {nummer}");
            //}

            //Console.WriteLine("--------------------");

            //validNumber = int.TryParse(text, out nummer);
            //if (validNumber == false)
            //{
            //    Console.WriteLine("inget giltigt nummer");
            //}


            text = "100";
            int tal;
            if (int.TryParse(text, out tal))
            {
                // körs bara om  text går att konvertera till int
                Console.WriteLine($"talet är {tal}");
            }

            System.Threading.Thread.Sleep(10000);
        }
    }
}
