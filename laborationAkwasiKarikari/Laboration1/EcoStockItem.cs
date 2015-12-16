using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration1
{
    class EcoStockItem : StockItem
    {
        private string markningTyp;

        public string MarkningTyp
        {
            get
            {
                
                return markningTyp;
            }

            set
            {
                var markningVal = value == "Krav" || value == "krav" || value == "EG" || value == "eg";
                if (value != null && markningVal)
                    markningTyp = value;
                else
                    throw new Exception("Wrong value!");
            }
        }
        public override string ToString()
        {
            return $"Märkning: {markningTyp} " + base.ToString();
        }
    }
}
