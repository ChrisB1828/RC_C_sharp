using System;
using System.Collections.Generic;
using System.Text;

namespace Day11_OOP
{
    class Car : Vehicle
    {
        public int doorCount;

        public Car(int doorCount, string brand)
        {
            this.brand = brand;
            this.doorCount = doorCount;
        }
    }
}
