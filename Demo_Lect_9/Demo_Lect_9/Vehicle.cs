using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Lect_9
{
    public class Vehicle
    {
        public void StartEngine(string noiseToMakeWhenStarting)
        {
            Console.WriteLine("Starting engine: {0}", noiseToMakeWhenStarting);
        }
        public void StopEngine(string noiseToMAkeWhenStopping)
        {
            Console.WriteLine("Stopping engine: {0}", noiseToMAkeWhenStopping);
        }
        public virtual void Drive()
        {
            Console.WriteLine("Default implementation of the Drive() method");
        }
    }
}
