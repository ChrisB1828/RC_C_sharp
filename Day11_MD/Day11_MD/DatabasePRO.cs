using System;
using System.Collections.Generic;
using System.Text;

namespace Day11_MD
{
    class DatabasePRO : Employee
    {
        private String databaseTool;

        public DatabasePRO(String name, String surname, int age, int monthlySalary, String databaseTool)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.monthlySalary = monthlySalary;
            this.databaseTool = databaseTool;
        }


        public void PrintDP()
        {
            Console.WriteLine(name + " " + surname);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Monthly Salary: " + monthlySalary + " EUR");
            Console.WriteLine("Database tool: " + databaseTool);
        }
        
    }
}
