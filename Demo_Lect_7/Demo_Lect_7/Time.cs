using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Lect_7
{
    public struct Time
    {
        public int hours;
        public int minutes;
        public int seconds;
        public override string ToString() => string.Format("{0:D2}:{1:D2}:{2:D2}", hours, minutes, seconds);
    }
}
