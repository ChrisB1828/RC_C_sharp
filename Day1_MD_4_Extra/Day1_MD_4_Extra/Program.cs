using System;

namespace Day1_MD_4_Extra
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 9;

            int result1 = a + a + a;
            int result2 = b - a - a;

            a = result1;
            b = result2;

            Console.WriteLine("A = " + a);
            Console.WriteLine("");
            Console.WriteLine("B = " + b);

        }
    }
}
