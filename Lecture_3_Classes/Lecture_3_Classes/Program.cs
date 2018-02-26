using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_3_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c;
            c = new Circle();
            c.SetRadius(5);
            Console.WriteLine($"The area of circle is {c.Area()}");

            Circle d = new Circle(45);
 
            Circle[] circles = new Circle[5];
            for(int i=0; i<circles.Length; i++)
            {
                circles[i] = new Circle();
                circles[i].SetRadius(i + 1);
            }
            foreach(var circle in circles)
                Console.WriteLine($"Circle with area {circle.Area()}");

            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
