using System;
using System.Collections.Generic;
using System.Text;

namespace Day12
{
    class Parrot : Animal
    {
        public int Legcount()
        {
            return legCount = 2;
        }

        public bool Wings()
        {
            return wings = true;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Parrrrrrrooootttt!");
        }
    }
}
