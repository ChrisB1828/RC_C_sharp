using System;

namespace Day3_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Uzdevums4();
        }

        static void Uzdevums4()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");             
            }
            for (int i = 2; i >= 0; i--) //īsti nesaptoru, kāpec šādi sanāk, lai gan es definēju ka loop ir jātaisa tikai tad, ja j < i un ja es definēju, ka j <= i tad nesanāk.
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");
            }

        }
        static void Uzdevums3()
        {
           
            String combined = "";
            for (int i = 0; i < 4; i++)
            {
                combined = combined + "*";
                Console.WriteLine(combined);
            }

        }
        static void Uzdevums3v2()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Uzdevums2()
        {
            int positive = 0;
            int negative = 0;
            int nule = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ievadi skaitli!");
                int sk = Convert.ToInt32(Console.ReadLine());
                if (sk > 0)
                {
                    positive += 1; // var izmantot arī positive++ ja ir jāpieskaita vērtība 1, += var pieskaitīt arī citas vērtības ne tikai 1, bet piemēram arī 5,31, 141 utt
                }
                else if (sk == 0)
                {
                    nule += 1;
                }
                else 
                {
                    negative += 1;
                }

            }

            Console.WriteLine("Ievadīti " + positive + " positīvi skaitļi");
            Console.WriteLine("Ievadīti " + negative + " negatīvi skaitļi");
            Console.WriteLine("Ievadīti " + nule + " skaitļi ar vērtību 0");
        }
        static void Uzdevums()
        {
            int lielakais = 0;
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ievadi skaitli!");
                 int sk = Convert.ToInt32(Console.ReadLine());
                if (sk >= lielakais)
                {
                    lielakais = sk;
                }
            
            }
            
                Console.WriteLine("Lielākais skaitlis no ievadītajiem ir " + lielakais);
            
        }
        static void ForExample()
        {
            for (int i = 0; i < 10; i++) //izmantojam, kad ir zināms reižu skaits cik garšs cikls ir jātaisa
            // i++ , i = i + 1
            {
                Console.WriteLine(i);
                Console.WriteLine(1);
                Console.WriteLine("-------");
            }

            Console.WriteLine("Ejam atpakaļ.");
            Console.WriteLine("-------");

            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(i);
                Console.WriteLine(1);
                Console.WriteLine("-------");
            }
        }
    }
}
