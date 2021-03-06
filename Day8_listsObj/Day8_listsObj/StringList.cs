﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Day8_listsObj
{
    class StringList
    {
        private List<String> listOfValues;

        public StringList()
        {
            listOfValues = new List<String>();
        }



        public void Task1()
        {
            //Mēs izvadam menu
            //Mēs dodam iespēju izvēlēties
            //1.izvadīt
            //2.pievienot
            //3.dzēst
            //0. Iziet

            string choice = "";

            while (choice != "0")
            {
                Console.WriteLine("Lai izvadītu sarakstu nospiedd - 1");
                Console.WriteLine("Lai pievienotu objektu sarakstam nospied - 2");
                Console.WriteLine("Lai dzēstu objektu no saraksta nospied - 3");
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
            //1. izvadīt
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
            //2.pievienot
            Console.WriteLine("Ievadiet objektu:");
            listOfValues.Add(Console.ReadLine());
            Console.WriteLine("-------------");

        }

        private void Delete()
        {
            //3.dzēst
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

        private void Exit()
        {
            Console.WriteLine("Paldies par uzmanību!");
        }


    }
}
