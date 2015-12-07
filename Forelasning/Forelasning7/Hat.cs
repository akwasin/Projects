using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning7
{
    class Hat
    {
        private string color;
        private string material;
        private double circumference;

        public string Color
        {
            get
            {
                return color;
            }

            set
            {
                var colorValue = value.Length >= 3 && value.Length <= 1200;
                if (colorValue)
                    color = value;
                else
                {
                    throw new Exception("That is not a valid color");
                }
            }
        }

        public string Material
        {
            get
            {
                return material;
            }

            set
            {
                var materialValue = value.Length >= 2 && value.Length <= 1200;
                if (materialValue)
                    material = value;
                else
                {
                    throw new Exception("That is not a valid material");
                }
            }
        }

        public double Circumference
        {
            get
            {
                return circumference;
            }

            set
            {
                var circumferenceValue = value >= 52 && value <= 62;
                if (circumferenceValue)
                    circumference = value;
                else
                {
                    throw new Exception("That is not a hatsize");
                }
            }
        }

        public Hat(string color, string material, double circumference)
        {
            this.Color = color;
            this.Material = material;
            this.Circumference = circumference;
        }

        public override string ToString() => $"Your hat has the color {color}, is in the material {material} and in size {circumference}";
    }
}
