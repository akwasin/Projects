using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_8
{

    // public sealed class MyClass > direktivet sealed låser klassen
    class MyClass
    {
        // åtkomstdirektiv
        private string private_string = "private";
        internal string internal_string = "internal";
        internal protected string internalProtected_string = "internal protected";
        public string public_string = "public";
        protected string protected_string = "protected";
    }

    class OpenClasePrinciple
    {
        // genom private set kan man inte Set:a en property utanför
        internal int MyProperty { get; private set; }
        internal int MyProperty2 { get; private set; }

        public OpenClasePrinciple(int myProperty, int myProperty2)
        {
            this.MyProperty = myProperty;
            this.MyProperty2 = myProperty2;
        }
    }
}
