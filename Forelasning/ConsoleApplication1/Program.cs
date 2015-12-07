using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_10
{
    class Program
    {
        public void Main(string[] args)
        {

            #region
            //Cykel cykel = new Cykel();
            //Fordon fordon = new Fordon();
            //Bil bil = new Bil();
            //Fordon[] fordonare = new Fordon[3];
            //fordonare[0] = cykel;
            //fordonare[1] = bil;
            //fordonare[2] = fordon;

            // Vehicle vehicle = new Vehicle(); kommer inte att fungera eftersom att klassen vehicle är abstrakt

            // virtual override > du får lova att overrida
            // virtual abstract > du måste överrida

            //Vehicle vehicle = new Car();
            //foreach (var item in fordonare)
            //{
            //    item.Print();
            //}
            //Console.WriteLine();
            #endregion

            Animal katt = new Cat();
            Animal hund = new Dog();


            System.Threading.Thread.Sleep(10000);
        }
    }
}
