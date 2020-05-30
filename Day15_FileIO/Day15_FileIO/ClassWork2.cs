using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day15_FileIO
{
    class ClassWork2
    {
        public static void Izpilde()
        {
            List<String> lstTest = new List<string>();
            List<String> lstTestNew = new List<string>();
            Read("Test", lstTest);
            creatNewFile(lstTest);
            Read("Test_new", lstTestNew);
        }

        public static void Read(String fileName, List<string> lstTest)
        {
            String line;
            
            try
            {
                StreamReader sr = new StreamReader(@$"D:\Riga Coding School\Day15_FileIO\ClassWork2\{fileName}.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    lstTest.Add(line);
                    line = sr.ReadLine();
                }
                sr.Close();
                lstTest.Reverse();
            }
            catch (Exception)
            {

                Console.WriteLine("Fails nav atrasts!");
            }
        }
        public static void creatNewFile(List<string> lstTest)
        {
            StreamWriter sw = new StreamWriter(@$"D:\Riga Coding School\Day15_FileIO\ClassWork2\Test_new.txt");
            
            foreach (String text in lstTest)
            {
                sw.WriteLine(text);
            }
            sw.Close();
            
        }
    }
}
