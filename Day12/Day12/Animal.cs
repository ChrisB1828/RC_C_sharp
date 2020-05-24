using System;
using System.Collections.Generic;
using System.Text;

namespace Day12
{
    abstract class Animal
    {

        public bool wings;
        public int legCount;

        public abstract void MakeSound();
        public abstract void Move();
        
        public void Sleep()
        {
            Console.WriteLine("All winged animals sleeps");
        }

        public abstract void Print();

    }
}
