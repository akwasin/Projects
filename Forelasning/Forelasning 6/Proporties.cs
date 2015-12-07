using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Forelasning_6
{
    class TableCon
    {
        private int chairs;
        private string color;

        public int GetChairs() { return chairs; }
        public void SetChairs(int chairs) { this.chairs = chairs; }

        public string GetColor() { return color; }
        public void SetColor(string color) { this.color = color; }
        
    }

    class TableProp
    {
        int chairs;
        string color;

        public TableProp(int chairs = 4, string color = "wood")
        {
            this.Chairs = chairs;
            this.color = color;
        }

        public int Chairs
        {
            get
            {
                return chairs;
            }

            set
            {
                chairs = value;
            }
        }
    }

    class BiCycle
    {
        private int gears;
        private string brand;

        public int Gears
        {
            get
            {
                return gears;
            }

            set
            {
                gears = value;
                if (value >= 0 && value <= 30 && value != 1)
                {
                    gears = value;
                }
                else
                {
                    throw new Exception("Invalid number");
                }
            }
        }

        public string Brand
        {
            get
            {
                return brand;
            }

            set
            {
                brand = value;
                if (value != null && value.Length >= 3)
                {
                    brand = value;
                }
                else
                {
                    throw new Exception("Invalid number");
                }
            }
        }
    }
    class Properties
    {
        private int lives; // backing field
        private string name;
        private string jaa;

        public string Namn
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
                if (value != null)
                {
                    name = value;
                }
                else
                {
                    name = "default";
                }
            }
        }

        public int Lives // property
        {
            get
            {
                return lives;
            }
            set
            {
                if (value >= 0) // kan sätta villkor
                    lives = value; // istället för inparameter
            }
        }
    }
}
