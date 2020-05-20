using System;
using System.Collections.Generic;
using System.Text;

namespace Day12
{
    class Dog : Animal
    {

        public int Legcount()
        {
            return legCount = 4;
        }
        public bool Wings()
        {
            return wings = false;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Vau Vau!");
        }
    }
}
