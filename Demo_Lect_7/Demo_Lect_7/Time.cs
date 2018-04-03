using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Lect_7
{
    public struct Time
    {
        private int hours, minutes, seconds;
        public int Hours { get => hours; set => hours = Math.Abs(value) % 24; }
        public int Minutes { get => minutes; set => minutes = Math.Abs(value) % 60; }
        public int Seconds { get => seconds; set => seconds = Math.Abs(value) % 60; }
        //private int hours;
        //private int minutes;
        //private int seconds;
        public Time(int hh, int mm, int ss=0)
        {
            this.hours = Math.Abs(hh) % 24;
            this.minutes = Math.Abs(mm) % 60;
            this.seconds = Math.Abs(ss) % 60;

        }
        public override string ToString() => string.Format("{0:D2}:{1:D2}:{2:D2}", hours, minutes, seconds);
    }
}
