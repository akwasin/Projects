using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class UppgiftEtt
    {
        static void Main(string[] args)
        {
            punktEtt();
            punktTva();
            punktTre();
            punktFyra();

            System.Threading.Thread.Sleep(10000);
            Console.ReadKey();
        }

        private static void punktEtt()
        {
            double newNumber = 1990;
            Console.WriteLine($"Hej, jag är född {newNumber}");

            newNumber = 1980;
            Console.WriteLine($"Erik är född {newNumber}");
        }
        private static void punktTva()
        {
            string newLine = "Dow Jones sjönk med";
            double newNumber = 4.6;
            Console.Write($"{newLine} {newNumber} procent");

            newLine = " och Nasdaq med ";
            newNumber = 4.1;
            Console.Write($"{newLine} {newNumber} procent.");

            newLine = "Stockholm";
            newNumber = -2.4;
            Console.Write($"{newLine} {newNumber} procent, ");

            newLine = "Milano";
            newNumber = -6.7;
            Console.Write($"{newLine} {newNumber} procent, ");

            newLine = "Paris";
            newNumber = -5.5;
            Console.WriteLine($"{newLine} {newNumber} procent.");
        }

        private static void punktTre()
        {
            const double PI = 3.141592654;
            //PI++; // fungerar ej
            Console.WriteLine($"Talet π är cirka {PI:N9} men kan avrundas till {PI:N4} och kan lite grovt skrivas som {PI:N0}");
        }
        private static void punktFyra()
        {
            string newLine = "Hemköp";
            Console.WriteLine($"Han heter Jonas och bor i Helsingborg på Stattena vid {newLine}");
        }
    }
}
