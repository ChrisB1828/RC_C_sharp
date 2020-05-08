using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_MD
{
    class Students
    {

        public static string vards;
        public static string uzvards;
        public static int kurss;

        public static void setVards(string localVards)
        {
            vards = localVards;
        }

        public static void setUzvards(string localUzvards)
        {
            uzvards = localUzvards;
        }
        public static void setKurss(int localKurss)
        {
            kurss = localKurss;
        }

        public static void Print()
        {
            Console.WriteLine(vards + " " + uzvards + " " + kurss + ". kursa students");
        }
        
    }
}
