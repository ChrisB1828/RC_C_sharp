using System;
using System.Collections.Generic;
using System.Text;

namespace Day17_JSON
{
    class Car
    {
        public string brand;
        public string model;
        public int doorCount;

        public Car(string brand, string  model, int doorCount)
        {
            this.brand = brand;
            this.model = model;
            this.doorCount = doorCount;
        }
    }
}
