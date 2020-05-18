using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace Day10_day9MD
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> listOfCars = new List<Car>();

            for (int i = 0; i < 5; i++)
            {
                AddCar(listOfCars);
            }
        }
        static void PrintAll(List<Car> lst)
        {
            foreach (Car c in lst)
            {
                c.Print();
                Console.WriteLine("------------------");
            }
        }

        static void AddCar(List<Car> lst)
        {
            Console.WriteLine("Ievadiet auto marku");
            String brand = Console.ReadLine();
            Console.WriteLine("Ievadiet auto krāsu");
            String color = Console.ReadLine();
            Console.WriteLine("Ievadiet auto krāsu");
            int doorCount;

            try
            {
                doorCount = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {

                Console.WriteLine("Nav ievadīts pareizs durvju skaits");
                doorCount = 4;
            }

            lst.Add(new Car(brand, color, doorCount));
        }
        static void SearchCars(List<Car> lst)
        {
            Console.WriteLine("pec ka velies meklet?");
            Console.WriteLine("1 - pec krasas");
            Console.WriteLine("2 - pec markas");
            Console.WriteLine("3 - pec durvju skaita");

            String choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("kada marka?");
                string brand = Console.ReadLine();

                bool found = false;

                foreach (Car c in lst)
                {
                    if (c.getBrand() == brand)
                    {
                        c.Print();
                        Console.WriteLine("------------------");
                        found = true;
                    }
                }
            }
            
        }
    }
}
