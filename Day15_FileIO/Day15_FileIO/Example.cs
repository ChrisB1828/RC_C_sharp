using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day15_FileIO
{
    class Example
    {
        public static void Read()
        {
            String line;

            try
            {
                StreamReader sr = new StreamReader(@"C:\Users\Kbalo\Desktop\TextWrite.txt");

                line = sr.ReadLine();

                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();

            }
            catch { Console.WriteLine("Nezidevās atvērt failu!"); }
            
        }

        public static void Write()
        {
            try
            {
                StreamWriter sw = new StreamWriter(@"C:\Users\Kbalo\Desktop\TextWrite.txt", true);

                sw.WriteLine("Hello123");
                sw.WriteLine("From the other side123");
                sw.Close();
            }
            catch (Exception)
            {

                Console.WriteLine("Neizdevās ierakstīt failā");
            }
        }
    }
}
