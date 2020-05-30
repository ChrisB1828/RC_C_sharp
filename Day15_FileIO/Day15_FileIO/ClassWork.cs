using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day15_FileIO
{
    class ClassWork
    {
        public static void Read(String fileName)
        {
            String line;

            try
            {
                StreamReader sr = new StreamReader(@$"D:\Riga Coding School\Day15_FileIO\{fileName}.txt");
                
                line = sr.ReadLine();

                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();


            }
            catch (Exception)
            {

                Console.WriteLine("Neizdevas atvert failu!");
            }
        }
        public static void Editing(string fileName)
        {
            String line;

            try
            {
                StreamReader sr = new StreamReader(@$"D:\Riga Coding School\Day15_FileIO\{fileName}.txt");

                line = sr.ReadLine();
                List<string> listOfFileText = new List<string>();

                while (line != null)
                {
                    listOfFileText.Add(line);
                    line = sr.ReadLine();
                }
                sr.Close();

                Console.WriteLine("Ievadiet 1, ja velaties dzest tekstu!");
                Console.WriteLine("Ievadiet 2, ja velaties rediget tekstu!");
                Console.WriteLine("Ievadiet 3, ja velaties papildinat tekstu!");
                String izveleString = Console.ReadLine();
                int izvele = 0;
                try
                {
                    izvele = Convert.ToInt32(izveleString);
                }
                catch 
                {
                    Console.WriteLine("Nav ievadita skaitliska vertiba");
                }

                switch (izvele)  
                {
                    case 1:
                        Console.WriteLine("Ievadiet indeksu teksta linijai kuru velaties dzest:");
                        int indeks = Convert.ToInt32(Console.ReadLine());
                        string lineDelete = listOfFileText[indeks];
                        listOfFileText.Remove(lineDelete);
                        StreamWriter sw = new StreamWriter(@$"D:\Riga Coding School\Day15_FileIO\{fileName}.txt");
                        foreach (string item in listOfFileText)
                        {
                            sw.WriteLine(item); 
                        }
                        sw.Close();
                        break;
                    case 2:
                        Console.WriteLine("Ievadiet indeksu teksta linijai kuru velaties rediget:");
                        int indeksR = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ievadiet jauno teksta vertibu:");
                        string lineEdit = Console.ReadLine();
                        listOfFileText[indeksR] = lineEdit;
                        StreamWriter sw2 = new StreamWriter(@$"D:\Riga Coding School\Day15_FileIO\{fileName}.txt");
                        foreach (string item in listOfFileText)
                        {
                            sw2.WriteLine(item);
                        }
                        sw2.Close();
                        break;
                    case 3:
                        Console.WriteLine("Ievadiet tekstu ar kuru velaties papildinat failu:");
                        string writeLine = Console.ReadLine();
                        StreamWriter sw3 = new StreamWriter(@$"D:\Riga Coding School\Day15_FileIO\{fileName}.txt", true);
                        try
                        {   
                            sw3.WriteLine(writeLine);
                            sw3.Close();
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                        break;
                    default:
                        break;
                }
                Console.WriteLine("---------------------------");
                Console.WriteLine("Tests");
                listOfFileText.ForEach(Console.WriteLine);

            }
            catch (Exception)
            {

                Console.WriteLine("Neizdevas atvert failu!");
            }
        }

        public static void SaveAs()
        {
            try
            {
                Console.WriteLine("Ievadiet jauna faila nosaukumu:");
                string fileName = Console.ReadLine();

                if (@"D:\Riga Coding School\Day15_FileIO".Contains(@$"D:\Riga Coding School\Day15_FileIO\{fileName}.txt"))
                {
                    Console.WriteLine("Fails nosaukums jau eksiste!");
                }
                else
                {
                    StreamWriter sw = new StreamWriter(@$"D:\Riga Coding School\Day15_FileIO\{fileName}.txt");
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("Faila esosa informacija:");
                    Read(fileName);
                    Console.WriteLine("---------------------------");
                    Editing(fileName);
                    Console.WriteLine("---------------------------");
                }
                

            }
            catch (Exception)
            {
                Console.WriteLine("Neizdevas saglabat failu!");
            }
        }
        public static void Save()
        {
            try
            {
                Console.WriteLine("Ievadiet faila nosaukumu kuru velaties rediget:");
                String fileName = Console.ReadLine();

                Console.WriteLine("---------------------------");
                Console.WriteLine("Faila esosa informacija:");
                Read(fileName);
                Console.WriteLine("---------------------------");
                Editing(fileName);
                Console.WriteLine("---------------------------");


            }
            catch (Exception)
            {

                Console.WriteLine("Fails nav atrasts!");
            }
        }
    }
}
