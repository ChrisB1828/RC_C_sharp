using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Day10_day9MD
{
    class Car
    {
        private String brand;
        private String color;
        private int doorCount;

        public Car(String brand, String color, int doorCount)
        {
            this.brand = brand;
            this.color = color;
            this.doorCount = doorCount;
        }

        public void setBrand(String brand)
        {
            this.brand = brand;
        }
        public void setColor(string color)
        {
            this.color = color;
        }
        public void setDoorCount(int doorCount)
        {
            this.doorCount = doorCount;
        }

        public string getBrand()
        {
            return brand;
        }
        public string getColor()
        {
            return color;
        }
        public int getDoorCount()
        {
            return doorCount;
        }

        public void Print()
        {
            Console.WriteLine(color + " " + brand + ", durvju skaits: " + doorCount);
        }
    }
}
