using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Lect_14
{
    class Program
    {
        static void Print(params object[] args)
        {
            foreach(var a in args)
                Console.WriteLine(a);
        }
        static void Main(string[] args)
        {
            Vector A = new Vector(4, 5);
            Vector B = new Vector(1, 2);
            Vector C = A + B;
            Console.WriteLine($"{A}+{B}={C}");
            Console.WriteLine($"{A}-{B}={A-B}");
            if(A==B)
                Console.WriteLine("Векторите съвпадат");

            Person p1 = new Person("Ivan", 1990);
            Person p2 = new Person("Stefan", 1996);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            if(p1>p2)
                Console.WriteLine($"{p1.Name} is older");
            //Stack<int> intStack = new Stack<int>();
            //intStack.Push(1);
            //intStack.Push(2);
            //intStack.Push(3);
            //try
            //{
            //    while (true)
            //    {
            //        Console.WriteLine(intStack.Pop());
            //    }
               
            //}
            //catch(InvalidOperationException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            Console.ReadKey();   
        }
    }
}
