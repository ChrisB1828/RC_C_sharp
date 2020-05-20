using System;
using System.Collections.Generic;

namespace Day11_MD
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeList();
        }

        static void EmployeeList()
        {

            List<Employee> lst = new List<Employee>();

            Console.WriteLine("Please creat team of one Manager, two Programmer and one Database expert.");
            Console.WriteLine();

            Console.WriteLine("Please enter information about Manager:");
            Console.WriteLine();
            MaInput(lst);
            Console.WriteLine("Please enter information about Programmers:");
            Console.WriteLine();
            ProInput(lst);
            Console.WriteLine("Please enter information about Database expert:");
            Console.WriteLine();
            DproInput(lst);


            foreach (Employee e in lst) //tikai daļēji saprotu aiz šī loģiku, vai varētu lūdzu detalizētāk izskaidrot. 
            {                           //varbūt ir kāda labāka metode kā tikt klāt viena saraksta objektiem no dažādām klasēm.
                if (e is Manager m)
                {
                    m.PrintM();
                }
                else
                {
                    if (e is Programmer p)
                    {
                        p.PrintPro();
                    }
                    else
                    {
                        DatabasePRO d = e as DatabasePRO;
                        d.PrintDP();
                    }
                }
            }
        }

        static void MaInput(List<Employee> lst)
        {
            String name;
            String surname;
            int age;
            int monthlySalary;
            int yearsOfExperience;

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Enter name:");
                name = Console.ReadLine();
                Console.WriteLine("Enter surname:");
                surname = Console.ReadLine();
                Console.WriteLine("Enter age:");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter monthly salary:");
                monthlySalary = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter years of experience:");
                yearsOfExperience = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("----------------------------------");
                Console.WriteLine();

                lst.Add(new Manager(name, surname, age, monthlySalary, yearsOfExperience));
            }
        }

        static void ProInput(List<Employee> lst)
        {
            String name;
            String surname;
            int age;
            int monthlySalary;
            String language;

            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Please enter information about first programmer:");
                }
                else
                {
                    Console.WriteLine("Please enter information about second programmer:");
                }
                Console.WriteLine();

                Console.WriteLine("Enter name:");
                name = Console.ReadLine();
                Console.WriteLine("Enter surname:");
                surname = Console.ReadLine();
                Console.WriteLine("Enter age:");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter monthly salary:");
                monthlySalary = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter language:");
                language = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("----------------------------------");
                Console.WriteLine();

                lst.Add(new Programmer(name, surname, age, monthlySalary, language));
            }
        }

        static void DproInput(List<Employee> lst)
        {
            String name;
            String surname;
            int age;
            int monthlySalary;
            String databaseTool;

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Enter name:");
                name = Console.ReadLine();
                Console.WriteLine("Enter surname:");
                surname = Console.ReadLine();
                Console.WriteLine("Enter age:");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter monthly salary:");
                monthlySalary = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter database tool:");
                databaseTool = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("----------------------------------");
                Console.WriteLine();

                lst.Add(new DatabasePRO(name, surname, age, monthlySalary, databaseTool));
            }
        }
    }
}
