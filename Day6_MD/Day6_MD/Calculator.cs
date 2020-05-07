using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Day6_MD
{
    class Calculator
    {

        public static int Addition(int a, int b)
        {
            int sumAdd = a + b;
            return sumAdd;
        }

        public static int Subtraction(int a, int b)
        {
            int sumSub = a - b;
            return sumSub;
        }

        public static int Multiplication(int a, int b)
        {
            int sumMulti = a * b;
            return sumMulti;
        }

        public static int Division(int a, int b)
        {
            int sumDiv = a / b;
            return sumDiv;
        }

        public static int Reminder(int a, int b)
        {
            int reminder = a % b;
            return reminder;
        }

    }
}
