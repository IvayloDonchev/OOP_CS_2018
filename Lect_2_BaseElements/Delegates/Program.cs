using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        delegate double Calculation(double a);  // декларация на делегат
        static double Square(double x) => x * x;
        static void Proccess(Calculation calc, double arg)  // функция с аргумент делегат
        {
            Console.WriteLine(calc(arg));   // извикване на ф-я чрез променлива-делегат 
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the angle in degrees: ");
            double x = Convert.ToDouble(Console.ReadLine()) * Math.PI / 180;
            Proccess(Math.Sin, x);
            Proccess(Math.Cos, x);
            Console.WriteLine("Enter the number to square: ");
            x = Convert.ToDouble(Console.ReadLine());
            Proccess(Square, x);    // потребителската функция като параметър

            Calculation c;  // дефиниране на променлива-делегат
            c = n => 2 * n; // ламбда функция, която пасва на делегата
            Console.WriteLine(c(x));   // 2*x

            Console.ReadKey();

        }
    }
}
