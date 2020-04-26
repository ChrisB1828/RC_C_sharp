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
            int lielākais = Int32.MinValue; //vai šo saīsinājumu MD ietvaros drīkst izmantot, lai nebūtu int max un min vērtība jāraksta ar skaitļiem?
            int mazākais = Int32.MaxValue;

            while (i > 0)
            {

                Console.WriteLine("Ievadiet skaitli! Ja ievadīsiet STOP, skaitļu ievade tiks pārtraukta.");
                string stop = Console.ReadLine();
                 
                if (stop == "STOP")
                {
                    break;
                }

                int sk = Convert.ToInt32(stop);
                
                if (sk <= mazākais)
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
