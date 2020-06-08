using System;
using System.Collections.Generic;
using System.Text;

namespace Day18_REST
{
    class Employee
    {
        public String employee_age;
        public String employee_name;
        public String employee_salary;
        public String id;
        public String profile_image;

        public Employee(String employee_age, String employee_name, String employee_salary, String id, String profile_image)
        {
            this.employee_age = employee_age;
            this.employee_name = employee_name;
            this.employee_salary = employee_salary;
            this.id = id;
            this.profile_image = profile_image;
        }
    }
}
