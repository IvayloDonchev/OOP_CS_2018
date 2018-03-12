using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_4_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            ScreenPosition pos = new ScreenPosition(50, 150);
            Console.WriteLine($"point at possition ({pos.X},{pos.Y})");

            pos.X = 100;
            pos.Y = 200;
            Console.WriteLine($"point at possition ({pos.X},{pos.Y})");

            Console.ReadKey();
        }
    }
}
