using System;

namespace Day12
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat c = new Cat();
            Dog d = new Dog();
            Parrot p = new Parrot();
            Sparrow s = new Sparrow();

            c.NoWingsMove();
            d.NoWingsMove();
            p.NoWingsMove();
            s.NoWingsMove();
        }
    }
}
