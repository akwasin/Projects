using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Förelasning_15
{
    class Class1
    {

        internal void Method()
        {
            try
            {
                var tal = 67 / int.Parse(Console.ReadLine());
                // division med 0 ger en crash devide by zero exception
            }
            catch (Exception ex)
            {               
                //throw new Exception($"Message {ex.Message}\r\nSource:{ex.Source}\r\nSource:{ex.StackTrace}");
                Console.WriteLine(ex.Message);
                Method();
            }
            Console.WriteLine("Metoden i klassen");
            
        }
    }
}
