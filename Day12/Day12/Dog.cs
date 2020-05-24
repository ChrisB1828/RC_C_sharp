using System;
using System.Collections.Generic;
using System.Text;

namespace Day12
{
    class Dog : Animal
    {
        int siblings = 5;

        public Dog(bool wings = false, int legCount = 4)
        {
            this.wings = wings;
            this.legCount = legCount;
        }

        public override void Move()
        {
            Console.WriteLine("Dog moves!");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Vau Vau!");
        }
        public new void Sleep()
        {
            Console.WriteLine("Dog sleeps");
        }
        public override void Print()
        {
            Console.WriteLine($"Dog has {siblings} siblings!");
            Console.WriteLine($"Dog has {legCount} legs!");
            Move();
            MakeSound();
            Sleep();
        }
    }
}
