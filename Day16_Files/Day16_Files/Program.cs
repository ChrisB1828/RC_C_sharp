using System;
using System.Collections.Generic;

namespace Day16_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1.Run();
        }
        static void TaskPecTam()
        {
            String name = "";
            String surname = "";
            int course = 0;

            Student lst = new Student(name, surname, course);
            List<Student> listOfStudents = new List<Student>();


            int i = 1;

            while (i > 0)
            {
                Console.WriteLine("Lai izvadītu sarakstu ar studentiem nospied - 1");
                Console.WriteLine("Lai pievienotu sarakstam studentu nospied - 2");
                Console.WriteLine("Lai izietu no saraksta nospied - 0");
                String ievade = Console.ReadLine();

                switch (ievade)
                {
                    case "1":
                        foreach (Student st in listOfStudents)
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

                        listOfStudents.Add(new Student(name, surname, course));
                        break;

                    case "0":
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
