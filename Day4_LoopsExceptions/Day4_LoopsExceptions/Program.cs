using System;

namespace Day4_LoopsExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            TestParse();
        }

        static void TestParse()
        {
            //int sk;
            Double sk;

            try
            {
                Console.WriteLine("Ievadiet skaitli");
                sk = Convert.ToDouble(Console.ReadLine()); //skaitlis ar komatu
                Console.WriteLine("Tiekam talak!");
                Console.WriteLine("Success " + sk);
            }
            catch (Exception ex)
            {
                //sk = 0;
                Console.WriteLine(ex.Message); //
                Console.WriteLine("Exceptions!");
                TestParse(); //uzmanígi, jo var iejiet bezgalígajá loop
            }
            
            
        }
        static void WhileExample()
        {
            String choice = "";

            while (choice != "n")
            {
                Console.WriteLine("ievadiet tekstu");
                choice = Console.ReadLine();

                Console.WriteLine("Yay");
            }

            do
            {
                Console.WriteLine("ievadiet tekstu");
                choice = Console.ReadLine();

                Console.WriteLine("Yay");

            } while (choice != "n");
        }
    }
}
