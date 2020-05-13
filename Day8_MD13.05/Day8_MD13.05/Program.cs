using System;
using System.Collections.Generic;

namespace Day8_MD13._05
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                a.Add(i);
            }

            List<int> b = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                b.Add(i);
            }

            Tasks t = new Tasks();
            Console.WriteLine(t.CompareLists(a, b));

            t.ReverseArray();
        }
    }
}
