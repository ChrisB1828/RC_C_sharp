using System;

namespace Day1_P2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sveiks, kā tevi sauc?");
            
            string atbilde1 = Console.ReadLine();

            Console.WriteLine("Sveiks, " + atbilde1 + "!");

            int atbilde2 = 0;
            System.Console.WriteLine("Ieraksti skaitli no 1 līdz 100");
            atbilde2 = System.Convert.ToInt32(System.Console.ReadLine());

            int atbilde3 = 0;
            System.Console.WriteLine("Tagad ievadi cittu skaitli no 1 līdz 100");
            atbilde3 = System.Convert.ToInt32(System.Console.ReadLine());

            int atbilde4 = 0;
            System.Console.WriteLine("tagad ievadi citu skaitli no 1 līdz 100");
            atbilde4 = System.Convert.ToInt32(System.Console.ReadLine());

            String combined = atbilde2 + ", " + atbilde3 + " un " + atbilde4 + "!";

            Console.WriteLine("tavi ievadītie skaitļi ir " + combined);

            if (atbilde2 >= atbilde3)
            {
                if (atbilde2 >= atbilde4)
                {
                    Console.WriteLine("lielākais skaitlis ir " + atbilde2);
                }

                else
                {
                    Console.WriteLine("lielākais skaitlis ir " + atbilde4);
                }
            }

            else
            {
                if (atbilde3 >= atbilde4)
                {
                    Console.WriteLine("lielākais skaitlis ir " + atbilde3);
                }
                else
                {
                    Console.WriteLine("Lielākais skaitlis ir " + atbilde4);
                }
            }

            Console.WriteLine("Paldies par uzmanību!");

        }
    }
}
