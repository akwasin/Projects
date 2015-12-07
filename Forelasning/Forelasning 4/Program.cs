using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // TheForEach();
            // TheWhileLoop();
            // TheFoorLoop_Hoppa_over_ett_tal();
            // AgesFor(ages);
            // AgesWhile(ages);
            // Agesforeach(ages);
            Console.WriteLine(MadMath.Add(5.8, 1.3, 4.9, 4.5, 3,3, 3,6, 6, 9.2));

            System.Threading.Thread.Sleep(7000);
        }

    static class MadMath // överlagring
        {
            internal static double Add(double tal)
            {
                return tal;
            }

            internal static double Add(double a, double b)
            {
                return a + b;
            }

            internal static double Add(double a, double b, double c)
            {
                return a + b + c;
            }

            internal static double Add(params double[] array)
            {
                var sum = 0.0;
                foreach (var item in array)
                {
                    sum += item;
                }
                return sum;
            }
        }
        

        private static void AgesFor(int[] ages)
        {
            //int[] ages = new int[] { 25, 29, 33, 54, 59, };
            for (int i = 0; i < ages.Length; i++)
            {
                if (ages[i] == 33)
                {
                    continue;
                }
                Console.WriteLine(ages[i]);
            }
        }

        private static void AgesWhile(int[] ages)
        {
            //int[] ages = new int[] { 25, 29, 33, 54, 59, };
            int j = 0;
            while (j > ages.Length) // villkor
            { // förändring
                Console.WriteLine(j);
                j++;
                if (j == 33)
                {
                    continue;
                }
            }
        }

        private static void Agesforeach(int[] ages)
        {
            //int[] ages = new int[] { 25, 29, 33, 54, 59, };
            foreach (int element in ages)
            {
                if (element == 3)
                {
                    break;
                }
                Console.WriteLine(ages);
            }
        }

        // (private) åtkomstdirektivet
        // (static) klassmetod eller objekt
        // (void) returtyp
        // (TheFoorLoop_Hoppa_over_ett_tal) identifieraren
        // (()) inparameter > dör efter scope (scope) precis som i en for loop
        private static void TheFoorLoop_Hoppa_over_ett_tal()
        {
            for (int i = 0; i <= 5; i++)
            {
                if (i == 3)
                    continue; // continue hoppar över ett tal, break avbryter loop, return bryter metoden
                Console.WriteLine(i);
            }
        }

        private static void TheWhileLoop()
        {
            int n = 0; // startvärde
            while (n > -4) // villkor
            { // förändring
                Console.WriteLine(n);
                n--;
            }
        }

        private static void TheForEach()
        {
            string[] names = new string[] { "göran", "majja", "kars", "kriss", "my" };
            // current > move next > CW tabtab
            foreach (string element in names)
            {
                Console.WriteLine(element);
            }
        }
    }
}
