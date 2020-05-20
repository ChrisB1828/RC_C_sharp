using System;
using System.Collections.Generic;
using System.Text;

namespace Day12
{
    abstract class Animal
    {

        public bool wings = true;
        public int legCount;

        public abstract void MakeSound();
        public abstract void Move(); // overraide move pie katra
        
        public void Sleep() // taisam abstract
        {
            Console.WriteLine("Sleep");
        }

        public void NoWingsMove()
        {
            if (wings == true)
            {
                Move();
            }
        }

    }
}
