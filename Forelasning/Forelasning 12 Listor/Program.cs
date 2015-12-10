using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_12_Listor
{

    public class Frukt
    {
        public string typ { get; set; }
        public int antal { get; set; }

        public Frukt(string Typ, int Antal)
        {
            Typ = typ;
            Antal = antal;
        }

        public Frukt()
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*
            var frukt1 = new Frukt();
            var frukt2 = new Frukt();
            var frukt3 = new Frukt();

            Console.WriteLine("Fyll i 3 Frukt");
            frukt1.typ = Console.ReadLine();
            Console.WriteLine("Fyll i 2 Frukt");
            frukt2.typ = Console.ReadLine();
            Console.WriteLine("Fyll i 1 frukt");
            frukt3.typ = Console.ReadLine();

            var treFrukter = new List<string>();
            treFrukter.Add(frukt1.typ);
            treFrukter.Add(frukt2.typ);
            treFrukter.Add(frukt3.typ);

            /*Console.WriteLine($"Fyll i minimumantal av" + frukt1);
            frukt1.antal(int.Parse(Console.ReadLine()));
            Console.WriteLine($"Fyll i minimumantal av" + frukt2);
            frukt2.antal(int.Parse(Console.ReadLine()));
            Console.WriteLine($"Fyll i minimumantal av" + frukt3);
            frukt3.antal(int.Parse(Console.ReadLine()));

            */
            var products = new List<Product>();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Produktnamn:");
                var name = Console.ReadLine();
                Console.WriteLine("Antal:");
                var quantity = int.Parse(Console.ReadLine());
                products.Add(new Product(name, quantity));
            }
            products.Sort();
            Console.WriteLine("Vilket tal är min?");
            var min = int.Parse(Console.ReadLine());

            foreach (var product in products)
            {
                if (product.Quantity > min)
                    Console.WriteLine(product);
            }
            Console.ReadLine();


            System.Threading.Thread.Sleep(5000);
        }
    }
}

/*

    var flygplan1 = new Flygplan(seats: 5, pilots: 2);
            var flygplan2 = new Flygplan(seats: 7, pilots: 2);
            var flygplan3 = new Flygplan(seats: 10, pilots: 3);

            var flygplan = new List<Flygplan>();

            flygplan.Add(flygplan1);
            flygplan.Add(flygplan2);
            flygplan.Add(flygplan3);

            flygplan.Sort();
            Console.WriteLine(flygplan);

            List<int> tal = new List<int>(new int[] {2,2,3,2,29,33,32});
            int indexPosition = tal.IndexOf(29); // position 4 är första förekomsten av 29
            Console.WriteLine(indexPosition);
            //int indexPosition2 = tal.IndexOf(17); // 17 finns inte så den tar inte fram ngt.
            int talInt = tal[3]; // hämtar nummer i range på plats 3. plats 0 är först.

            list<T> = T ersätter tex int, string, double samtidigt, dvs T kan hålla alla datatyper

            var Lista = new List<bool>() { true, false, true };
            Lista.Add(true);
            Lista.Add(false);
            Lista.Add(true);

            Console.WriteLine(Lista.Count); // antal element i Lista (som length i js)
            Lista.Clear();
            Console.WriteLine("nu rensar vi");
            Console.WriteLine(Lista.Count);

            var jas39 = new Flygplan(seats: 5, pilots: 2);
            var jas40 = new Flygplan(seats: 7, pilots: 0);
            jas39.Seats = 5;
            var flygplan = new List<Flygplan>() {jas39, jas40};

            busses.sort(); // sorterar efter nummer, stigande
            busses.reverse(); // vänder på sorteringen, fallande

            var kopia = busses; // skapar en kopia på bussen

            var busEtt = new Bus(44, 250);
            var busses = new List<Bus>();
            for (int i = 0; i < 10; i++)
            {
                busses.Add(new Bus(seats: 40, hp: 200+1));
            }

            foreach (var bus in busses)
            {
                Console.WriteLine(bus);
            }


// Skapa personer lista
// Lista1()
var persons = new List<Person>();
            for (int i = 0; i < 50; i++)
            {
                persons.Add(new Person("Name"+1, i%30));
            }

            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }

    // Personer
var lisa = new Person("Lisa", 26);
            var raffe = new Person("Rafael", 44);

            List<Person> persons = new List<Person>();

            persons.Add(lisa);
            persons.Add((raffe));

            foreach (var person in persons)
            {
                Console.WriteLine(person.Name);
            }
*/
