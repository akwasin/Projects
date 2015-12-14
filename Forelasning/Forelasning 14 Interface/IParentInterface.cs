using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_14_Interface
{
    internal interface IParentInterface
    {
        void ParentMethod();
    }

    interface IChildInterface : IParentInterface
    {
        void ChildMethod();
    }
}
