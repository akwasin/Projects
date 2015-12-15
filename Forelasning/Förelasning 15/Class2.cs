using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Förelasning_15
{
    class Class2
    {
        internal void Method()
        {
            try
            {
                Console.WriteLine("Skriv ett tal som ska delas med 6");
                var tal = 6/int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) // denna är redundant (den gör alla exceptions annars)
            {
                Console.WriteLine("Hanterar allt");
                throw ex;
            }
            finally
            {
                Console.WriteLine("STÄNG Databasen!!!");
            }
            Console.WriteLine("Eftersläntare");

        }
        }
    }
}
