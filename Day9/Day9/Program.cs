using System;
using System.Collections.Generic;
using System.Security.Principal;

namespace Day9
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
        }
        
        static void Task1()
        {
            String name = "";
            String surname = "";
            int course = 0;

            Student lst = new Student(name, surname, course);
            List<Student> lstOfStudents = new List<Student>();


            int i = 1;

            while (i > 0)
            {
                Console.WriteLine("Lai izvadītu sarakstu ar studentiem nospied - 1");
                Console.WriteLine("Lai pievienotu sarakstam studenta vārdu nospied - 2");
                Console.WriteLine("Lai izietu no saraksta nospied - 0");
                String ievade = Console.ReadLine();

                switch (ievade)
                {
                    case "1":
                        foreach (Student st in lstOfStudents)
                        {
                            st.print();
                        }
                        break;
                    case "2":
                        Console.WriteLine("Ievadiet studenta vārdu:");
                        name = Console.ReadLine();

                        Console.WriteLine("Ievadiet studenta uzvārdu:");
                        surname = Console.ReadLine();

                        Console.WriteLine("Ievadiet studenta kursu:");
                        course = Convert.ToInt32(Console.ReadLine());

                        lstOfStudents.Add(new Student(name, surname, course));
                        break;

                    case "0":
                        break;
                    default:
                        break;
                }
            }
        }

        static void Example1()
        {
            List<Student> listOfStudents = new List<Student>();

            listOfStudents.Add(new Student("Jānis", "Bērziņš", 1));
            listOfStudents.Add(new Student("Juris", "Abele", 2));
            listOfStudents.Add(new Student("Kristaps", "Kalejs", 3));

            for (int i = 0; i < listOfStudents.Count; i++)
            {
                listOfStudents[i].print();
            }

            foreach (Student st in listOfStudents)
            {
                st.print();
            }
        }
    }
}
