using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_12_Listor
{
    class Program
    {
        static void Main(string[] args)
        {

            var jas39 = new Flygplan(seats: 5, pilots: 2);
            var jas40 = new Flygplan(seats: 7, pilots: 0);

            var flygplan = new List<Flygplan>() {jas39, jas40};

            /*
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
            */

            System.Threading.Thread.Sleep(5000);
        }
    }
}

/*
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
