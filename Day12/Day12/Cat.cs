using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Day12
{
    class Cat : Animal
    {
        String name = "Rob";

        public Cat(bool wings = false, int legCount = 4)
        {
            this.wings = wings;
            this.legCount = legCount;
        }

        public override void Move()
        {
            Console.WriteLine("Cat moves!");
        }
        public override void MakeSound()
        {
            Console.WriteLine("Mjau mjau!");
        }

        public new void Sleep()
        {
            Console.WriteLine("Cat sleeps all the time");
        }

        public override void Print()
        {
            Console.WriteLine($"Name of the cat is {name}!");
            Console.WriteLine($"Cat has {legCount} legs!");
            Move();
            MakeSound();
            Sleep();
        }
    }
}
