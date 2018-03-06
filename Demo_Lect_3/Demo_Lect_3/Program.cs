using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Lect_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1, c2;
            c1 = new Circle();
            c2 = new Circle(5);
            c1.SetRadius(10);
            Console.WriteLine(c1.Area());
            Console.WriteLine(c2.Area());
            Console.WriteLine($"{Circle.GetCirclesCount()} circles created");
            //Circle c;
            //c = new Circle();
            //c.SetRadius(5);
            //Console.WriteLine($"The area of circle is {c.Area()}");
            //Circle[] circles = new Circle[5];
            //for(int i=0; i<circles.Length; i++)
            //{
            //    circles[i] = new Circle();
            //    circles[i].SetRadius(i + 1);
            //}
            //foreach(var circle in circles)
            //    Console.WriteLine($"Circle with area {circle.Area()}");


            //Circle c2 = new Circle(45);

            Car myCar = new Car("Citroen C5", 2009);
            myCar.WriteLine();
            //myCar.Age = 5;
            GC.Collect();


            //Math m = new Math();
            //double d = m.Sqrt(42.24);

            var anonymousPerson = new { Name = "Ivan", Age = 23 };
            var anonymousPerson2 = new { Name = "John", Age = 46 };
            anonymousPerson = anonymousPerson2;


            Console.WriteLine($"{anonymousPerson.Name} {anonymousPerson.Age}");


            Console.ReadKey();
        }
    }
}
