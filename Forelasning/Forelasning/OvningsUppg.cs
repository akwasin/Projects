using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning
{
    class OvningsUppg
    {
        /*static void Main(string[] args)
        {
            //UppgiftEtt();
            //UppgiftTva();
            //UppgiftTre();
            //UppgiftFyra();
            //UppgiftFem();
            //UppgiftSex();
            UppgiftSju();
            //UppgiftTjugo();
        }*/

        private static void UppgiftSju()
        {
            throw new NotImplementedException();
        }

        private static void UppgiftTjugo()
        {
            List<int> helTal = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Fyll i ett talet:");
                helTal.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine($"Du har fyllt i {helTal.Count} tal.");
            Console.WriteLine($"Totala värdet av dina tal är {helTal.Sum()}.");
            Console.ReadLine();
        }

        private static void UppgiftSex()
        {
            string inPut1 = "";
            string inPut2 = "";
            int tal1 = 0;
            int tal2 = 0;

            while (true)
            {
                if (!int.TryParse(inPut1, out tal1))
                {
                    Console.WriteLine("Fyll i ett nummer för x: ");
                    inPut1 = Console.ReadLine();
                }
                else if (!int.TryParse(inPut2, out tal2))
                {
                    Console.WriteLine("Fyll i ett nummer för a: ");
                    inPut2 = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            int delSumma = (tal1 * tal2) + 3;
            int summa = delSumma + 7;
            Console.WriteLine($"Svaret är {0}");
            Console.ReadLine();
        }

        private static void UppgiftFem()
        {
            double dollarKurs = 6;
            double pundKurs = 12;
            Console.WriteLine("Fyll i en summa i kr:");
            double summa = int.Parse(Console.ReadLine());
            double dollar = summa / dollarKurs;
            double pund = summa / pundKurs;
            Console.WriteLine($"{summa}kr ger dig ${dollar:N2} och £{pund:N2}");
            Console.ReadLine();
        }

        private static void UppgiftFyra()
        {
            //int[] antalNum = new antalNum[3];
            List<int> antalNum = new List<int>();

            Console.WriteLine("Fyll i första talet:");
            antalNum.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine("Fyll i andra talet:");
            antalNum.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine("Fyll i tredje talet:");
            antalNum.Add(int.Parse(Console.ReadLine()));

            int summa = 0;

            foreach (int i in antalNum)
            {
                summa += i;
            }

            Console.WriteLine("Summan är " + summa);
            Console.WriteLine("Medelvärdet av summan är = " + summa / antalNum.Count);
            Console.ReadLine();
        }

        private static void UppgiftTre()
        {
            Console.WriteLine("Fyll i antal timmar");
            int antalTim = int.Parse(Console.ReadLine());
            double antalMin = antalTim * 60;
            double antalSek = antalTim * 3600;
            Console.WriteLine("{0} timmar är {1} minuter och {2} sekunder"
                              , antalTim, antalMin, antalSek);
            Console.ReadLine();
        }

        private static void UppgiftTva()
        {
            int FastLon = 15000;
            Console.WriteLine("Vad har du sålt för den här månaden?");
            int ForSumma = int.Parse(Console.ReadLine());
            double Procent = 0.9;
            double Provision = Procent * ForSumma;
            double TotLon = FastLon + Provision;
            Console.WriteLine("Din månadslön är " + TotLon + "kr");
            Console.ReadLine();
        }

        private static void UppgiftEtt()
        {
            Console.WriteLine("Skriv in ett nummer: ");
            int tal = int.Parse(Console.ReadLine());
            Console.WriteLine(tal * tal);
            Console.ReadLine();
        }
    }
}
