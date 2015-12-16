using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration1
{
    class CreateProduct
    {
        string[] product = new string[10];

        public string Product {

            get { return product[1]; }
            set { for (int i = 0; i<product.Length; i++)
            {
                product[i] = value;
            }
            }

        }
   
}
}
