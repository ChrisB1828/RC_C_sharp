using System;
using System.Collections.Generic;
using System.Text;

namespace Day11_MD
{
    class Employee
    {
        protected String name;
        protected String surname;
        protected int age;
        protected int monthlySalary;

        
        public void EmployeeInput()
        {
            Console.WriteLine("Enter name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter surname:");
            surname = Console.ReadLine();
            Console.WriteLine("Enter age:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter monthly salary:");
            monthlySalary = Convert.ToInt32(Console.ReadLine());
        }

    }
}
