using System;

namespace Day2_Metodes
{
    class Program
    {
        static void Main(string[] args)
        {
            ParamSample(4, 8);
            ParamSample(9, 8);
            int c = 99;
            ParamSample(c, 12);
            

            int a = InputNumberP("3");
            Console.WriteLine(a);

            Console.WriteLine(InputNumberP("5"));

        }

        static int InputNumberP(String input)
        {
            int number = Convert.ToInt32(input);
            return number;
        }

        static void SampleOutput() //Metodes nosaukumus sākam rakstīt ar Lielo burtu 
                                   //static pagaidām pieņemam un to sapratīsim vēlāk
                                   //void pagaidām pieņemam un to sapratīsim vēlāk
        {
            Console.WriteLine(1);
            Console.WriteLine(2);
            Console.WriteLine(3);
            Console.WriteLine(4);
        }

        static void Greetings()
        {
            Console.WriteLine("Ievadiet savu vārdu!");
            String name = Console.ReadLine();
            Console.WriteLine("Sveiks, " + name);
        }

        static void ThreeStrings()
        {
            String s1 = InputString();
            String s2 = InputString();
            String s3 = InputString();

            Console.WriteLine(s1 + " " +  s2 + " " + s3);
        }

        static String InputString()
        {
            Console.WriteLine("Ievadiet simbolu virkni!");
            String s = Console.ReadLine();

            return s;
        }

        static void BiggestNumber()
        {
            int sk1 = InputNumber();
            int sk2 = InputNumber();
            int sk3 = InputNumber();

            if (sk1 > sk2 && sk1 > sk2)
            {
                Console.WriteLine(sk1);
            }
            else if (sk2 > sk1 && sk2 > sk3)
            {
                Console.WriteLine(sk2);
            }
            else if (sk3 > sk1 && sk3 > sk2)
            {
                Console.WriteLine(sk3);
            }

        }

        static int InputNumber()
        {
            Console.WriteLine("Ievadiet skaitli!");
            String input = Console.ReadLine();

            int sk = Convert.ToInt32(input);
            
            return sk;
        }

        static void SwitchValues()
        {
            int a = 3;
            int b = 9;

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine(a);
            Console.WriteLine(b);

        }

        static int Izvele()
        {
            Console.WriteLine("Lai izvēlētos metodi Greetings nospied 1");
            Console.WriteLine("Lai izvēlētos metodi ThreeStrings nospied 2");
            Console.WriteLine("Lai izvēlētos metodi BiggestNumber nospied 3");
            Console.WriteLine("Lai izvēlētos metodi SwitchValues nospied 4");

            String izvele = Console.ReadLine();

            int izveleint = Convert.ToInt32(izvele);
            int greetings = 1;
            int threestrings = 2;
            int bigestnumber = 3;
            int switchvalues = 4;


            if (izveleint == greetings)
            {
                Greetings();
            }
            else if (izveleint == threestrings)
            {
                ThreeStrings();
            }
            else if (izveleint == bigestnumber)
            {
                BiggestNumber();
            }
            else if (izveleint == switchvalues)
            {
                SwitchValues();
            }

            return izveleint;
        }

        static void piemers()
        {
            Console.WriteLine("Lai izvēlētos metodi Greetings nospied 1");
            Console.WriteLine("Lai izvēlētos metodi ThreeStrings nospied 2");
            Console.WriteLine("Lai izvēlētos metodi BiggestNumber nospied 3");
            Console.WriteLine("Lai izvēlētos metodi SwitchValues nospied 4");

            string choice = Console.ReadLine();

            //if (choice == "1")
            //{
            //    Greetings();
            //}
            // else if (choice == "2")
            //{
            //   ThreeStrings();
            // }
            // else if (choice == "3")
            //{
            //     BiggestNumber();
            //}
            // else if (choice == "4")
            // {
            //     SwitchValues();
            // }
            // else
            // {
            //     Console.WriteLine("nepareiza ievade");
            // }

            //#2 variants

            switch (choice)
            {
                case "1":
                    Greetings();
                    break;
                case "2":
                    ThreeStrings();
                    break;
                case "3":
                    BiggestNumber();
                    break;
                case "4":
                    SwitchValues();
                    break;
                default:
                    Console.WriteLine("Nepareiza ievade");
                    break;

            }
        }

        static void LogiskieOperatori()
            {
                // >
                // <
                // >=
                // <=
                // == lai pārbaudītu vai ir vienāds
                // != lai pārbaudītu vai nav vienāds

                int a = 3;

                if (a != 5)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }

        static void ParamSample (int a, int b)
            {
                Console.WriteLine(a + b);
            }

            
        
    }
}
