using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Hjul
    {
        public int antalHjul;
        public double hjulStorlek;

        public int AntalHjul
        {
            get
            {
                return antalHjul;
            }

            set
            {
                antalHjul = value;
            }
        }

        public double HjulStorlek
        {
            get
            {
                return hjulStorlek;
            }

            set
            {
                var hjulStorlekValue = value >= 25.5 && value <= 30.0;
                if (hjulStorlekValue)
                hjulStorlek = value;
                else
                {
                    throw new Exception("Fyll i en giltig storlek på hjulen");
                }
            }
        }
    }
}
