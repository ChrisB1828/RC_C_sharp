using System;

namespace Day6_MD
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentsId();
            //CalculatorIevadeIzvade();
        }

        static void StudentsId()
        {
            Console.WriteLine("Ievadiet vārdu!");
            string vardsIevade = Console.ReadLine();

            Console.WriteLine("Ievadiet uzvārdu!");
            string uzvardsIevade = Console.ReadLine();

            Console.WriteLine("Ievadiet kursu kurā šobrīd studējiet, ievadot skaitlisku vērtību!");
            string kurssStringIevade = Console.ReadLine();

            Console.WriteLine();

            int kurssIevade = 0;

            try
            {
                kurssIevade = Convert.ToInt32(kurssStringIevade);

                if (kurssIevade != 1 && kurssIevade != 2 && kurssIevade != 3)
                {
                    
                    Console.WriteLine("Ievadīts nepareizs kursa numurs. Atgādinām, ka kursa numuram ir jābūt skaitlim no 1 līdz 3!");
                    Console.WriteLine("Lūdzam atkārtoti ievadīt informāciju par sevi!");
                    Console.WriteLine();
                    StudentsId();
                }
                else
                {
                    Students.setVards(vardsIevade);
                    Students.setUzvards(uzvardsIevade);
                    Students.setKurss(kurssIevade);

                    Students.Print();
                }

            }
            catch (Exception)
            {

                    Console.WriteLine("Ievadītā vērtība nav skaitliska. Atgādinām, ka kursa numuram ir jābūt skaitlim no 1 līdz 3!");
                    Console.WriteLine("Lūdzam atkārtoti ievadīt informāciju par sevi!");
                    Console.WriteLine();
                    StudentsId();

            }
        }


        static void CalculatorIevadeIzvade()
        {
            Console.WriteLine("Ja vēlies saskaitīt divus skaitļus tad nospied - 1");
            Console.WriteLine("Ja vēlies atņemt divus skaiļus - 2");
            Console.WriteLine("Ja vēlies reizināt divus skaitļus tad nospied - 3");
            Console.WriteLine("Ja vēlies dalīt divus skaitļus tad nospied - 4");
            Console.WriteLine("Ja vēlies iegūt atlikumu no skaitļa tad nospied - 5");
            Console.WriteLine("Ja velies noteikt skaitli 'n' pakāpē tad nospied - 6");
            Console.WriteLine("Ja velies pārtraukt kalkulatora darbību, tad raksti STOP");
            Console.WriteLine();

            string izvele = Console.ReadLine();
            izvele = izvele.ToLower();

            Console.WriteLine();

            if (izvele == "stop")
            {
                Console.WriteLine("Paldies par uzmanību!");
            }
            else if (izvele == "1")
            {
                Console.WriteLine("Ievadiet pirmo skaitli!");
                int sk1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ievadiet otro skaitli!");
                int sk2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ievadīto skaitļu summa ir " + Calculator.Addition(sk1, sk2));
                Console.WriteLine();

                CalculatorIevadeIzvade();
            }
            else if (izvele == "2")
            {
                Console.WriteLine("Ievadiet pirmo skaitli!");
                int sk1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ievadiet otro skaitli!");
                int sk2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ievadīto skaitļu rezultāts ir " + Calculator.Subtraction(sk1, sk2));
                Console.WriteLine();

                CalculatorIevadeIzvade();
            }
            else if (izvele == "3")
            {
                Console.WriteLine("Ievadiet pirmo skaitli!");
                int sk1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ievadiet otro skaitli!");
                int sk2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ievadīto skaitļu rezultāts ir " + Calculator.Multiplication(sk1, sk2));
                Console.WriteLine();

                CalculatorIevadeIzvade();
            }
            else if (izvele == "4")
            {
                Console.WriteLine("Ievadiet pirmo skaitli!");
                int sk1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ievadiet otro skaitli!");
                int sk2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ievadīto skaitļu rezultāts ir " + Calculator.Division(sk1, sk2));
                Console.WriteLine();

                CalculatorIevadeIzvade();
            }
            else if (izvele == "5")
            {
                Console.WriteLine("Ievadiet pirmo skaitli!");
                int sk1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ievadiet otro skaitli!");
                int sk2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ievadīto skaitļu rezultāts ir " + Calculator.Reminder(sk1, sk2));
                Console.WriteLine();

                CalculatorIevadeIzvade();
            }
            else if (izvele == "6")
            {
                Console.WriteLine("Ievadiet pirmo skaitli!");
                int sk1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ievadiet otro skaitli!");
                int sk2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ievadīto skaitļu rezultāts ir " + Calculator.Pakape(sk1, sk2));
                Console.WriteLine();

                CalculatorIevadeIzvade();
            }
            else
            {
                Console.WriteLine("Nepareiza ievade!");
                Console.WriteLine("Ievadiet savu izvēli atkārtoti!");
                Console.WriteLine();

                CalculatorIevadeIzvade();
            }

        }

    }
}
