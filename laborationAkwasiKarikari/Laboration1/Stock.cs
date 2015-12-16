using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration1
{
    class Stock
    {
        public int counter = 0;
        public StockItem[] stockItems = new StockItem[50];
        public StockItem this[int index]
        {
            get { return stockItems[index];  }
            set { stockItems[index] = value; }
        }

        public void AddStockItem(StockItem item)
        {
            if (counter < stockItems.Length)
            {
                this[counter] = item;
                counter++;
            }
        }

        public StockItem GetItem(int id)
        {
            return stockItems[id];
        }
    }
}
