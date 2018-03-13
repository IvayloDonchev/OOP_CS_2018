using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Lect_4
{
    public class ReadOnlyPoint
    {
        public int X { get; }
        public int Y { get; }
        public ReadOnlyPoint(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
