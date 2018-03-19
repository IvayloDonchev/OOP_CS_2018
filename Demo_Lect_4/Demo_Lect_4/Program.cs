using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Lect_4
{
    class Program
    {
        public static void Foo(ref double d)
        {
            d *= 2;
        }
        static void Main(string[] args)
        {
            Point A = new Point();
            Point B = new Point(5, 10);
            Console.WriteLine($"Point A: {A}");
            Console.WriteLine($"Point B: {B}");

            Line L = new Line(A, B);
            Console.WriteLine(L);
            Console.WriteLine($"Length: {L.Length}");

            A.SetPoint(1, 1);
            Console.WriteLine(L); //полетата на линията не са променени

            Line LL = new Line(1, 2, 3, 4);
            Console.WriteLine(LL);

            Point C = B.Clone();
            B.X = 100; B.Y = 200;
            Console.WriteLine($"B: {B}, C: {C}");
            (double xx, double yy) = B; //deconstruction to tuple
            Console.WriteLine($"xx = {xx}, yy = {yy}");

            //ReadOnlyPoint rop = new ReadOnlyPoint(1, 2);
            //Console.WriteLine($"({rop.X},{rop.Y})");
            //var fields = typeof(ReadOnlyPoint).GetFields(
            //    System.Reflection.BindingFlags.NonPublic |
            //    System.Reflection.BindingFlags.Instance);
            //foreach (var field in fields)
            //    Console.WriteLine(field.Name);
            //fields[0].SetValue(rop, 10);
            //fields[1].SetValue(rop, 20);
            //Console.WriteLine($"({rop.X},{rop.Y})");



            //ScreenPosition pos = new ScreenPosition(50, 150);
            //Console.WriteLine($"point at possition ({pos.X},{pos.Y})");
            //pos.X = 100;
            //pos.Y = 200;
            //Console.WriteLine($"point at possition ({pos.X},{pos.Y})");

            //Circle c = new Circle(1);
            //Console.WriteLine(c);

            Console.ReadKey();

        }
    }
}
