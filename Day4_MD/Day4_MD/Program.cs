using System;

namespace Day4_MD
{
    class Program
    {
        static void Main(string[] args)
        {
            ReturnRandomNumber();
            //Kapinajums();
            //Piramida();
            //Console.WriteLine(RandomNumber());
        }

        static void Piramida()
        {
            int sk = 1;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(sk);
                    sk++;
                }
                Console.WriteLine();                
            }

            Console.WriteLine();
            Console.WriteLine("Paldies par uzmanību!");

        }
        static void Kapinajums()
        {
            Console.WriteLine("Ievadi divus viencipara skaitļus, lai tos kāpinātu!");
            Console.WriteLine("Ja nevēlies vairs kāpināt skaitļus ieraksti STOP, vai stop un tiks izvadīta skaitļu piramīda");

            int i = 0;

            while (i < 1)
            {
                int pirmaissk = 0;
                int otraissk = 0;
                
                String stop = "";
                

                Console.WriteLine("Ievadi pirmo skaitli!");
                stop = Console.ReadLine();
                stop = stop.ToLower();
                if (stop == "stop")
                {
                    Console.WriteLine();
                    Piramida();
                    break;
                }
                else
                {
                    pirmaissk = Convert.ToInt32(stop);
                }
                
                Console.WriteLine("Ievadi pirmo skaitli!");
                stop = Console.ReadLine();
                stop = stop.ToLower();
                if (stop == "stop")
                {
                    Console.WriteLine();
                    Piramida();
                    break;
                }
                else
                {
                    otraissk = Convert.ToInt32(stop);
                }

                double result = Math.Pow(pirmaissk, otraissk);

                Console.WriteLine("Ievadīto skaitļu kāpinājums ir " + result);

            }
            
        }
        static void ReturnRandomNumber()
        {
            Console.WriteLine("Tev ir 5 iespejas uzminēt sistēmas ģenerēto skaitli!");
            Console.WriteLine("Sistēma ģenerēs vienu skaitli no 1 līdz 10, ja uzminēsi skaitli, tad nonāksi pie nākošā uzdevuma!");
            Console.WriteLine();

            int random = RandomNumber();
            int ievade = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ievadi skaitli no 1-10");
                ievade = Convert.ToInt32(Console.ReadLine());

                if (ievade == random)
                {
                    Console.WriteLine("Tu uzminēji skaitli!");
                    Console.WriteLine();
                    Kapinajums();
                    break;
                }
                else if (i == 4)
                {
                    Console.WriteLine("Sistēmas ģenerētais skaitlis ir " + random);
                    Console.WriteLine("Ja vēlies velreiz mēģināt, tad raksti ATKARTOT, vai atkartot! Ja nevēlies turpināt tad nospied <Enter> pogu!");
                    string atkartot = Console.ReadLine();
                    atkartot = atkartot.ToLower();

                    if (atkartot == "atkartot")
                    {
                        ReturnRandomNumber();                        
                    }
                    else
                    {
                        Console.WriteLine("Paldies par uzmanību!");
                    }
                    break;
                }
            }   
                   
        }
        static int RandomNumber(int min  = 1, int max = 11) // Info ko atcerēties, max pie šī varianta jānorāda par 1 skaitli lielāks kā nepieciešams, jo max vērtība netiks atgriezta 
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
