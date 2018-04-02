using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Lect_7
{
    public class Chicken : Animal
    {
        public void Cluck()
        {
            string type_name = this.GetType().Name;
            Console.WriteLine($"{type_name} cluck");
        }
        public void LayEgg()
        {
            string type_name = this.GetType().Name;
            Console.WriteLine($"{type_name} lay egg");
        }
    }
}
