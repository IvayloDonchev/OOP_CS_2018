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
            Cow cow = new Cow();
            cow.EatFood();
            cow.Breed();
            cow.Moo();
            cow.SupplyMilk();
            Console.WriteLine();

            Chicken chicken = new Chicken();
            chicken.EatFood();
            chicken.Breed();
            chicken.Cluck();
            chicken.LayEgg();
            Console.WriteLine();

            Animal animal = new Cow();  //OK, Cow is Animal
            animal.EatFood();   //OK
            animal.Breed();     //OK
            //animal.Moo();       //Error!
            Console.WriteLine();

            animal = new Chicken();     //OK, Chicken is Animal
            animal.EatFood();
            animal.Breed();

            Console.ReadKey();
        }
    }
}
