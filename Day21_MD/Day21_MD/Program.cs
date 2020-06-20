using Google.Protobuf.WellKnownTypes;
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

            string name = "";
            string lastName = "";
            int cours = 0;

            bool b1;
            bool b2;

            Console.WriteLine("Enter name:");
            name = Console.ReadLine();

            if (b1 = string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Please enter students name!");
                b1 = false;    
            }
            else
            { 
                b1 = true;
            }

            if (b1 == true)
            {
                Console.WriteLine("Enter last name:");
                lastName = Console.ReadLine();

                if (b2 = string.IsNullOrWhiteSpace(lastName))
                {
                    Console.WriteLine("Please enter students last name!");
                    b2 = false;
                }
                else
                {
                    b2 = true;
                }

                if (b2 == true)
                {
                    Console.WriteLine("Enter Cours:");
                    string coursString = Console.ReadLine();

                    try
                    {
                        cours = Convert.ToInt32(coursString);

                        University student = new University(name, lastName, cours);

                        con.AddStudent(student);
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Please enter student cours with numbers");
                        AddStudent(con);
                    }

                    
                }
                else
                {
                    AddStudent(con);
                }  
            }
            else
            {
                AddStudent(con);
            }

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
