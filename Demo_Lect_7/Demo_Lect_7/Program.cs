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
            Time t1 = new Time { hours=8, minutes=15, seconds=0};
            Console.WriteLine(t1);
            Console.WriteLine();

            Cow cow = new Cow();
            cow.EatFood();
            cow.Breathe();
            cow.Moo();
            cow.SupplyMilk();
            Console.WriteLine();

            Chicken chicken = new Chicken();
            chicken.EatFood();
            chicken.Breathe();
            chicken.Cluck();
            chicken.LayEgg();
            Console.WriteLine();

            Animal animal = new Cow();  //OK, Cow is Animal
            animal.EatFood();   //OK
            animal.Breathe();     //OK
            //animal.Moo();       //Error!
            Console.WriteLine();

            animal = new Chicken();     //OK, Chicken is Animal
            animal.EatFood();
            animal.Breathe();

            Console.ReadKey();
        }
    }
}
