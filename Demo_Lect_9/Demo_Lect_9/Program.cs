using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Lect_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Journey by airplane:");
            Airplane myPlane = new Airplane();
            myPlane.StartEngine("Contact");
            myPlane.TakeOff();
            myPlane.Drive();
            myPlane.Land();
            myPlane.StopEngine("Whirr");

            Console.WriteLine("\nJourney by car:");
            Car myCar = new Car();
            myCar.StartEngine("Brm brm");
            myCar.Accelerate();
            myCar.Drive();
            myCar.Brake();
            myCar.StopEngine("Phut phut");

            Console.WriteLine("\nTesting polymprphism:");
            Vehicle v = myCar;
            v.Drive();
            v = myPlane;
            v.Drive();

            Console.ReadKey();
        }

    }
}
