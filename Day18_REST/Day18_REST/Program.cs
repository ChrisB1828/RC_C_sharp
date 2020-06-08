using System;
using System.Net;
using Newtonsoft.Json;

namespace Day18_REST
{
    class Program
    {
        static void Main(string[] args)
        {
            String url = "http://dummy.restapiexample.com/api/v1/employees";

            WebClient client = new WebClient();

            String response = client.DownloadString(url);

            //Console.WriteLine(response);

            Container rec = JsonConvert.DeserializeObject<Container>(response);

            if (rec.status == "success")
            {
                foreach (Employee e in rec.data)
                {
                    Console.WriteLine(e.employee_name);
                }
            }
        }
    }
}
