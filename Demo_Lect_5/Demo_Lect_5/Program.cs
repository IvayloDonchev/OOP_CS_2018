using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Lect_5
{
    class Program
    {
        static void ResizeCircle(Circle c, int radius)
        {
            c.SetRadius(radius);
        }
        static void Swap(ref Circle a, ref Circle b)
        {
            Circle t = a;
            a = b;
            b = t;
        }
        static int Sum(int a, int b) => a + b;
        static void Main(string[] args)
        {
            
            Circle c = new Circle(10);
            Circle copy=null;
            //copy.SetRadius(15);

            
            int? i = null;     // OK
            int j = 99;
            i = 100;
            i = j - 89;
            Console.WriteLine($"i = {i}");

            j = (int)i;  

            int s = Sum((int)i, j);

            if (i.HasValue)
                Console.WriteLine($"i = {i.Value}");
            else
                i = 99;




            if (i==null)
                Console.WriteLine("i is null");
            else
                Console.WriteLine($"i = {i}");




           





            //Circle c1 = new Circle(1),
            //       c2 = new Circle(10);
            //Swap(ref c1, ref c2);
            //Console.WriteLine($"c1: {c1}");
            //Console.WriteLine($"c2: {c2}");



            //int Console.WriteLine($"c1: {c1}"); i = 42;
            //int copy_i = i;
            //i++;
            //Console.WriteLine($"i = {i}, copy_i = {copy_i}");

            //Circle c = new Circle(42);
            //Circle ref_c = c;
            //ref_c.SetRadius(10);
            //Console.WriteLine($"c: {c}, \nref_c: {ref_c}");

            //Circle copy_c = new Circle(c);
            //copy_c.SetRadius(50);
            //Console.WriteLine($"c: {c}, \ncopy_c: {copy_c}");

            //ResizeCircle(c, 1);
            //Console.WriteLine($"c: {c}");

        }
    }
}
