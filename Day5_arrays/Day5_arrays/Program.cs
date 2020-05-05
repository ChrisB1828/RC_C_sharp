using System;
using System.Linq;

namespace Day5_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArraySample();
            //Task1();
            //Task2();
            //Task3();
            Task4(); // ar Extra uzdevumu
        }

        static void Task4()
        {
            int[] a = { 1, 6, 8, 9, 12 };

            Console.WriteLine("Ievadiet kādu no šiem skaitļiem lai iegūtu indeksu: 1, 6, 8, 9 vai 12");
            int sk = Convert.ToInt32(Console.ReadLine());

            if (!a.Contains(sk)) //Extra uzdevums
            {
                Console.WriteLine("Ievadīts nepareizs skaitlis!");
            }

            for (int i = 0; i < a.Length; i++)
            {

                if (sk == a[i])
                {
                    Console.WriteLine(i);
                }
                
            }
  
        }

        static void Task3()
        {
            int[] a = new int[5];
            Console.WriteLine("Random skaitļi:");

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = RandomNumber();
                Console.WriteLine(a[i]);
                
            }
            Console.WriteLine();

            Console.WriteLine("Ievadiet kādu no šiem skaitļiem, lai iegūtu indeksu");
            int sk = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indeksi: ");

            for (int i = 0; i < a.Length; i++)
            {

                if (sk == a[i])
                {
                    Console.Write(i + "");
                }

            }


        }

        static int RandomNumber(int min = 1, int max = 11)
        {
            Random random = new Random();
            return random.Next(min, max);
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
            double sum = 0;

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
            Console.WriteLine("Vidējā vērtība ir " + (sum /= a.Length));
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
