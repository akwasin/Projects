using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Bil
    {
        private string marke;
        private int antalVaxlar;
        private string farg;
        private string typ;

        public string Marke
        {
            get
            {
                return marke;
            }

            set
            {
                var markeValue = value.Length >= 1 && value.Length <= 100; // svår att validera..
                if (markeValue)
                    marke = value;
                else
                {
                    throw new Exception("That is probably not a valid car brand");
                }
            }
        }

        public int AntalVaxlar
        {
            get
            {
                return antalVaxlar;
            }

            set
            {
                var antalValxarValue = value >= 0 && value <= 100;
                if (antalValxarValue)
                    antalVaxlar = value;
                else
                {
                    throw new Exception("That is not a valid number of gears");
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
                var fargValue = value.Length >= 2 && value.Length <= 30;
                if (fargValue)
                    farg = value;
                else
                {
                    throw new Exception("That is not a valid color");
                }         
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

                //string word = "File";
                //string[] others = { word.ToLower(), word, word.ToUpper(), "fıle" };
                //foreach (string other in others)
                //{
                //    if (word.Equals(other))
                //        Console.WriteLine("{0} = {1}", word, other);
                //    else
                //        Console.WriteLine("{0} {1} {2}", word, '\u2260', other);
                //}
                string kupe = "kupe";
                string kombi = "kombi";
                if (value.Equals(kupe) || value.Equals(kombi))
                //if (value == "kupe" || value == "kombi")
                    typ = value; 
                else
                {
                    throw new Exception("That is not a valid car type");
                }
            }
        }

        public Bil(string marke, int antalVaxlar, string farg, string typ)
        {
            this.Marke = marke;
            this.AntalVaxlar = antalVaxlar;
            this.Farg = farg;
            this.Typ = typ;
        }

        public override string ToString() => $"Your car is a {farg} {typ}, from {marke} and has {antalVaxlar} gears";
    }
}

/*

Skapa en klass kallad Bil, som har fälten marke, antalVaxlar, farg och typ. Skapa properties för fälten. I set-delen av propertien som manipulerar fältet typ ska du se till att endast värdena "kupe" eller "kombi" kan användas, i andra fall ska fältet inte ändras. Skapa instanser och prova att först sätta typ till "kombi", därefter till "suv", och läs ut vad typ har för värde.
*/
