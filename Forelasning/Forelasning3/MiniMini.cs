using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_3
{
    class MiniMini
    {
        internal int GetMinFromArray(int[] theArray)
        {
            int min = theArray[0];
            for (int i = 0; i < theArray.Length; i++)
            {
                if (theArray[i] < min)
                    min = theArray[i];
            }
            return min;
        }
    }
}
