using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_5_Val_Ref_Types
{
    class Program
    {
        public static void Swap(ref Circle c1, ref Circle c2)
        {
            Circle t = c1;
            c1 = c2;
            c2 = t;
        }
        static void Main(string[] args)
        {
            //int i = 42;
            //int copy_i = i;
            //i++;
            //Console.WriteLine($"i = {i}, copy_i = {copy_i}");

            Circle c = new Circle(42);
            Circle ref_c = c;
            ref_c.SetRadius(10);
            Console.WriteLine($"c: {c}\nref_c: {ref_c}");

            Circle copy_c = c.Clone();
            Console.WriteLine($"c: {c}\ncopy_c: {copy_c}");
            c.SetRadius(50);
            Console.WriteLine($"c: {c}\ncopy_c: {copy_c}");

            copy_c = new Circle(c);

            Circle c1 = new Circle(1);
            Circle c2 = new Circle(10);
            Swap(ref c1, ref c2);
            Console.WriteLine($"c1: {c1}, c2: {c2}");


            void Foo(Predicate<int> f, int arg)
            {
                Console.WriteLine(f(arg) ? "true" : "false");
            }
            Foo(x => x>0, -7);
            Foo(x => x<0, -7);


           

        }
    }
}
