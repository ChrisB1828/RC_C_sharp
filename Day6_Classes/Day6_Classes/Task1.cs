using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_Classes
{
    class Task1
    {

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
