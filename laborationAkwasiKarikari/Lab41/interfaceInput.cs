using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class interfaceInput
    {
        private string inputTouch;
        private string thunderBolt;
        private bool wifiOn;
        private bool bluetoothOn;

        public string InputTouch { get; internal set; } = "Has Touch";
        /*public string InputTouch
        {
            get{ return inputTouch; }
            set{ inputTouch = value; }
        }*/ 
        
        /* public string ThunderBolt
        {
            get { return thunderBolt; }
            set { thunderBolt = value; }
        }*/

        public string ThunderBolt { get; internal set; } = "Has Thunderbolt";

        public bool WifiOn
        {
            get { return wifiOn; }

            set { value = false; }
        }

        public string WifiState
        {
            get { return wifiOn ? "No WiFi" : "Has WiFi"; }
        }


        public bool BluetoothOn
        {
            get { return bluetoothOn; }

            set { value = true; }
        }

        public string BluetoothState
        {
            get
            {
                return bluetoothOn ? "No Bluetooth" : "Has Bluetooth";
            }
        }
    }
}
