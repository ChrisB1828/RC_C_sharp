using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using System.Threading;

namespace Day6_Classes
{
    class Task1
    {
        private static int a = 0;
        private static int b = 0;

        public static void setA(int localA)
        {
            a = localA;
        }

        public static void setB(int localB)
        {
            b = localB;
        }

        public static int getA()
        {
            return a;
        }
        public static int getB()
        {
            return b;
        }

        public static void Zvaigznes(int a)
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

    }
}
