using System;

namespace Day1_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sveiks, ieraksti savu vārdu šeit:");
            string ievade = Console.ReadLine();
            Console.WriteLine("Sveiks, " + ievade + "!");

            int atbilde1 = 0;
            System.Console.WriteLine("ievadi skaitli no 1 līdz 1000!");
            atbilde1 = System.Convert.ToInt32(System.Console.ReadLine());

            int atbilde2 = 0;
            System.Console.WriteLine("Ievadi skaitli no 50 līdz 500!");
            atbilde2 = System.Convert.ToInt32(System.Console.ReadLine());

            int atbilde3 = 0;
            System.Console.WriteLine("Ievadi skaitli no 1 līdz 100!");
            atbilde3 = System.Convert.ToInt32(System.Console.ReadLine());

            string combined = ("tavs pirmais skaitlis ir " + atbilde1 + " tavs otrais skaitlis ir " + atbilde2 + " tavs trešais skaitlis ir " + atbilde3 + "!");

            Console.WriteLine(combined);

            if (atbilde1 >= atbilde2)
            {
                if (atbilde1 >= atbilde3)
                {
                    Console.WriteLine("lielākais skaitlis no šiem trīs ir " + atbilde1);
                }
                else
                {
                    Console.WriteLine("lielākais skaitlis no šiem trīs ir " + atbilde3);
                }
            }
            else
            {
                if (atbilde2 >= atbilde3)
                {
                    Console.WriteLine("lielākais skaitlis no šiem trīs ir " + atbilde2);
                }
                else
                {
                    Console.WriteLine("lielākais skaitlis no šiem trīs ir " + atbilde3);
                }
            }


        }
    }
}
