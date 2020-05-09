using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Threading;

namespace Day7_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            Task4();
            //TaskList();
            //Formas();
            //StudentsIevadeIzvade(); 
        }

        static void Task4()
        {
            Random random = new Random();
            List<int> numbers = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                numbers.Add(random.Next(100));
            }

            String choice = "";

            while(choice != "3")
            {
                Console.WriteLine("1 - izvadīt sarakstu");
                Console.WriteLine("2 - dzēst");
                Console.WriteLine("3 - Iziet");

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        foreach (int a in numbers)
                        {
                            Console.WriteLine(a);
                        }
                        break;
                    case "2":
                        Console.WriteLine("Kuru dzēst?");
                        int toDelete = Convert.ToInt32(Console.ReadLine());
                        numbers.Remove(toDelete);
                        break;
                    case "3":
                        break;
                    default:
                        Console.WriteLine("Nepareiza ievade");
                        break;
                }
            }

        }
        static int RandomNumber(int min = 1, int max = 101)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        static void TaskList()
        {

            string ievade = "";
            List<String> saraksts = new List<string>();

            while (ievade != "stop")
            {
                Console.WriteLine("Saraksta izveide, lai pārtrauktu izveidot sarakstu rakstiet STOP!");
                ievade = Console.ReadLine();
                ievade = ievade.ToLower();

                if (ievade == "stop")
                {
                    Console.WriteLine();

                    Console.WriteLine("Sarakstā iekļautie String:");
                    saraksts.ForEach(Console.WriteLine); // šo var izmantot, ja nepieciešams tikai izgūt sarakstu

                    //foreach (string b in saraksts)   šo var izmantot lai arī pārbaudītu saraksta elementus
                    //{
                    //    Console.WriteLine(b);
                    //}

                }

                saraksts.Add(ievade);
                
            }
        }

        static void List()
        {
            List<String> a = new List<string>();
            a.Add("aa");
            a.Add("bb");
            a.RemoveAt(0);

            for (int i = 0; i < a.Count; i++)
            {

            }

            foreach (string b in a)
            {
                Console.WriteLine(b);
            }
        }

        static void Formas()
        {
            Console.WriteLine("Lai izvadītu trijstūra malu garumus un perimetru nospiediet - 1");
            Console.WriteLine("Lai izvadītu četrstūra malu garumus un perimetru nospiediet - 2");
            Console.WriteLine("Lai izvadītu piecstūra malu garumus un perimetru nospiediet - 3");
            string izvele = Console.ReadLine();

            int mala1;
            int mala2;
            int mala3;
            int mala4;
            int mala5;

            if (izvele == "1")
            {

                Console.WriteLine("Ievadiet pirmās malas garumu!");
                mala1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ievadiet pirmās malas garumu!");
                mala2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ievadiet pirmās malas garumu!");
                mala3 = Convert.ToInt32(Console.ReadLine());


                Shape tr = new Shape(mala1, mala2, mala3);
                tr.Print();
                Console.WriteLine(tr.Perimetr());
            }
            else if (izvele == "2")
            {
                Console.WriteLine("Ievadiet pirmās malas garumu!");
                mala1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ievadiet pirmās malas garumu!");
                mala2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ievadiet pirmās malas garumu!");
                mala3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ievadiet pirmās malas garumu!");
                mala4= Convert.ToInt32(Console.ReadLine());

                Shape sq = new Shape(mala1, mala2, mala3, mala4);
                sq.Print();
                Console.WriteLine(sq.Perimetr());
            }
            else if (izvele == "3")
            {
                Console.WriteLine("Ievadiet pirmās malas garumu!");
                mala1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ievadiet pirmās malas garumu!");
                mala2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ievadiet pirmās malas garumu!");
                mala3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ievadiet pirmās malas garumu!");
                mala4 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ievadiet pirmās malas garumu!");
                mala5 = Convert.ToInt32(Console.ReadLine());

                Shape penta = new Shape(mala1, mala2, mala3, mala4, mala5);
                penta.Print();
                Console.WriteLine(penta.Perimetr());
            }

        }

        static void StudentsArrayList()
        {
            Students[] student = new Students[5];
            student[0] = new Students("Kristaps", "Balodis", 3);

            for (int i = 0; i < student.Length; i++)
            {
                student[i].print();
            }

            List<Students> st = new List<Students>();
            st.Add(new Students("Kristaps", "Balodis", 3));

            for (int i = 0; i < st.Count; i++)
            {
                st[i].print();
            }

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
