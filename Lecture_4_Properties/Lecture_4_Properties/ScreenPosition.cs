using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_4_Properties
{
    class ScreenPosition
    {
        private int x, y;
        public ScreenPosition(int x, int y)
        {
            this.x = rangeCheckedX(x);
            this.y = rangeCheckedY(y);
        }
        public int X
        {
            get => x;
            set => x = rangeCheckedX(value);
        }
        public int Y
        {
            get => y;
            set => y = rangeCheckedY(value);
        }
        private static int rangeCheckedX(int x) => (x >= 0 && x <= 1920) ? x : throw new ArgumentOutOfRangeException("X", "argument is out of range");
        private static int rangeCheckedY(int y) => (y >= 0 && y <= 1080) ? y : throw new ArgumentOutOfRangeException("Y", "argument is out of range");
    }
}
