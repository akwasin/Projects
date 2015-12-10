using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bil nyBilEtt = new Bil("ford", 6, "Navy", "kombi");
            //Bil nyBilTva = new Bil("Volvo", 5, "White", "kupe");
            // Bil nyBilTre = new Bil("Nissan", 6, "White", "Suv"); //fel mess pga av string "suv"
            //Console.WriteLine($"{nyBilEtt} and {nyBilTva} \r\n\r\n");

            Radio radio = new Radio();
            Radio radio2 = new Radio(7, true);
            Radio radio3 = new Radio() { IsOn = true };
            // Console.WriteLine(radio3);

            Cykel cykel1 = new Cykel();
            //Cykel cykel2 = new Cykel() { RingKlocka = true};

            Ipad ipadEtt = new Ipad() { FourGee = true };

            Console.WriteLine(ipadEtt);
            Console.WriteLine(ipadEtt.FourGee);
            System.Threading.Thread.Sleep(20000);
        }
    }
}