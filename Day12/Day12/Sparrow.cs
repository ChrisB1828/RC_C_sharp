using System;
using System.Collections.Generic;
using System.Text;

namespace Day12
{
    class Sparrow : Animal
    {

        public Sparrow(bool wings = true, int legCount = 2)
        {
            this.wings = wings;
            this.legCount = legCount;
        }

        public override void Move()
        {
            Console.WriteLine("Sparrow flies!");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Chiv Chiv!"); 
        }
        public override void Print()
        {
            Console.WriteLine($"Sparrow has {legCount} legs!");
            Move();
            MakeSound();
            Sleep();
        }
    }
}
