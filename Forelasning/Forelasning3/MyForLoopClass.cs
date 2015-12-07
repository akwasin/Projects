using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_3
{
    internal class MyForLoopClass
    {
        // 1.åtkomstdirektiv(private e default) 2.returvärde 3.identifierare
        internal void OneToHundred()
        {
            // for (startärde;villkor;förändring){saker som sker i loopen}
            for (int i=1; i<=100; i = i + 2)
            {
                Console.WriteLine(i);
            }
        }

        internal double GetAverage(int[] arrayToCalculateOn)
        {
            double sum = 0;
            for (int i = 0; i < arrayToCalculateOn.Length; i++)
            {
                sum += arrayToCalculateOn[i];
            }
            double result = sum / arrayToCalculateOn.Length;
            return result;
        }
    }
}
