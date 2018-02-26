using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_3_Classes
{
    public class Circle
    {
        public Circle(int r) => radius = r;
        public Circle() : this(0) {}
        private int radius;
        public void SetRadius(int r)
        {
            if (r > 0)
                radius = r;
            else
                throw new ArgumentOutOfRangeException("Incorrect radius value");
        }
        public double Area()
        {
            return Math.PI * radius * radius;
        }
    }
}
