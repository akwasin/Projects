using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration1
{
    class Program
    {

        // TODO: while (stockitem[].length < 10) så ställ frågorna && counter++ (lägg till 1 på counter alternativt, while bool = true, ställ frågorna, sätt break på 4 - avsluta-)
        
        static void Main(string[] args)
        {
            // StockItem item1 = new StockItem() { Name = "namn" };
            //Console.WriteLine(item1);
            StockItem item1 = new StockItem() { Name = "Orange"};

            Console.WriteLine("1 - Skapa vara");
            Console.WriteLine("2 - Inventera vara");
            Console.WriteLine("3 - Lista varor");
            Console.WriteLine("4 - Avsluta");
            string userinput = Console.ReadLine();
            if (userinput == "1")
            {
                Console.WriteLine("Vad heter din vara");
                item1.Name = Console.ReadLine();
                //Console.WriteLine(item2.Name);
            }
            else if (userinput == "2")
            {
                Console.WriteLine($"Hur många {item1.Name} finns?");
                item1.StockCount = (int.Parse(Console.ReadLine()));
                Console.WriteLine($"Det finns {item1.StockCount}st {item1.Name}");
                Console.ReadKey();
            }
            else if (userinput == "3")
            {
                Console.WriteLine("en array");
                Console.ReadLine();
            }
            else
            {
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
