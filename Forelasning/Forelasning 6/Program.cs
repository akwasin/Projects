using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_6
{
    class Program
    {
        static void Main(string[] args)
        {

            TableCon tableCon = new TableCon();
            tableCon.SetChairs(4);
            tableCon.SetColor("Wood");

            TableProp tableProp = new TableProp();

            Properties zelda = new Properties();
            zelda.Lives = 4;
            Console.WriteLine(zelda.Lives);

            BiCycle cresent = new BiCycle();
            cresent.Brand = "Crecent";
            cresent.Gears = 24;

            // går bara på properties (object initilizer)
            BiCycle rex = new BiCycle() { Brand="rex", Gears=7 }; 
        }

    }
}
