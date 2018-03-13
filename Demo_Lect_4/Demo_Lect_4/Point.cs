using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Lect_4
{
    public class Point
    {
        private double x, y;
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public Point() : this(0.0, 0.0) { }
        public void SetPoint(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString() => $"({x},{y})";
        public double DistanceTo(Point p) => Math.Sqrt(Math.Pow(x - p.x, 2) + Math.Pow(y - p.y, 2));
        public double X => x;   //read-only property
        public double Y => y;
    }
}
