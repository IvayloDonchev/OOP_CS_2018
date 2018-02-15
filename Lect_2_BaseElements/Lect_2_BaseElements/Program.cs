using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect_2_BaseElements
{
    class Program
    {
        static int MaxValue(int[] intArray)
        {
            int max = intArray[0];
            for(int i=1; i<intArray.Length; i++)
            {
                if (intArray[i] > max)
                    max = intArray[i];
            }
            return max;
        }
        static void Main(string[] args)
        {
            int[] myArray = { 1, 8, 3, 6, 2, 5, 9, 3, 0, 2 };
            int maxVal = MaxValue(myArray);
            Console.WriteLine($"The maximum value in myArray is {maxVal}");
            Console.WriteLine($"{MaxValue(new int[] { 1, 8, 3, 6, 2, 5, 9, 3, 0, 2 })}");


            List<int> myList = new List<int> { 1, 8, 3, 6, 2, 5, 9, 3, 0, 2 };
            maxVal = MaxValue(myList);
            Console.WriteLine($"The maximum value in myList is {maxVal}");

            Console.ReadKey();
        }
        static T MaxValue<T>(IEnumerable<T> list) where T : IComparable 
        {
            T max = list.First();
            foreach (var x in list)
                if (x.CompareTo(max)>0)
                    max = x;
            return max;
        }
    }
}
