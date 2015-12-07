using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_8_hiding
{
    class Program
    {
        static void Main(string[] args) // TODO: Erik förklarar
        {
            A a = new A();
            A ab = new B(); //används som en härled klass, den är egentligen ett A men tror den e B
            B b = new B();

            a.Print();
            ab.Print();
            b.Print();
        }
    }

    class A
    {
        public void Print()
        {
            Console.WriteLine("Basklassen");
        }
    }

    class B : A
    {
        public new void Print() // utan new uppstår namnkonflikt. print finns i båda. B ärver från A
        {
            Console.WriteLine("Gömd metod i subklassen");
        }
    }
}

