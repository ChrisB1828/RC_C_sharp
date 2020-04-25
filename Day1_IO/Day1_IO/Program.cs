using System;

namespace Day1_IO
{
    class Program
    {//sakums
        static void Main(string[] args)
        {
            //Izvade
            Console.WriteLine("Hello World!");
            Console.WriteLine("Mani sauc Kristaps");
            //-------------

            //int - vesels skaitlis
            //float , double - skaitlis ar komatu
            //char - viens simbols
            //string - simbolu virkne
            //bool - true vai false

            int a; //mainiga dekleracija - daram 1x
            a = 7; //mainiga definicija - daram cik reižu gribam

            int c = 5; //deklaracija + definicija

            int result = a + c;

            Console.WriteLine(c + result);
            
            string b;
            b = "3345sasd";
            Console.WriteLine(b);

            a = 99;
            result = a + c;
            Console.WriteLine(result);
            //---------------

            Console.WriteLine("ievadiet simbolu virkni!");
            string ievade = Console.ReadLine();

            
            string combined = "           " + ievade + ", hello world!";

            Console.WriteLine(combined);

        }
    }//beigas
}
