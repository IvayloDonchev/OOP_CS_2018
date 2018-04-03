using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Lect_7
{
    public class Animal
    {
        public void EatFood()
        {
            string type_name = this.GetType().Name;
            Console.WriteLine($"{type_name} eats food");
        }
        public void Breathe()
        {
            string type_name = this.GetType().Name;
            Console.WriteLine($"{type_name} breed");
        }
    }
}
