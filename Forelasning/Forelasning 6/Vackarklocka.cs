using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_6
{
    class Vackarklocka
    {
        //static void Main(string[] args)
        //{
        //}

    }

    public class AlarmClock
    {
        private int seconds;       // default 0
        private int alarmSeconds;  // default 0
        private bool alarmOn;   // default false


        public void setTime(int hours, int minutes)
        {
            this.seconds = (hours * 3600 + minutes * 60);
        }

        public int GetTime()
        {
            return seconds;
        }

        public void SetAlarmTime(int hours, int minutes)
        {
            alarmSeconds = (hours * 3600 + minutes * 60);
        }

        public void TurnAlarmOnOff(bool isOn)
        {
            //this.alarmOn = alarmOn;
        }
    }

    /*
    - AlarmClock
	- time: int
	- alarmTime: int
	- alarmOn: bool
		
		+ SetTime(int hours, int minutes)
		+ GetTime(): int
		+ SetAlarm(int hours, int minutes)
		+ TurnAlarmOn(Bool isOn)*/
}