using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_14_Interface
{
    internal interface IInterface : IInterface2
    {
        void Method();

        // Fungerar inte
        //void Method()
        //{
        //    Console.WriteLine("Hej");
        //}
    }

    internal interface IInterface2
    {
        void Method2();
    }

    class MyClass : IInterface
    {
        // enligt kontraktet med Interface måste vi skapa en metodkropp som hanterar den metod som är deklarerad i interfacet.
        public void Method()
        {
            Console.WriteLine("Implmenterar interfacet");
        }

        void IInterface2.Method2()
        {
            Console.WriteLine("Implmenterar interface:2");
        }
    }
}
