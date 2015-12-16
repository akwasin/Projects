using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration1
{
    class Juice : EcoStockItem
    {
        private string juiceTyp;

        public string JuiceTyp
        {
            get { return juiceTyp; }

            set
            {
                var typValue = value == "Apple" || value == "apple" || value == "Orange" || value == "orange";
                if (value != null && typValue)
                    juiceTyp = value;
                else
                    throw new Exception("Fel typ, prova igen");
            }
        }

        public override string ToString()
        {
            return $"Typ: {juiceTyp} " + base.ToString();
        }
    }
}
