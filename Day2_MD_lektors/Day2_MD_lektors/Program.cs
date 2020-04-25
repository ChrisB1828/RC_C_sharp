using System;

namespace Day2_MD_lektors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BiggestNumber(3, 5));
            Console.WriteLine(BiggestNumber(199, 8));
        }
        static int BiggestNumber(int a, int b)
        {
            int biggest = 0;

            if (a >= b)
            {
                biggest = a;
            }
            else 
            {
                biggest = b;
            }

            return biggest;
        }
    }
}
