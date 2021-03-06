﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Lect_7
{
    public class Horse : Mammal, ILandBound, IJourney, IGrazable
    {
        public Horse(string name) : base(name)
        { }
        public void Trot()
        {
            Console.WriteLine("Trot...");
        }
        new public void Move()
        {
            base.Move();    //Move() на класа Mammal
            Console.WriteLine("Horse moves");
        }
        public override string ToString() => $"Horse {base.ToString()}";
        public new string GetTypeName() => "This is a horse";
        int ILandBound.NumberOfLegs() => 4;
        int IJourney.NumberOfLegs() => 3;

        public void ChewGrass()
        {
            Console.WriteLine("Grazable...");
        }
    }
}
