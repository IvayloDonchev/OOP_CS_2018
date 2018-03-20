using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Lect_5
{
    public class Circle
    {
        private int radius;
        public int Diameter => radius * 2; //read-only property
        public Circle() : this(0) { }
        public Circle(int radius)
        {
            this.SetRadius(radius);
        }
        public double Area => Math.PI * radius * radius;
        public void SetRadius(int radius)
        {
            if (radius > 0)
                this.radius = radius;
            else
                throw new ArgumentOutOfRangeException("Incorrect radius value");
        }
        public override string ToString() => $"Circle with radius {this.radius} and area {Math.Round(this.Area,3)}";
        public static Circle CreateCircle() => new Circle();
    }
}
