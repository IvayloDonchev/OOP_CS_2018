using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector A = new Vector(5, 10);
            Vector B = new Vector(-5,10);
            Console.WriteLine(A==B);   //true
            Vector C = A + B;
            Console.WriteLine($"{A}+{B}={C})");
            Console.WriteLine(C==A);
            Console.WriteLine(C!=A);

            Person p1 = new Person("Ivaylo", 1971);
            Person p2 = new Person("Victoria", 2002);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            if(p1>p2)
                Console.WriteLine($"{p1.Name} is older");


            void Swap<T>(ref T x, ref T y)
            {
                T buf = x;
                x = y;
                y = buf;
            }
            int a=5, b = 10;
            Swap(ref  a, ref b);

            Stack<int> intStack = new Stack<int>();
            intStack.Push(1);
            intStack.Push(2);
            intStack.Push(3);
            int res = intStack.Pop();
            Console.WriteLine(res);

            Queue<int> intQueue = new Queue<int>();
            intQueue.Enqueue(1);
            intQueue.Enqueue(2);
            intQueue.Enqueue(3);
            res = intQueue.Dequeue();
            Console.WriteLine(res);

            Dictionary<string, int> ages = new Dictionary<string, int>();
            ages.Add("Doroteya", 41);
            ages.Add("Ivaylo", 46);
            ages["Victoria"] = 15;
            ages["Petar"] = 9;
            foreach(var element in ages)
            {
                Console.WriteLine($"Name: {element.Key}, Age: {element.Value}");
            }

            var stringCollection = new SampleCollection<string>();
            stringCollection[0] = "Hello World!";
            Console.WriteLine(stringCollection[0]);
            foreach(var x in stringCollection)
                if(x != null) Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
