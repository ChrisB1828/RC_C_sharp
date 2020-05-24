using System;
using System.Collections.Generic;
using System.Text;

namespace Day12
{
    class Parrot : Animal
    {
        bool biggestBird = false;
        public Parrot(bool wings = true, int legCount = 2)
        {
            this.wings = wings;
            this.legCount = legCount;
        }

        public override void Move()
        {
            Console.WriteLine("Parrot flies!");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Parrrrrrrooootttt!");
        }

        public override void Print()
        {
            Console.WriteLine($"Statement that parrots are the biggest birds in the world is {biggestBird}");
            Console.WriteLine($"Parrot has {legCount} legs!");
            Move();
            MakeSound();
            Sleep();
        }
    }
}
