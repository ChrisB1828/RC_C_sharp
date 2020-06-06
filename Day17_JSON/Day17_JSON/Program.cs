using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Day17_JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1.JsonTask();
            //TestJson();
        }
        public static void TestJson()
        {
            List<Car> cars = new List<Car>();

            Car c = new Car("Volvo", "V40 CC", 5);
            Car b = new Car("Volvo", "XC40", 5);
            Car d = new Car("Volvo", "XC90", 5);
            cars.Add(c);
            cars.Add(b);
            cars.Add(d);

            String json = JsonConvert.SerializeObject(cars, Formatting.Indented);

            Console.WriteLine(json);

            List<Car> cars2 = JsonConvert.DeserializeObject<List<Car>>(json);
            Console.WriteLine(cars2[0].brand + " " + cars2[0].model);
            Write(json);
        }
        public static void Write(String json)
        {
            try
            {
                StreamWriter sw = new StreamWriter(@"D:\Riga Coding School\RC_C_sharp\Day17_JSON\Faili\test.json");
                sw.Write(json);
                sw.Close();
            }
            catch 
            {

                Console.WriteLine("Fail!!!");
            }
        }
    }
}
