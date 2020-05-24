using System;

namespace Day12
{
    class Program
    {
        static void Main(string[] args)
        {
            NoWingsMove();
            WingsMove();
            AnimalsMakeSound();
            AnimalsSleep();
            AnimalPrint();
        }

        static void NoWingsMove()
        {
            Console.WriteLine("Animals without wings moves!");
            Console.WriteLine();

            Cat c = new Cat();
            Dog d = new Dog();
            Parrot p = new Parrot();
            Sparrow s = new Sparrow();

            if (c.wings == false)
            {
                c.Move();
            }
            if (d.wings == false)
            {
                d.Move();
            }
            if (p.wings == false)
            {
                p.Move();
            }
            if (s.wings == false)
            {
                s.Move();
            }

            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine();
        }
        static void WingsMove()
        {
            Console.WriteLine("Animals with wings moves!");
            Console.WriteLine();

            Cat c = new Cat();
            Dog d = new Dog();
            Parrot p = new Parrot();
            Sparrow s = new Sparrow();

            if (c.wings != false)
            {
                c.Move();
            }
            if (d.wings != false)
            {
                d.Move();
            }
            if (p.wings != false)
            {
                p.Move();
            }
            if (s.wings != false)
            {
                s.Move();
            }

            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine();
        }

        static void AnimalsMakeSound()
        {
            Console.WriteLine("All animals make a sound!");
            Console.WriteLine();

            Cat c = new Cat();
            Dog d = new Dog();
            Parrot p = new Parrot();
            Sparrow s = new Sparrow();

            c.MakeSound();
            d.MakeSound();
            p.MakeSound();
            s.MakeSound();

            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine();
        }
        static void AnimalsSleep()
        {

            Cat c = new Cat();
            Dog d = new Dog();
            Parrot p = new Parrot();
            Sparrow s = new Sparrow();

            c.Sleep();
            d.Sleep();
            p.Sleep();
            s.Sleep();

            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine();

        }

        static void AnimalPrint()
        {
            Cat c = new Cat();
            Dog d = new Dog();
            Parrot p = new Parrot();
            Sparrow s = new Sparrow();

            c.Print();
            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine();

            d.Print();
            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine();

            p.Print();
            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine();

            s.Print();
            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine();
        }
    }
}
