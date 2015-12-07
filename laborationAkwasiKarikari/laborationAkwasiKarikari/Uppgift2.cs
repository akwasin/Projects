using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Uppgift2
    {
        static void Main(string[] args) //
        {
            int myBirth = 1986; // int's behöver inga snuffar
            string myMonth = "juni"; // strängar måste snuffas
            string myName = "akwasi";

            // Console.Write("Hej Akwasi, jobba hårt!"); den här raden har blivit bortkommenterad
            Console.WriteLine($"När är {myName} född? Han är född i {myMonth} {myBirth}"); // här använder jag c# 6.0 för att hämta värden genom att ange dess namn
            Console.ReadLine();
        }
    }
}

/*
------ Build started: Project: laborationAkwasiKarikari, Configuration: Debug Any CPU ------
C:\Users\akwasibook\Documents\Visual Studio 2015\Projects\laborationAkwasiKarikari\laborationAkwasiKarikari\Uppgift2.cs(9,11,9,19): error CS0116: A namespace cannot directly contain members such as fields or methods
C:\Users\akwasibook\Documents\Visual Studio 2015\Projects\laborationAkwasiKarikari\laborationAkwasiKarikari\Uppgift2.cs(9,11,9,19): error CS0548: '<invalid-global-code>.Uppgift2': property or indexer must have at least one accessor
C:\Users\akwasibook\Documents\Visual Studio 2015\Projects\laborationAkwasiKarikari\laborationAkwasiKarikari\Uppgift2.cs(14,17,14,21): error CS0116: A namespace cannot directly contain members such as fields or methods
C:\Users\akwasibook\Documents\Visual Studio 2015\Projects\laborationAkwasiKarikari\laborationAkwasiKarikari\Uppgift2.cs(9,5,9,10): error CS0246: The type or namespace name 'klass' could not be found (are you missing a using directive or an assembly reference?)
========== Build: 0 succeeded, 1 failed, 0 up-to-date, 0 skipped ==========
    */
