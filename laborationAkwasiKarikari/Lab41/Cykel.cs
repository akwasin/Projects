using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Cykel : Hjul
    {
        private string marke;
        private string farg;
        private string componenter;
        private int vaxlar;
        private bool sadel;
        private bool ringKlocka;
        private string typ;
        static int antalCyklar;

        public string Marke
        {
            get
            {
                return marke;
            }

            set
            {
                if (value.Length > 1)
                    marke = value;
                else
                    throw new Exception("Fyll i ett märke");
            }
        }

        public string Typ
        {
            get
            {
                return typ;

            }
            set
            {
                var typValue = value == "herrcykel" || value == "damcykel" || value == "mountainbike" || value == "racer" || value == "bmx";
                if (typValue)
                {
                    value = Typ;
                }
                else
                {
                    throw new Exception("Fyll i en typ av cykel");
                }
            }

        }
        public string Farg
        {
            get
            {
                return farg;
            }

            set
            {
                if (value.Length >= 3)
                    farg = value;
                else
                    throw new Exception("Fyll i en giltig färg");
            }
        }

        public string Componenter
        {
            get
            {
                return componenter;
            }

            set
            {
                if (value.Length >= 6)
                    componenter = value;
                else
                    throw new Exception("Fyll i ett giltigt märke på dina komponenter");
            }
        }

        public int Vaxlar
        {
            get
            {
                return vaxlar;
            }

            set
            {
                var vaxlarVal = value >= 0 && value <= 21;
                if (vaxlarVal)
                    vaxlar = value;
                else
                    throw new Exception("Ditt antal växlar stämmer inte");
            }
        }

        public bool Sadel
        {
            get
            {
                return sadel;
            }

            set
            {
                if (sadel == false)
                    throw new Exception("Har du ingen sadel eller?");
                else
                    sadel = value;
            }
        }

        static int AntalCyklar
        {
            get
            {
                return antalCyklar;
            }

        }

        public bool RingKlocka
        {
            get
            {
                return ringKlocka;
            }

            set
            {
                if (value == true)
                { 
                ringKlocka = value;
                Console.Beep(5000, 2000);
                value = false;
                }
                else
                {
                    throw new Exception("Ring eller ring inte");
                }
            }
        }

        public Cykel()
        {
            antalCyklar++;
        }

        public Cykel(string marke, string typ, string farg, string componenter, int vaxlar, bool sadel, int antalHjul, int hjulStorlek, bool ringklocka)
        {
            this.Marke = marke;
            this.Typ = typ;
            this.Farg = farg;
            this.Componenter = componenter;
            this.Vaxlar = vaxlar;
            this.Sadel = sadel;
            this.AntalHjul = antalHjul;
            this.HjulStorlek = hjulStorlek;
            this.RingKlocka = ringKlocka;
        }

        public override string ToString() => $"Din beställning: \r\n Märke: {marke} \r\n Typ: {typ} \r\n Färg: {farg} \r\n Componenter: {componenter} \r\n Sadel: {sadel} \r\n Hjulstorlek: {hjulStorlek} \r\n";
    }
}
