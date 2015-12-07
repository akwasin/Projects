using System; // gör att vi kan använda namespacet system
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning
{

    class Program
    {
        static void Main(string[] args)
        {
            flygplan flygster = new flygplan();

            Console.WriteLine("Hur många hjul har flygplanet?");
            flygster.SetHjul(int.Parse(Console.ReadLine()));
            Console.WriteLine(flygster.printPlane());

            Console.ReadLine();
            //Skapa_Motorcykel();
        }
        /*
        private static void Skapa_Motorcykel()
        {
            Motorcykel Speedster = new Motorcykel();
            Motorcykel Hikester = new Motorcykel();

            Console.WriteLine("Hur snabb är Speedster");
            Speedster.SetMaxSpeed(int.Parse(Console.ReadLine()));

            Console.WriteLine("Hur snabb är Hikester");
            Hikester.SetMaxSpeed(int.Parse(Console.ReadLine()));


            if (Hikester.GetMaxSpeed() > Speedster.GetMaxSpeed())
            {
                Console.WriteLine("Hikester Vinner!");
            }
            else
            {
                Console.WriteLine("Speedster Vinner!");
            }
        }*/
    }
}
