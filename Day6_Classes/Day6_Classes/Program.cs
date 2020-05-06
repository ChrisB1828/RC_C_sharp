using System;
using System.Dynamic;
using System.Threading.Tasks;

namespace Day6_Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            Task22();

        }

        static void Task22()
        {
            Console.WriteLine("Ievadiet pirmo skaitli!");
            int sk1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ievadiet otro skaitli!");
            int sk2 = Convert.ToInt32(Console.ReadLine());

            Task1.setA(sk1);
            Task1.setB(sk2);

            Console.WriteLine(Task1.getA() + Task1.getB());
        }

        static void Task1_1()
        {
            Console.WriteLine("Ievadiet skaitli! Skaiitlis norādīs uz rindu skaitu, cik rindās tiks izvadītas zvaigznītes");
            int a = Convert.ToInt32(Console.ReadLine());

            Task1.Zvaigznes(a);
        }
    }
}
