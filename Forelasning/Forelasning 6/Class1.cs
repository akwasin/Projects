using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_6
{
    class Class1
    { 
        public static int reachableNumber; // pga static finns det bara 1
        private static int notReachableNumber;
        public const double PI = 3.1415936454; // const är implicit static

        public static void SetNumber(int number) // måste vara static
        {
            notReachableNumber = number;
        }
    }
}
