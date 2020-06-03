using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day16_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1.Run();
            TaskPecTam();
        }
        static void TaskPecTam()
        {
            String name = "";
            String surname = "";
            int course = 0;

            Student lst = new Student(name, surname, course);
            List<Student> listOfStudents = new List<Student>();
            List<string> listOfStudentString = new List<string>();

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
                       // bool isEmpty = !listOfStudents.Any();
                        if (!listOfStudents.Any())
                        {
                            Read(listOfStudents);
                            foreach (var st in listOfStudents)
                            {
                                st.print();
                                Console.WriteLine("-----------------------");
                            }
                        }
                        else
                        {
                            foreach (var st in listOfStudents)
                            {
                                st.print();
                                Console.WriteLine("-----------------------");
                            }
                        }
                        
                        break;
                    case "2":
                        Console.WriteLine("Ievadiet studenta vārdu:");
                        name = Console.ReadLine();

                        Console.WriteLine("Ievadiet studenta uzvārdu:");
                        surname = Console.ReadLine();

                        Console.WriteLine("Ievadiet studenta kursu:");
                        string coursString = Console.ReadLine();
                        try
                        {
                            course = Convert.ToInt32(coursString);
                            listOfStudents.Add(new Student(name, surname, course));
                            string combined = $"{name},{surname},{coursString}";
                            listOfStudentString.Add(combined);
                            Write(listOfStudentString);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Nav ievadits skaitlis");
                            TaskPecTam();
                        }
   
                        break;
                    case "3":
                        DeleteFromFile(listOfStudents);
                        break;
                    case "0":
                        break;
                    default:
                        break;
                }
            }
        }
        public static void Write(List<String> studentList)
        {
            StreamWriter sw = new StreamWriter(@"D:\Riga Coding School\RC_C_sharp\Day16_Files\Faili\Student_List.text", true);
            foreach (string student in studentList)
            {
                sw.WriteLine(student);
            }
            sw.Close();
        }

        public static void DeleteFromFile(List<Student> lst)
        { 
            
            
            
        }
        public static void Read(List<Student> lst)
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader(@"D:\Riga Coding School\RC_C_sharp\Day16_Files\Faili\Student_List.text");
                line = sr.ReadLine();

                while(line != null)
                {
                    string[] split = line.Split(",");
                    string name = split[0];
                    string surname = split[1];
                    int course = Convert.ToInt32(split[2]);

                    Student student = new Student(name, surname, course);

                    lst.Add(student);
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Nav atrasts fails!");
            }
        }
    }
}
