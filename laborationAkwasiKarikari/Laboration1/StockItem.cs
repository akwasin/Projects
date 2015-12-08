using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration1
{
    class StockItem
    {
        private int id;
        private string name;
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
                    throw new Exception("Wrong Value");
            }
        }


        //static StockItem()
        //{
        //    stockCount = 0;
        //}
        public StockItem(string name, int id, string markning)
        {
            this.Name = name;
            this.Id = id;
            stockCount++;
        }

        public StockItem()
        {
        }

        public override string ToString() => $"Name {Name}\n\rID: {Id}\n\rAntal: {StockCount}";

    }
}
