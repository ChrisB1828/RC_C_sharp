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

            int izvele = Convert.ToInt32(Console.ReadLine());

            switch (izvele)
            {
                case 1:
                    try
                    {
                        ReadAndPrint();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Neizdevas nolasit failu!");
                    }
                    break;
                case 2:
                    List<Student> listOfStudents = new List<Student>();
                    AddStudent(listOfStudents);
                    String json = JsonConvert.SerializeObject(listOfStudents, Formatting.Indented);
                    //Console.WriteLine(json);
                    Write(json);
                    ReadAndPrint();
                    break;
                default:
                    break;
            }
        }
        public static void AddStudent(List<Student> listOfStudents)
        {
            listOfStudents.Add(new Student("Kristaps", "Balodis", 3));
            listOfStudents.Add(new Student("Artis", "Abols", 3));
            listOfStudents.Add(new Student("Peteris", "Petersons", 3));
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
