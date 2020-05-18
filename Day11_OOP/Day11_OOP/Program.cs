using System;
using System.Numerics;

namespace Day11_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Vehicle();
            car.Drive();

            Car c = new Car(2, "Volvo");
            c.Drive();
        }
    }
}
