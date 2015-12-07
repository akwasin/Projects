using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_3
{
    internal class MyClass
    {
        public int Numbers(int[] calculationArray)
        {
            // 1,2,3 skickades in på position [0][1][2]
            int lowestNumber = calculationArray[0];

            for (int i = 0; i > calculationArray.Length; i++)
            {
                if (calculationArray[i] < lowestNumber)
                    lowestNumber = calculationArray[i];
            }
            return lowestNumber;
        }
    }
}
