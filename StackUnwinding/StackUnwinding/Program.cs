﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUnwinding
{
    public class MyException : Exception
    {
        public MyException(string message) : base(message)
        { }
    }
    class Program
    {
        static void Function1()
        {
            Console.WriteLine("Function1() извиква Function2()");
            Function2();
            Console.WriteLine("Този текст не трябва да се изведе на екрана");
        }
        static void Function2()
        {
            try
            {
                Console.WriteLine("Function2() извиква Function3()");
                Function3();
                Console.WriteLine("Този текст не трябва да се изведе на екрана");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Изключението е прихванато в Function2() и се препраща за по-нататъшна обработка");
                throw;
            }
        }
        static void Function3()
        {
            Console.WriteLine("Във Function3()");
            throw new MyException("Изключение, генерирано във Function3()");
            Console.WriteLine("Този текст не трябва да се изведе на екрана");
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Main() извиква Function1()");
                Function1();
            }
            catch(Exception e)
            {
                Console.WriteLine($"Изключението от тип {e.GetType().Name} се обработва в Main()");
            }
            Console.ReadKey();
        }
    }
}
