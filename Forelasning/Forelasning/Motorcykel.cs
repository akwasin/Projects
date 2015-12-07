using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning
{
    class Motorcykel
    {
        private int horsePower;
        private int maxSpeed;

        public int GetHorsepower()
        {
            return horsePower;
        }
        public void SetHorsePower(int horsePower)
        {
            this.horsePower = horsePower;
        }

        public int GetMaxSpeed()
        {
            return maxSpeed;
        }
        public void SetMaxSpeed(int maxSpeed)
        {
            this.maxSpeed = maxSpeed;
        }
    }
}
