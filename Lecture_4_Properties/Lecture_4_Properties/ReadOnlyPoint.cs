using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_4_Properties
{
    class ReadOnlyPoint
    {
        public int X { get; }
        public int Y { get; }
        public ReadOnlyPoint(int x, int y)
        {
            X = x; Y = y;
        }
        public void Deconstruct(out int x, out int y)
        {
            x = X;
            y = Y;
        }
    }
}
