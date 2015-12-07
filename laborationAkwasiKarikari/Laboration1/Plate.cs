using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration1
{
    class Plate : StockItem
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
                if (value == "Flat" || value == "Deep" && value !=null )
                typ = value;
                else
                {
                    throw new Exception("Wrong value!");
                }
            }
        }
    }
}
