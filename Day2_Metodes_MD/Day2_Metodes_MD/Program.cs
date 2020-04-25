using System;

namespace Day2_Metodes_MD
{
    class Program
    {
        
        static void Main(string[] args)
        {
                        
            EvenOdd(0);
            
        }

        static int ParamLielakaisSkaitlis(int a, int b)
        {

            a = Ievade();
            b = Ievade2();

            int lielakais = 0;

            if (a >= b)
            {
                lielakais = a;
            }
            else
            {
                lielakais = b;
            }

            Console.WriteLine("Lielākais skaitlis " + lielakais);

            return lielakais;            
        }

        static int Ievade()
        {
            Console.WriteLine("Ievadi skaitli!");
            String skaitlis = Console.ReadLine();
            int sk = Convert.ToInt32(skaitlis);

            return sk;
        }
        static int Ievade2()
        {
            Console.WriteLine("Ievadi citu skaitli!");
            String skaitlis = Console.ReadLine();
            int sk = Convert.ToInt32(skaitlis);

            return sk;
        }

        static bool EvenOdd(int evenodd)
        {
            evenodd = ParamLielakaisSkaitlis(0, 0);

            if ((evenodd% 2) == 0)
            {
                Console.WriteLine("Lielakais skaitlis ir para skaitlis.");
            }
            else
            {
                Console.WriteLine("Lielakais skiatlis ir nepara skaitlis.");
            }

            bool evenoddbool = Convert.ToBoolean(evenodd);
            return evenoddbool;
    
        }
    }
}
