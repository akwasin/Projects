using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övn_5
{
    class C : B
    {
        public C()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
}
