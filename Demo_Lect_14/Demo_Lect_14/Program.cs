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
        static void Main(string[] args)
        {
            Stack<int> intStack = new Stack<int>();
            intStack.Push(1);
            intStack.Push(2);
            intStack.Push(3);
            try
            {
                while (true)
                {
                    Console.WriteLine(intStack.Pop());
                }
               
            }
            catch(InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();   
        }
    }
}
