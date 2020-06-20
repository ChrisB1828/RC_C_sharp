using Renci.SshNet.Messages.Connection;
using System;

namespace Day21_MD
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        
        public static void Menu()
        {
            DBConnection con = new DBConnection();

            string choice = "";

            while (choice != "0")
            {
                Console.WriteLine("Show students - 1");
                Console.WriteLine("ADD student - 2");
                Console.WriteLine("Delete student - 3");
                Console.WriteLine("Exit - 0");

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine();
                        Console.WriteLine("-----------------------------");

                        con.GetStudents();

                        Console.WriteLine("-----------------------------");
                        Console.WriteLine();
                        break;
                    case "2":
                        AddStudent(con);
                        break;
                    case "3":
                        DeleteStudent(con);
                        break;
                    case "0":
                        break;
                    default:
                        break;
                }
            }
            
        }

        public static void AddStudent(DBConnection con)
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------");

            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Cours:");
            int cours = Convert.ToInt32(Console.ReadLine());

            University student = new University(name, lastName, cours);
            
            con.AddStudent(student);

            Console.WriteLine("----------------------------");
            Console.WriteLine();
        }

        public static void DeleteStudent(DBConnection con)
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------");

            Console.WriteLine("Delete student by ID number:");
            int studentID = Convert.ToInt32(Console.ReadLine());

            con.DeleteStudentById(studentID);

            Console.WriteLine("----------------------------");
            Console.WriteLine();
        }
    }
}
