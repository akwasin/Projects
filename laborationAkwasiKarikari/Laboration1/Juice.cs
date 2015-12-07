using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration1
{
    class Juice : EcoStockItem
    {
        private string typ;

        public string Typ
        {
            get
            {
                return typ;
            }

            set
            {
                var typValue = value == "Apple" || value == "Orange";
                if (value != null && typValue)
                    typ = value;
                else
                    throw new Exception("Wrong value!");
            }
        }
    }
}
