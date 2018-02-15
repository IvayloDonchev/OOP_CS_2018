using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref_out_parameters
{
    class Program
    {
        static void Swap(ref int x, ref int y)
        {
            int t = x;
            x = y;
            y = t;
        }
        static int MaxValue(int[] intArray, out int maxIndex)
        {
            int max = int.MinValue;
            maxIndex = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] > max)
                {
                    max = intArray[i];
                    maxIndex = i;
                }
            }
            return max;
        }
        static ref int MaxValue(int[] intArray)
        {
            int maxIndex = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] > intArray[maxIndex])
                    maxIndex = i;
            }
            //----------------------
            return ref intArray[maxIndex];
        }
        static void Main(string[] args)
        {
            int a = 5, b = 10;
            Swap(ref a, ref b);
            Console.WriteLine($"a = {a}, b = {b}");

            int[] myArray = { 1, 8, 3, 6, 2, 5, 9, 3, 0, 2 };
           // int maxIndex;
            Console.WriteLine($"The maximum is {MaxValue(myArray, out int maxIndex)}");
            Console.WriteLine($"The first occurance of this value is at pos {maxIndex+1}");

            myArray[maxIndex] = 100;
            foreach(var e in myArray)
                Console.Write($"{e} ");
            Console.WriteLine();

            ref int maximum = ref MaxValue(myArray);
            Console.WriteLine($"The maximum is {maximum}");
            maximum = 200;
            foreach (var e in myArray)
                Console.Write($"{e} ");
            Console.WriteLine();

            Console.WriteLine($"The maximum is {MaxValue(myArray)}");
            int max = MaxValue(myArray);

            MaxValue(myArray) = 300;
            foreach (var e in myArray)
                Console.Write($"{e} ");
            Console.WriteLine();

            // Именувани аргументи
            DisplayGreeting(lastName: "Donchev", firstName: "Ivaylo");

            Console.ReadKey();
        }
        public static void DisplayGreeting(
            string firstName,
            string middleName = default,
            string lastName = default)
        {
            Console.WriteLine($"Hello, {firstName} {middleName} {lastName}!");
        }

    }
}
