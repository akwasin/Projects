using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Radio
    {
        private int volym;
        private double frequency;
        private bool isOn;
        static int instanceCount;
        //private bool tuner;
        //private bool cd;


        public int Volym
        {
            get
            {
                return volym;
            }

            set
            {
                var volymVal = value >= 0 && value <= 100;
                if (volymVal)
                    volym = value;
                else
                {
                    throw new Exception("Your outside of the volume scope");
                }
            }
        }

        public double Frequency
        {
            get
            {
                return frequency;
            }

            set
            {
                var frequencyVal = value >= 89.0 && value <= 110.0;
                if (frequencyVal)
                    frequency = value;
                else
                {
                    throw new Exception("Your outside of the volume scope");
                }

            }
        }

        public bool IsOn
        {
            get
            {
                return isOn;
            }

            set
            {
                isOn = value;
                #region
                //if (value == true)
                //{
                //    Tuner = true;
                //    Cd = false;
                //}
                //else
                //{
                //    Tuner = false;
                //    Cd = false;
                //}
                #endregion
            }
        }

        public string RadioState
        {
            get
            {
                return isOn ? "På" : "Av";
            }
        }
        //public bool Tuner
        //{
        //    get {return tuner; }

        //    set { value = !cd; }
        //}

        //public string TunerState
        //{
        //    get
        //    {
        //        return tuner ? "Av" : "På";
        //    }
        //}

        //public bool Cd
        //{
        //    get { return cd; }

        //    set { tuner = !value; }
        //}

        //public string CDState
        //{
        //    get
        //    {
        //        return cd ? "På" : "Av";
        //    }
        //}

        public int InstanceCount
        {
            get { return instanceCount; } 
        }

        static Radio()
        {
            instanceCount = 0;
        }

        public Radio()
        {
            frequency = 89.0;
            instanceCount++;
        }

        public Radio(int volym, bool isOn) : this()
        {
            this.Volym = volym;
            this.IsOn = isOn;
        }

        public Radio(int volym, double frequency, bool isOn) : this(volym, isOn)
        {
            this.Frequency = frequency;
        }

        //public Radio(int volym, double frequency, bool isOn, bool tuner, bool cd) : this(volym, isOn)
        //{
        //    this.Frequency = frequency;
        //    this.Tuner = tuner;
        //    this.Cd = cd;
        //}

        //public Radio(int _volym = 80, double frequency = 100.5, bool _onOff = true, bool _tuner = true, bool _cd = false) // HiFi system
        //{
        //    this.Volym = _volym;
        //    this.Frequency = frequency;
        //    this.OnOff = _onOff;
        //    this.Tuner = _tuner;
        //    this.Cd = _cd;
        //}

        public override string ToString() => $"Your radio is {RadioState}. Last set frequency used is {frequency} and the volyme is set to {volym}. The program contains {instanceCount} instances of Radio";

        #region
        //public override string ToString() => $"Your radio is {RadioState} which means that the tuner is {TunerState} and the cd is {CDState}. Last set frequency settig is {frequency} and volyme set to {volym}. The program contains {instanceCount} instances of Radio";
        #endregion
    }
}
