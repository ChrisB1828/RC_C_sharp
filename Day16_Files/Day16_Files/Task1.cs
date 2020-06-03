using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Transactions;

namespace Day16_Files
{
    class Task1
    {
        public static void Run()
        {
            String studentInfo = "Juris,Abolins,3";
            String[] words = studentInfo.Split(',');

            string name = words[0];
            string surname = words[1];
            int course = Convert.ToInt32(words[2]);

            Student student = new Student(name, surname, course);

            student.print();

        }
    }
}
