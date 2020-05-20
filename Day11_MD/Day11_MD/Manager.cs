using System;
using System.Collections.Generic;
using System.Text;

namespace Day11_MD
{
    class Manager : Employee
    {
        public int yearsOfExperience;
        public Manager(String name, String surname, int age, int monthlySalary, int yearsOfExperience)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.monthlySalary = monthlySalary;
            this.yearsOfExperience = yearsOfExperience;
        }

        public void PrintM()
        {
            Console.WriteLine(name + " " + surname);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Monthly Salary: " + monthlySalary + " EUR");
            Console.WriteLine("Years of experience: " + yearsOfExperience);
            Console.WriteLine("----------------------------------");
        }
    }
}
