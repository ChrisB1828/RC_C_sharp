using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day17_JSON
{
    class Task1
    {
        
        public static void JsonTask()
        {
            Menu();
            
        }

        public static void Menu()
        {
            Console.WriteLine("Ja velies izdrukat studenta sarakstu tad spied - 1");
            Console.WriteLine("Ja velies pievienot studentus sarakstam spied - 2");
            Console.WriteLine("Ja velies beigt spied - 3");

            int izvele = Convert.ToInt32(Console.ReadLine());

            switch (izvele)
            {
                case 1:
                    try
                    {
                        ReadAndPrint();
                        Menu();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Neizdevas nolasit failu!");
                        Menu();
                    }
                    break;
                case 2:
                    List<Student> listOfStudents = new List<Student>();

                    AddStudent(listOfStudents);

                    String json = JsonConvert.SerializeObject(listOfStudents, Formatting.Indented);
                    //Console.WriteLine(json);
                    
                    Write(json);
                    ReadAndPrint();

                    Console.WriteLine("--------------------");

                    Menu();
                    break;
                case 3:
                    break;
                default:
                    break;
            }
        }
        public static void AddStudent(List<Student> listOfStudents)
        {
            
            Console.WriteLine("Ievadiet studenta vardu!");
            String name = Console.ReadLine();
            Console.WriteLine("Ievadiet studenta uzvardu!");
            String surname = Console.ReadLine();
            Console.WriteLine("Ievadiet studenta kursu!");
            int cours = Convert.ToInt32(Console.ReadLine());

            listOfStudents.Add(new Student(name, surname, cours));
        }

        public static void ReadAndPrint()
        {
            StreamReader sr = new StreamReader(@"D:\Riga Coding School\RC_C_sharp\Day17_JSON\Faili\Task1.json");
            String json = sr.ReadToEnd();
            sr.Close();

            List<Student> listOfStudents2 = JsonConvert.DeserializeObject<List<Student>>(json);

            foreach (Student student in listOfStudents2)
            {
                string name = student.getName();
                string surname = student.getSurname();
                int cours = student.getCourse();
                Console.Write($"{name} {surname} {cours}");
                Console.WriteLine();
            }
            
        }
        public static void Write(String json)
        {
            try
            {
                StreamWriter sw = new StreamWriter(@"D:\Riga Coding School\RC_C_sharp\Day17_JSON\Faili\Task1.json");
                sw.Write(json);
                sw.Close();
            }
            catch (Exception)
            {

                Console.WriteLine("Neizdevas ierakstit faila!");
            }
        }
    }
}
