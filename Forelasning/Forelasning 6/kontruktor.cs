using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* MAIN METODEN
            // finns ingen tom kontruktor tvingar vi användaren att följa signaturen för en annan kontruktor
            Person lisa = new Person();
            Person stina = new Person(7, "svensson");

            Rectangle recEtt = new Rectangle(10,10);
            Rectangle recTva = new Rectangle(3.2, 5.4);
            Rectangle recTre = new Rectangle(20);

            // named parameters > nu kan vi ändra ordningen hei, wid istället för wid,hei
            Rectangle recFyra = new Rectangle(width:44, height:23);
*/

namespace Forelasning_6
{
    class Rectangle
    {
        double height;
        double width;

        public Rectangle(double height = 0, double width = 0)
        {
            this.height = height;
            this.width = width;
        }
    }
    class Person
    {
        int age;
        string lastname;

        public Person()
        {
            age = 0;
        }

        public Person(int age, string lastname) // överlagrad kontruktor > in kontruktor med inparametrar
        {
            this.age = age;
            this.lastname = lastname;

            if (lastname == null)
            {
                lastname = "Doe";
            }
        }
    }

}
