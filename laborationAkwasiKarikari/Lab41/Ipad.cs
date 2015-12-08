using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Ipad : interfaceInput
    {
        private string color;
        private double screenSize;
        private double processorSpeed;
        private string operatingSys;
        private int battery;
        private bool fourGee;
        static int antalPlattor;

        public string Color
        {
            get
            {
                return color;
            }

            set
            {
                var colorVal = value == "black" || value == "white" || value == "gold";
                if (colorVal)
                color = value;
                else
                {
                    throw new Exception("Invalid color choice");
                }
            }
        }

        public double ScreenSize
        {
            get
            {
                return screenSize;
            }

            set
            {
                var screenSizeValue = value >= 2.8 && value <= 5.0;
                if (screenSizeValue)
                screenSize = value;
                else
                {
                    throw new Exception("Invalid screensize. Redo entry");
                }
            }
        }

        public double ProcessorSpeed
        {
            get
            {
                return processorSpeed;
            }

            set
            {
                if (value >= 4.2 && value <= 5.0)
                processorSpeed = value;
                else
                {
                    throw new Exception("Invalid processor speed. Please try again");
                }
            }
        }

        public string OperatingSys
        {
            get
            {
                return operatingSys;
            }

            set
            {
                if (value == "OS6" || value == "OS7" || value == "OS8" || value == "OS9")
                { 
                operatingSys = value;
                }
                else if (value == "OS3" || value == "OS4" || value == "05")
                {
                    throw new Exception("iPad doesnt support this OS");
                }
                
                 else
                {
                    throw new Exception("Invalid OS version");
                }
            }
        }

        public int Battery
        {
            get
            {
                return battery;
            }

            set
            {
                var batterVal = value >= 1 && value <= 100;
                if (batterVal)
                battery = value;
                else
                {
                    throw new Exception("Your battery is either overheated(dead) or dead");
                }
            }
        }

        public bool FourGee
        {
            get
            {
                return fourGee;
            }

            set
            {
                fourGee = value;
            }
        }

        public string FourGeeState
        {
            get
            {
                return fourGee ? "with 4G" : "without 4G";
            }
        }

        static int Plattor
        {
            get
            {
                return antalPlattor;
            }

        }

        public Ipad ()
        {
            color = "white";
            battery = 100;
            screenSize = 4;
            processorSpeed = 4.5;
            operatingSys = "OS9";
            fourGee = false;
            antalPlattor++;
        }

        public Ipad (int battery, double screenSize, double processorSpeed) : this()
        {
            this.Battery = battery;
            this.ScreenSize = screenSize;
            this.ProcessorSpeed = processorSpeed;
        }

        public Ipad (int battery, double screenSize, double processorSpeed, string color, bool fourGee, string operatingSys) : this (battery, screenSize, processorSpeed)
        {
            this.Color = color;
            this.FourGee = fourGee;
            this.OperatingSys = operatingSys;
        }

        public Ipad (string inputTouch, string thunderBolt, bool wifiOn, bool bluetoothOn) : this ()
        {
            //this.InputTouch = inputTouch;
            //this.ThunderBolt = thunderBolt;
            this.WifiOn = wifiOn;
            this.BluetoothOn = bluetoothOn;
            this.ThunderBolt = thunderBolt;

        }
        public override string ToString() => $"This is your new {color} iPad. It has {screenSize} inches across the screen and a processing speed of {processorSpeed}. Your model is {FourGeeState}. Your battery is per default set to {battery}% and comes with {operatingSys} pre installed.\n\rInterfaces:\n\r{InputTouch}\n\r{ThunderBolt}\n\r{WifiState}\n\r{BluetoothState}\n\r ";
    }
}
