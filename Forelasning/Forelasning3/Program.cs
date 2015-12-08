using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*MyForLoopClass myForLoopClass = new MyForLoopClass();
            myForLoopClass.OneToHundred();
            int[] testArray = { 1,3,3};
            Console.WriteLine(myForLoopClass.GetAverage(testArray));
            */

            //MyClass myClass = new MyClass();

            MiniMini lowestNumber = new MiniMini();

            Console.WriteLine(lowestNumber.GetMinFromArray(new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 1, 10 }));

            System.Threading.Thread.Sleep(6000);

        }
    }
}
