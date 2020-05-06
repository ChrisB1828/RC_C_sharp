using System;

namespace Day6_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadiet skaitli! Skaiitlis norādīs uz rindu skaitu, cik rindās tiks izvadītas zvaigznītes");
            int a = Convert.ToInt32(Console.ReadLine());

            Task1.Zvaigznes(a);


        }
    }
}
