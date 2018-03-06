using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Lect_3
{
    public class Car
    {
        string model;
        readonly int year; // година на производство
        public readonly int Age; // възрастта към настоящия момент
        public Car(string model, int year)
        {
            this.model = model;
            this.year = year;
            this.Age = DateTime.Now.Year - year;
        }
        public void WriteLine()
        {
            Console.WriteLine($"Car {this.model}, {this.year} ({ this.Age} years old)");
        }
    }
}
