using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration1
{
    class EcoStockItem : StockItem
    {
        private string markning;

        public string Markning
        {
            get
            {
                
                return markning;
            }

            set
            {
                var ecoValue = value == "Krav" || value == "EG";
                if (value != null && ecoValue)
                    markning = value;
                else
                    throw new Exception("Wrong value!");
            }
        }
       public EcoStockItem(string markning) 
        {
            this.Markning = markning;
        }

    }
}
