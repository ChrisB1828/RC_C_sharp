using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Day7_Object
{
    class Task4
    {

        public void Menu()
        {
            Console.WriteLine("Lai izvadītu sarakstu nospied - 1");

            string ievade1 = Console.ReadLine();

            List<int> randomSk = new List<int>();         

            if (ievade1 == "1")
            {
                for (int i = 0; i < randomSk.Count; i++)
                {
                    randomSk[i] = RandomNumber();
                }
            }
            else
            {
                Console.WriteLine("Nepareiza ievade!");
                return;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Lai izvadītu sarakstu nospied - 1");
                Console.WriteLine("Lai izdzēstu skaitli no saraksta pēc indeksa nospied - 2");
                string ievade2 = Console.ReadLine();

                if (ievade2 == "2")
                {
                    int j = 10;

                    while (j > 0)
                    {
                        Console.WriteLine("Ievadiet indeksu kuru vēlaties dzēst");
                        int indeks = Convert.ToInt32(Console.ReadLine());
                        j--;
                    }

                }
            }
     
            Console.WriteLine("Lai izietu nospied - 3");

        }


        public int RandomNumber(int min = 1, int max = 101)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

    }
}
