using System;
using System.Collections.Generic;
using System.Text;

namespace Day11_MD
{
    class Programmer : Employee
    {
        public String language;

        public Programmer(String name, String surname, int age, int monthlySalary, String language)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.monthlySalary = monthlySalary;
            this.language = language;
        }
        public void PrintPro()
        {
            Console.WriteLine(name + " " + surname);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Monthly Salary: " + monthlySalary + " EUR");
            Console.WriteLine("Language: " + language);
            Console.WriteLine("----------------------------------");
        }
    }
}
