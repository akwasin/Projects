using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodninggg
{
    class Program
    {
        static void Main(string[] args)
        {
          WareHouseMethod();
        }
        private static void WareHouseMethod()
        {
            int stockItemChoice;
            bool validInput = false;
            int itemChoice;
            Stock stock = new Stock();
            bool retry = true;

            while (retry)
            {
                Meny.PrintMeny();
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case ("1"):
                        stockItemChoice = CreateStockItem(stock);
                        break;
                    case ("2"):
                        InventoryItems(out validInput, itemChoice, stock);
                        break;
                    case ("3"):
                        ListAllItems(stock);
                        break;
                    case ("4"):
                        retry = ExitLoop();
                        break;
                    default:
                        Console.WriteLine("You picked a wrong number.");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
        }

        private static bool ExitLoop()
        {
            bool retry;
            Console.WriteLine("Stop");
            retry = false;
            return retry;
        }

        private static void ListAllItems(Stock stock)
        {
            Console.WriteLine("Lista Varor");
            for (int i = 0; i < stock.stockItems; i++)
            {
                if (stock.stockItems[i] is EcoStockItem && stock.stockItems[i] != null)
                {
                    Console.WriteLine(stock.GetItem(i));
                }
                else if (stock.stockItems[i] != null)
                {
                    Console.WriteLine(stock.GetItem(i));
                }
            }
        }

        private static void InventoryItems(out bool validInput, out int ItemChoice, Stock stock)
        {
            Console.WriteLine("Inventera Varor");
            for (int i = 0; i < stock.stockItems.Length; i++)
            {
                if (stock.stockItems[i] != null)
                {
                    Console.WriteLine(i.ToString() + " " + stock.GetItems(i));
                    Console.WriteLine("Välj en vara genom att skriva numret");
                }
            }
            validInput = int.TryParse(Console.ReadLine(), out ItemChoice);
            if (validInput)
            {
                Console.WriteLine("Skriv in ett nytt stock count");
                stock.stockItems[ItemChoice].StockCount = int.Parse(Console.ReadLine());
            }
            else
                throw new Exception("Please write a number");
        }

        private static int CreateStockItem(Stock stock)
        {
            int stockItemChoice;
            Console.WriteLine("1. Create stock item");
            Console.WriteLine("2. Create Juice");
            Console.WriteLine("3. Create Plate");
            stockItemChoice = int.Parse(Console.ReadLine());
            if (stockItemChoice == 1)
            {
                Console.WriteLine("Create a stock item and add to stock");
                Console.WriteLine("Write the number of the item in stock and name of the item");
                StockItem stockItem = new StockItem() { Id = stock.counter, stockCount = int.Parse(Console.ReadLine(), Name = Console.ReadLine())};
                stock.AddItem(stockItem);
            }
            else if (stockItemChoice == 2)
            {
                Console.WriteLine("Create stock item and add to stock");
                Console.WriteLine("Write the eco mark EG or Krav, the juice type, the number of the item in stock and the name of the item");
                Juice juice = new Juice() { Mark = Console.ReadLine(), Flavor = Console.ReadLine(), Id= stock.counter, StockCount = int.Parse(Console.ReadLine()), Name = Console.ReadLine() };
                stock.AddItem(juice);
            }
            else if (stockItemChoice == 3)
            {
                Console.WriteLine("Create stockitem and add to stock");
                Console.WriteLine("Write type of the plate, number of the item in stock and name of the item in that order");
                Plate plate = new Plate() { Type = Console.ReadLine(), Id = stock.counter, StockCount = int.Parse(Console.ReadLine())};
                stock.AddItem(plate);
            }
            return stockItemChoice;
        }



    }
}
