using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration1
{
    class StockItem
    {
        int id;
        string name;
        static int stockCount;

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public int StockCount
        {
            get
            {
                return stockCount;
            }
            set
            {
                if (value >= 0 && value <= 5000)
                    stockCount = value;
                else
                    throw new Exception("Fel värde");
            }
        }
        public override string ToString() => $"Namn {Name}\n\rID: {Id}\n\rAntal: {StockCount}\n\r";

    }
}
