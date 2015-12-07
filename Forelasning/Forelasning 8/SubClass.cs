using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forelasning_7;

namespace Forelasning_8
{
    class SubClass : MyClass
    {     
        public void PrintAll() {

            // det här sättet fungerar också
            SubClass subClass = new SubClass();
            subClass.internal_string = "värde";

            base.public_string = "värde";
            base.internal_string = "värde";
        }
       
    }
}
