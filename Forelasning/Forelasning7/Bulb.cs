using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning7
{
    class Bulb
    {
        private int hue;
        private byte saturation;
        private byte lightness;

        public int Hue
        {
            get
            {
                return hue;
            }

            set
            {
                var hueValue = value >= 0 && value <= 360;
                if (hueValue)
                    hue = value;
                else
                {
                    throw new Exception("Decrese the Hue");
                }
            }
        }

        public byte Saturation
        {
            get
            {
                return saturation;
            }

            set
            {
                var saturationValue = value >= 0 && value <= 100;
                if (saturationValue)
                    saturation = value;
                else
                {
                    throw new Exception("Decrese the Saturation");
                }
            }
        }

        public byte Lightness
        {
            get
            {
                return lightness;
            }

            set
            {
                var lightnessValue = value >= 0 && value <= 100;
                if (lightnessValue)
                    lightness = value;
                else
                {
                    throw new Exception("Decrese the Lightness");
                }
            }
        }

        public Bulb(int hue, byte saturation = 50, byte lightness = 50)
        {
            this.Hue = hue;
            this.Saturation = saturation;
            this.Lightness = lightness;
        }

        // c# 6.0 syntax
        public override string ToString() => $"Bulbs settings are: Hue: {hue}, Saturation: {saturation}, Lightness: {lightness}";

        //public override string ToString()
        //{
        //    return $"Bulb has the following settings: Hue: {hue}, Saturation: {saturation}, Lightness: {lightness}";
        //}
    }
}
