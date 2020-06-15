using System;

namespace Day21_SQL
{
    class Program
    {
        static void Main(string[] args)
        {
            DBConnection con = new DBConnection();
            con.Connect();
            con.GetEmployees();
        }
    }
}
