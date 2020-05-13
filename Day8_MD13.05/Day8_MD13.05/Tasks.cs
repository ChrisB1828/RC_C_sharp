using System;
using System.Collections.Generic;
using System.Text;

namespace Day8_MD13._05
{
    class Tasks
    {
        public bool CompareLists(List<int> a, List<int> b)
        {
            if (a.Count != b.Count)
            {
                return false;
            }

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] != b[i])
                {
                    return false;
                }
            }

            return true;
        }

        public void ReverseArray()
        {
            int[] a = new int[5];
            int[] b = new int[5];

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Ievadiet skaitli!");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < a.Length; i++)
            {
                b[i] = a[a.Length - 1 - i];
                Console.Write(b[i] + " ");
            }

        }
    }
}
