using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_5
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    /*int ickeMagi = 6; // variablen av typen int måste ha ett värde
        //    Magiska(ref ickeMagi);
        //    Console.WriteLine(ickeMagi);*/

        //    //Program program = new Program();
        //    var program = new Program();
        //    string text;

        //    program.Musik(out text);

        //    System.Threading.Thread.Sleep(10000);
        //}

        // eftersom att den inte är statisk måste man skapa en ny instans för att kunna kalla metoden. Metoden är dessutom per default private.
        void Musik(out string lyrik)
        {
            lyrik = "Stilla natt...";
        }
        // ref värdet ändrar variablen tal till ref värdet inuti metoden 
        static void Magiska(ref int tal)
        {
            tal = 5;
        }
    }

}
