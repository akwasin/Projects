using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration1
{
    class Program
    {
        static void Main(string[] args)
        {
          StartProgram();
        }
        private static void StartProgram()
        {
            int stockItemChoice;
            bool validInput = false;
            int itemChoice;
            Stock stock = new Stock();
            bool runProgram = true;

            while (runProgram)
            {
                Meny.SkapaMeny();
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case ("1"):
                        stockItemChoice = CreateStockItem(stock);
                        break;
                    case ("2"):
                        InventeraItems(out validInput, out itemChoice, stock);
                        break;
                    case ("3"):
                        ListaAllaItems(stock);
                        break;
                    case ("4"):
                        runProgram = false;
                        Console.WriteLine("Tryck på en knapp för att avsluta");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Något gick fel, tryck på valfri knapp för att fortsätta");
                        Console.ReadKey();
                        StartProgram();
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
        }

        private static bool AvslutaLoop()
        {
            bool runProgram;
            runProgram = false;
            return runProgram;
        }

        private static void ListaAllaItems(Stock stock)
        {
            Console.Clear();
            Console.WriteLine("Lista Varor");
            for (int i = 0; i < stock.stockItems.Length; i++)
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
            Console.WriteLine("Tryck på valfri knapp för att gå vidare");
        }

        private static void InventeraItems(out bool validInput, out int ItemChoice, Stock stock)
        {
            Console.Clear();
            Console.WriteLine("Inventera Varor\r\n\r\nVälj en vara genom att skriva ID nummer (ex: 1)");
            for (int i = 0; i < stock.stockItems.Length; i++)
            {
                if (stock.stockItems[i] != null)
                {
                    Console.WriteLine(i.ToString() + " " + stock.GetItem(i));
                    Console.WriteLine("Välj en vara genom att skriva ID nummer");
                }
            }
            validInput = int.TryParse(Console.ReadLine(), out ItemChoice);
            if (validInput)
            {
                Console.WriteLine($"Skriv in ett nytt stock count för " + stock.stockItems[ItemChoice].Name); // good job A.J.
                stock.stockItems[ItemChoice].StockCount = int.Parse(Console.ReadLine());
            }
            else
                throw new Exception("Fyll i ett nummer");
        }

        private static int CreateStockItem(Stock stock)
        {
            int stockItemChoice;
            Console.Clear();
            Console.WriteLine("1 - Skapa stock item");
            Console.WriteLine("2 - Skapa Juice");
            Console.WriteLine("3 - Skapa Plate");
            Console.WriteLine("4 - Gå tillbaka");
            stockItemChoice = int.Parse(Console.ReadLine());
                        if (stockItemChoice == 1)
            {
                Console.Clear();
                Console.WriteLine("Skapa en ny stock item och lägg in den stock");
                Console.WriteLine("Fyll i namnet på varan: ");
                string stockItemName = Console.ReadLine();
                Console.WriteLine("Fyll i antalet " + stockItemName + ": ");
                int stockItemAmount = Int32.Parse(Console.ReadLine());
                StockItem stockItem = new StockItem() { Id = stock.counter, StockCount = stockItemAmount, Name = stockItemName }; stock.AddStockItem(stockItem);
                Console.WriteLine("Produkten " + stockItemName + " i antal " + stockItemAmount + " med id " + stock.counter + " har nu skapats.\r\nTryck på valfri knapp för att gå vidare"); // bra jobbat a.j.
            }
            else if (stockItemChoice == 2)
            {
                Console.Clear();
                Console.WriteLine("Skapa en ny juice och lägg in den stock");
                Console.WriteLine("Är det apple juice eller orange juice?");
                string stockItemJuiceType = Console.ReadLine();
                Console.WriteLine($"Vad heter din {stockItemJuiceType} juice?");
                string stockItemJuiceName = Console.ReadLine();
                Console.WriteLine($"Är {stockItemJuiceName} EG märkt eller Krav märkt?");
                string stockItemJuiceMark = Console.ReadLine();
                Console.WriteLine($"Fyll i antalet {stockItemJuiceName}");
                int stockItemJuiceAmount = Int32.Parse(Console.ReadLine());
                Juice juice = new Juice() { MarkningTyp = stockItemJuiceMark, JuiceTyp = stockItemJuiceType, Id= stock.counter, StockCount = stockItemJuiceAmount, Name = stockItemJuiceName };
                stock.AddStockItem(juice);
                Console.WriteLine($"Nu har {stockItemJuiceAmount}st {stockItemJuiceName} av frukten {stockItemJuiceType} med id {stock.counter} skapats\r\nTryck på valfri knapp för att gå vidare.");
            }
            else if (stockItemChoice == 3)
            {

                
            Console.WriteLine("Skapa ett stock item och lägg in den i stock");
            Console.WriteLine("Vill du ha en flat eller deep plate? ");
            string stockItemPlateType = Console.ReadLine();                
            Console.WriteLine("Fyll i antalet " + stockItemPlateType + " tallrikar: ");
            int stockItemPlateTypeAmount = Int32.Parse(Console.ReadLine());
            Plate plate = new Plate() { Typ = stockItemPlateType, Id = stock.counter, StockCount = stockItemPlateTypeAmount };
            stock.AddStockItem(plate);
            Console.WriteLine($"{stockItemPlateTypeAmount}st {stockItemPlateType} tallrikar har skapats med id {stock.counter}.\r\nTryck på valfri knapp för att gå vidare"); // good job Tim.
            }
            else if (stockItemChoice == 4)
            {
                StartProgram();
            }
            return stockItemChoice;
        }
    }
}
