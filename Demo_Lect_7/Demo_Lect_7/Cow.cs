using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Lect_7
{
    public class Cow : Animal
    {
        public void Moo()
        {
            string type_name = this.GetType().Name;
            Console.WriteLine($"{type_name} moo");
        }
        public void SupplyMilk()
        {
            string type_name = this.GetType().Name;
            Console.WriteLine($"{type_name} milk");
        }
    }
}
