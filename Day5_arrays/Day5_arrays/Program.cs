using System;

namespace Day5_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArraySample();
            //Task1();
            Task2();
        }

        static void Task2()
        {
            int[] a = { 1, 6, 7, 12, 14, 9 };

            double sum = 0;

            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
            }

            Console.WriteLine("Summa: " + sum);
            Console.WriteLine("Vidējā vērtība ir " + (sum /= a.Length));

        }
        static void Task1()
        {
            int[] a = new int[5];
            int sum = 0;

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Ievadiet skaitli");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
            }
            Console.WriteLine("Summa: " + sum);
        }

        static void ArraySample()
        {
            int[] a = new int[5];
            a[0] = 1;
            a[1] = 5;
            a[2] = 8;
            a[3] = 7;
            a[4] = 99;

            Console.WriteLine(a[0]);

            int sum = a[0] + a[4];
            Console.WriteLine(sum);
                   
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
