using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Övn_5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Uppgift1
            string strString = "text";
            object objObjekt = strString;
            char charText;
            bool boolVillkor = true;
            int intTal2 = 10;
            double doublTal = 100.1;
            double doublTal2 = 70.70; // typ konvertering
            double doubleTal3 = (double)intTal2;
            int intTal = (int)doublTal; // explicit konvertering
            double doubleTal = (double)intTal;  // explicit konvertering

            //int number = Int32.Parse(strString); kommer inte att fungera
            //Console.WriteLine(number.GetType());

            string boolConvert = Convert.ToString(boolVillkor); // konverterar bool till string
            //Console.WriteLine(doublTal); // skriver ut doubleTal
            int doubleConvert = Convert.ToInt32(doublTal);  // konverterar doubleTal till int doubleConvert
                                                            //Console.WriteLine(doubleConvert.GetType()); // skriver ut vilken typen av doubleConvert
                                                            //Console.WriteLine(doubleConvert); // skriver ut doubleConvert
                                                            //Console.WriteLine(boolConvert.GetType());
                                                            //Console.WriteLine(doubleTal3.GetType());

            //Double.Parse(doublTal.ToString());
            //Console.WriteLine("1" + doublTal.GetType());

            //Manniska manniska = new Manniska();
            //Manniska human = new Delfin(); 

            //private class Delfin : Manniska
            //{
            //}

            //private class Manniska
            //{
            //}
            #endregion

            #region uppgift2-3
            Point3D newPoint = new Point3D();
            newPoint.SetX(10);
            newPoint.SetY(20);
            newPoint.SetZ(30);

            //Console.WriteLine(newPoint); 
            #endregion

            #region uppgift4
            A a = new A();
            B b = new B();
            C c = new C();
            B cb = new C(); // B cb kan bli C men c cb kan inte bli B
            A ca = new C();

            //Console.WriteLine(a + " ett a som är ett nytt A");
            //Console.WriteLine(b + " ett b som är ett nytt B");
            //Console.WriteLine(c + " ett c som är ett nytxt C");
            //Console.WriteLine(cb + " ett b som är ett nytt C");
            //Console.WriteLine(ca + " ett a som blir ett nytt C"); 
            #endregion

            System.Threading.Thread.Sleep(8000);
        }
    }
}
