using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_6
{
    
    class GetSet
    {
        int tal = 9;
        static void Nyatider()
        {
            GetSet getset = new GetSet();
            getset.tal = 5;

            Class1.SetNumber(6);
            Class1.reachableNumber = 7;
            Console.WriteLine(Class1.PI);
        }     
    }
}
