using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning7
{
    class program
    {
        static void Main(string[] args)
        {
            //Va va = new Va();
            //Va va2 = new Va("hej");
            //Va va3 = new Va();
            //va va4 = new va();

            Hat nyHatt = new Hat("black", "suede", 52);
            Runsten runstenEtt = new Runsten(age:600, weight:900, name:"Lund"); // named params
            Bulb bulbEtt = new Bulb(350, 90, 80);

            Console.WriteLine(nyHatt);
            //Console.WriteLine(runstenEtt);
            //Console.WriteLine(bulbEtt);
            System.Threading.Thread.Sleep(7000);
        }

    }
}
