using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration1
{
    class Stock
    {
        StockItem[] stockItem = new StockItem[10];

        // add item metod som håller sig inom ramarna
        public StockItem[] StockItem
        {
            get
            {
                return stockItem;
            }
        }
    }
}
