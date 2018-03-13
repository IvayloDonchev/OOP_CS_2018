using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Lect_4
{
    public class Line
    {
        private Point A, B;
        public double Length => A.DistanceTo(B);
        public Line(Point p1, Point p2)
        {
            A = new Point(p1.X, p1.Y);
            B = new Point(p2.X, p2.Y);
        }
        public Line(double x1, double y1, double x2, double y2)
        {
            A = new Point(x1, y1);
            B = new Point(x2, y2);
        }
        public override string ToString()
        {
            return $"Line from point {A} to point {B}";
        }

    }
}
