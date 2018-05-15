using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Lect_7
{
    public class Mammal 
    {
        private string name;
        public Mammal(string name)
        {
            this.name = name;
        }
        public void Breathe()
        {
            //------------------------
        }
        public void SuckleYoung()
        {
            //---------------------
        }
        public void Move()
        {
            Console.WriteLine("Mammal moves");
        }
        public override string ToString() => name;
        public virtual string GetTypeName() => "This is a mammal";
    }
}
