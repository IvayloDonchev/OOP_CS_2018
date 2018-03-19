using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Lect_4
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
        public Point() : this(0.0, 0.0) { }
        public void SetPoint(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
        public override string ToString() => $"({X},{Y})";
        public double DistanceTo(Point p) => Math.Sqrt(Math.Pow(X - p.X, 2) + Math.Pow(Y - p.Y, 2));
        public Point Clone() => new Point(this.X, this.Y);
        public void Deconstruct(out double a, out double b)
        {
            a = X; b = Y;
        }
    }
}
