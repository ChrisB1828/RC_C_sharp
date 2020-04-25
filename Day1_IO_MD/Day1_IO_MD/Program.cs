using System;

namespace Day1_IO_MD
{
    class Program
    {
        static void Main(string[] args) // MD 1.,2.,3.extra un 4.extra uzdevums 
        {
            Console.WriteLine("Sveiks, ievadi savu vārdu.");
            string ievade = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Sveiks, " + ievade + "!");
            Console.WriteLine("");

            int atbilde1 = 0;
            System.Console.WriteLine("Kāds ir tavs mīļakais skaitlis?");
            atbilde1 = System.Convert.ToInt32(System.Console.ReadLine());
            Console.WriteLine("");

            int atbilde2 = 0;
            System.Console.WriteLine("Ieraksti skaitli kurš tev nepatīk.");
            atbilde2 = System.Convert.ToInt32(System.Console.ReadLine());
            Console.WriteLine("");

            int atbilde3 = 0;
            System.Console.WriteLine("Tagad ieraksti citu skaitli.");
            atbilde3 = System.Convert.ToInt32(System.Console.ReadLine());
            Console.WriteLine("");

            string combined = "Tavs mīļākais skaitlis ir " + atbilde1 + ". Tev nepatīk skaitlis " + atbilde2 + ", savukārt, Tavs trešais ievadītais skaitlis ir " + atbilde3 + ".";

            Console.WriteLine(combined);
            Console.WriteLine("");

            if (atbilde1 >= atbilde2)
            {
                if (atbilde1 >= atbilde3)
                {
                    Console.WriteLine(atbilde1 + " ir lielakais skaitlis!");
                }
                else
                {
                    Console.WriteLine(atbilde3 + " ir lielakais skaitlis!");
                }
                
            }
            else 
            {
                if (atbilde2 >= atbilde3)
                {
                    Console.WriteLine(atbilde2 + " ir lielakais skaitlis!");
                }
                else
                {
                    Console.WriteLine(atbilde3 + " ir lielakais skaitlis!");
                }
            }

            Console.WriteLine("");

            int a = 3;
            int b = 9;

            int result1 = b;
            int result2 = a;

            a = result1;
            b = result2;

            Console.WriteLine("Kā arī vai zināji, ka A vērtība sākotnēji bija 3 un B vērtība bija 9, bet tagad A = " + a + " un B = " + b + "?");
            Console.WriteLine("");

            Console.WriteLine("Paldies par uzmanibu!");

        }
    }
}
