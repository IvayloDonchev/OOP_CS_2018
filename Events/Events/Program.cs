using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public delegate void ThresholdReachedEventHandler(object sender, ThresholdReachedEventArgs e);
    class Program
    {
        static void Main(string[] args)
        {
            Counter c = new Counter();
            for(int i=1; i<=100; i++)
                c.Inc();
            c.ThresholdReached += c_ThresholdReached;

            // provide remaining implementation for the class
            Console.ReadKey();
        }
        static void c_ThresholdReached(object sender, EventArgs e)
        {
            Console.WriteLine("The threshold was reached.");
        }
    }
}
