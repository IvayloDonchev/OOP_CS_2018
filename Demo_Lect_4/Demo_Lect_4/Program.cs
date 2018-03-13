using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Lect_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadOnlyPoint rop = new ReadOnlyPoint(1, 2);
            Console.WriteLine($"({rop.X},{rop.Y})");
            var fields = typeof(ReadOnlyPoint).GetFields(
                System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Instance);
            foreach(var field in fields)
                Console.WriteLine(field.Name);
            fields[0].SetValue(rop, 10);
            fields[1].SetValue(rop, 20);
            Console.WriteLine($"({rop.X},{rop.Y})");



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
