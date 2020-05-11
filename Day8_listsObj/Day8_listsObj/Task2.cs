using System;
using System.Collections.Generic;
using System.Text;

namespace Day8_listsObj
{
    class Task2
    {
        

        private List<String> listOfValues;

        public Task2()
        {
            listOfValues = new List<String>();
        }

        public void TaskTwo()
        {

            string choice = "";

            while (choice != "0")
            {
                Console.WriteLine("Lai izvadītu sarakstu nospiedd - 1");
                Console.WriteLine("Lai pievienotu objektu sarakstam nospied - 2");
                Console.WriteLine("Lai dzēstu objektu no saraksta nospied - 3");
                Console.WriteLine("Lai izvadītu indeksu elementiem, kas satur meklējamo frāzi nospied - 4");
                Console.WriteLine("Lai izietu no saraksta nospied - 0");

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Print();
                        break;
                    case "2":
                        Add();
                        break;
                    case "3":
                        Delete();
                        break;
                    case "4":
                        Finder();
                        break;
                    case "0":
                        Exit();
                        break;
                    default:
                        Console.WriteLine("Nepareiza ievade! lūdzam atkārtoti ievadīt");
                        break;
                }
            }

        }

        private void Print()
        {
            
            Console.WriteLine("-------------");
            if (listOfValues.Count == 0)
            {
                Console.WriteLine("Saraksts ir tukš!");
            }
            else
            {
                listOfValues.ForEach(Console.WriteLine);
            }
            Console.WriteLine("-------------");
        }

        private void Add()
        {
            
            Console.WriteLine("Ievadiet objektu:");
            listOfValues.Add(Console.ReadLine());
            Console.WriteLine("-------------");

        }

        private void Delete()
        {
            
            Console.WriteLine("Ievadiet objektu kuru vēlaties dzēst");
            string delete = Console.ReadLine();
            for (int i = 0; i < listOfValues.Count; i++)
            {
                if (delete != listOfValues[i])
                {
                    Console.WriteLine("Nepareiza ievade!");
                }
                else
                {
                    listOfValues.Remove(delete);
                }
            }

        }

        private void Finder()
        {
            Console.WriteLine("Ievadiet objektu kuru vēlaties atrasts:");
            string find = Console.ReadLine().ToLower();

            for (int i = 0; i < listOfValues.Count; i++)
            {
                String el = listOfValues[i].ToLower();

                if (el.Contains(find))
                {
                    Console.WriteLine("-------------");
                    Console.WriteLine("Index = " + i + ", Objekts = " + listOfValues[i]);
                    Console.WriteLine("-------------");
                }
                else
                {
                    Console.WriteLine("-------------");
                    Console.WriteLine("Šāds objekts sarakstā nav atrasts!");
                    Console.WriteLine("-------------");
                }
            }
            
        }

        private void Exit()
        {
            Console.WriteLine("Paldies par uzmanību!");
        }
    }
}
