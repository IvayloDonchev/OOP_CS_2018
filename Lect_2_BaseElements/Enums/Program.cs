using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    enum Orientation : byte { North, South, East, West }
    class Program
    {
        static void Main(string[] args)
        {
            Orientation orientation = Orientation.North;
            Console.WriteLine(orientation);     // North
            orientation = (Orientation)2;
            Console.WriteLine(orientation);     // East
            orientation = Orientation.South;
            Console.WriteLine((byte)orientation); // 1

            Orientation myDirection = (Orientation)Enum.Parse(typeof(Orientation), "West");
            Console.WriteLine(myDirection);     // West
            Console.ReadKey();
        }
    }
}
