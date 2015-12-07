using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class ovningsuppg
    {
        static int Add(int inPut)
        {
            return inPut + 10;
        }

        static int Multiply(int inPut)
        {
            return inPut * 10;
        }

        //static void Add(int inPut)
        //{
        //    return inPut + 10;
        //}

        /*
Uppgift 2

I denna uppgift ska du testa ett ref-parametrar, som ett alternativ till returvärde.

Förändra signaturen i för metoderna i uppgift 1 så att de inte returnerar något ("void"), och lägg till "ref" för argumenten (se boken för exempel). Testa att kompilera, och se vad kompilatorn säger. Förändra därefter anropen så att kompilatorn blir nöjd. Testkör, och kontrollera att resultatet blir detsamma som i förra uppgiften.

Testa för skojs skull också att ta bort "ref" för att se vad som händer. Vad blir utskriften från programmet, och varför?
*/


        static void Main(string[] args)
        {
            int myInt = 5;

            //myInt = Add(myInt);
            myInt = Multiply(myInt);
            Console.WriteLine(myInt);

            Console.ReadLine();

            System.Threading.Thread.Sleep(8000);
        }
    }
}