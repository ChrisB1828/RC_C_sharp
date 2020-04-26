using System;

namespace Day3_MD
{
    class Program
    {
        static void Main(string[] args)
        {
            Ievade();
        }
        
        static void Ievade ()
        {
            int i = 1;
            int lielākais = 0;
            int mazākais = 0;

            while (i > 0)
            {
                String stop = "";

                for (int j = 1; j > 0;)
                {
                    Console.WriteLine("Ievadiet skaitli! Ja ievadīsiet STOP, skaitļu ievade tiks pārtraukta.");
                    stop = Console.ReadLine();
                }
                 
                if (stop == "STOP")
                {
                    break;
                }

                int sk = Convert.ToInt32(stop);

                if (sk < mazākais)
                {
                    mazākais = sk;
                }
                else if (sk >= lielākais)
                {
                    lielākais = sk;
                }           
            }

            Console.WriteLine("Lielākais ievadītais skaitlis ir " + lielākais);
            Console.WriteLine("Mazākais ievadītais skailis ir  " + mazākais);
        }
    }
}
