using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySortedCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Man m1 = new Man("Ivan Ivanov", new DateTime(1980, 10, 12));
            Man m2 = new Man("Georgi Georgiev", new DateTime(1990, 1, 15));
            Man m3 = new Man("Victor Stefanov", new DateTime(1991, 10, 10));
            Man m4 = new Man("Angel Dimitrov", 12, 5, 1992);
            Man[] array = new Man[] { m1, m2, m3, m4 };
            Array.Sort(array);
            foreach(var man in array)
                Console.WriteLine(man);

            List<Man> manList = new List<Man>() { m1, m2, m3, m4 };
            manList.Sort();
            Console.WriteLine();
            foreach (var man in manList)
                Console.WriteLine(man);

            Console.ReadKey();
        }
    }
}
