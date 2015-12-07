using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning
{
    class flygplan
    {
        private int hjul;

        public int GetHjul()
        {
            return hjul;
        }
        public void SetHjul(int hjul)
        {
            this.hjul = hjul;
        }

        internal string printPlane()
        {
            return $"Flygplanet har {this.GetHjul()} hjul";
        }
    }
}
