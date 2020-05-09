using System;

namespace Day7_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentsIevadeIzvade(); 
        }

        static void StudentsTest()
        {
            Console.WriteLine("Ievadiet vardu!");
            string name = Console.ReadLine();

            Console.WriteLine("Ievadiet uzvardu!");
            string surname = Console.ReadLine();

            int course;

            Console.WriteLine("ievadiet kursu!");
            try
            {
                course = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Nepareiza ievade");
                return;
            }
        }
      
        static void StudentsIevadeIzvade() // pieļauju, ka ir labāks veids kā izveidot divus objektus, izmantojot loop jau nevarēs atkārtoti izsaukt dažados izveidotos objektus? vai šeit būtu jāizmanto array?
        {

            Console.WriteLine("Ievadiet vardu!");
            string name = Console.ReadLine();

            Console.WriteLine("Ievadiet uzvardu!");
            string surname = Console.ReadLine();

            int course;

            Console.WriteLine("ievadiet kursu!");
            try
            {
                course = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Nepareiza ievade");
                return;
            }

            Console.WriteLine();
            Students st1 = new Students(name, surname, course);
            st1.print();
            Console.WriteLine();


            Console.WriteLine("Ievadiet vardu!");
            name = Console.ReadLine();

            Console.WriteLine("Ievadiet uzvardu!");
            surname = Console.ReadLine();

            Console.WriteLine("ievadiet kursu!");
            try
            {
                course = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Nepareiza ievade");
                return;
            }

            Console.WriteLine();
            Students st2 = new Students(name, surname, course);
            st2.print();
            Console.WriteLine();


            st1.print();
            st2.print();

        }

        static void Trijstūris()
        {
            Trijsturis tr1 = new Trijsturis(4, 5, 2);
            tr1.mala1 = 44;
            tr1.Pirnt();

            Trijsturis tr2 = new Trijsturis(1, 2, 2);
            tr2.Pirnt();
        }
    }
}
