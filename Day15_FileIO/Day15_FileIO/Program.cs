using System;

namespace Day15_FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassWork2.Izpilde();
        }

        static void KlasesDarbs_1()
        {
            Console.WriteLine("Izveidot jaunu .txt failu - nospied 1 vai rediget esosu failiu nospied - 2:");
            int izvele = Convert.ToInt32(Console.ReadLine());
            switch (izvele)
            {
                case 1:
                    ClassWork.SaveAs();
                    break;
                case 2:
                    ClassWork.Save();
                    break;
                default:
                    break;
            }
        }
    }
}
