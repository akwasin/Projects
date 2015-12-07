using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forelasning7;

namespace Forelasning_8
{
    class Program : AnotherMyClass
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.internalProtected_string = "nytt värde";
            myClass.internal_string = "Nytt värde";
            myClass.public_string = "Nytt värde";


            AnotherMyClass anotherClass = new AnotherMyClass();



            //// {} object initializer
            //Car car = new Car() { Wheels = 7, HorsePower = 55 };
            //Bike bike = new Bike() { Wheels = 2, Spokes = 36, Passengers = 1 };
            //Vehicle vehicle = new Vehicle() { Passengers = 9, Wheels = 1243 };
            //vehicle.PrintVehicle();
            //Console.ReadLine();
        }
    }
}
