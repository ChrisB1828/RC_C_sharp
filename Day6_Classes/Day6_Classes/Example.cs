using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_Classes
{
    class Example
    {
        private static int a = 0;
        private static int b = 0;

        public static void Test()
        {
            Console.WriteLine("Šī ir testa metode");
            PrivateTest();
            a = 3;
            b = a + 8;
        }

        private static void PrivateTest()
        {
            Console.WriteLine("Šī ir privāta testa metode");
        }

        public static int ReturnPublic()
        {
            return 2 + 3;
        }

        public static void ParamPublic(int a, int b)
        {
            Console.WriteLine(a + b);
        }

    }
}
