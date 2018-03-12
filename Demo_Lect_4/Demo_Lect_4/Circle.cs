using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Lect_4
{
    public class Circle
    {
        static int circlesCount;
        private int radius;
        static Circle()  // статичен конструктор на инстантен клас
        {
            circlesCount = 0;
        }
        public Circle() : this(0) { }
        public Circle(int radius)
        {
            this.SetRadius(radius);
            circlesCount++;
        }
        ~Circle()
        {
            circlesCount--;
            Console.WriteLine($"Circle with radius {this.radius} destruction...");
        }
        public double Area()
        {
            return Math.PI * radius * radius;
        }
        public void SetRadius(int radius)
        {
            if (radius > 0)
                this.radius = radius;
            else
                throw new ArgumentOutOfRangeException("Incorrect radius value");
        }
        public override string ToString() => $"Circle with radius {this.radius}";
        public static Circle CreateCircle() => new Circle();
        public static int GetCirclesCount() => circlesCount;
    }
}
