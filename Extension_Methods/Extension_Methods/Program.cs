using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods
{
    public static class Util
    {
        public static int Negate(this int x)
        {
            return -x;
        }
        public static string ConvertToBase(this int i, int baseToConvertTo)
        {
            string result = "";
            do
            {
                int nextDigit = i % baseToConvertTo;
                i /= baseToConvertTo;
                if (nextDigit < 10)
                    result = nextDigit.ToString() + result;
                else
                    result = (char)('A' + (nextDigit - 10)) + result;
            } while (i != 0);
            return result;
        }
    }
    class Program
    {
        static void doWork(int x)
        {
            for(int i=2; i<=16; i++)
                Console.WriteLine($"{x} in base {i} is {x.ConvertToBase(i)}");
        }
        static void Main(string[] args)
        {
            int i = 10;
            Console.WriteLine(i.Negate());

            int x = Convert.ToInt32(Console.ReadLine());
            try
            {
                doWork(x);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
