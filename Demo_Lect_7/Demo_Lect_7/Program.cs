using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Lect_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Time t1 = new Time(8, 15); //инициализация чрез собствен конструктор
            //Console.WriteLine(t1);
            //Console.WriteLine();
            //Time t2 = t1;
            //Time t3;
            //Time t4 = t3;  //Грешка - t3 не е инициализирана
            //Time t1 = new Time(7, 30);
            //Time t2 = t1;
            //t1.Hours = 11;
            //Console.WriteLine($"t1: {t1}");
            //Console.WriteLine($"t2: {t2}");


            //Cow cow = new Cow();
            //cow.EatFood();
            //cow.Breathe();
            //cow.Moo();
            //cow.SupplyMilk();
            //Console.WriteLine();

            //Chicken chicken = new Chicken();
            //chicken.EatFood();
            //chicken.Breathe();
            //chicken.Cluck();
            //chicken.LayEgg();
            //Console.WriteLine();

            //Animal animal = new Cow();  //OK, Cow is Animal
            //animal.EatFood();   //OK
            //animal.Breathe();     //OK
            ////animal.Moo();       //Error!
            //Console.WriteLine();

            //animal = new Chicken();     //OK, Chicken is Animal
            //animal.EatFood();
            //animal.Breathe();


            //System.Int32 i;

            Horse myHorse = new Horse("Brambie");
            //Whale myWhale = myHorse;  //Error
            Mammal myMammal = myHorse;  //OK
            object obj = myHorse;
     



            var horseMethods = typeof(Horse).GetMethods(
                System.Reflection.BindingFlags.Public |
                System.Reflection.BindingFlags.Instance);
            foreach(var method in horseMethods)
            {
                var parameters = method.GetParameters();
                Console.Write($"{method.ReturnType.Name} {method.Name}(");
                foreach(var parameter in parameters)
                {
                    Console.Write($"{parameter.ParameterType.Name} {parameter.Name} ");
                }
                Console.WriteLine(")");
            }


            Console.ReadKey();
        }
    }
}
