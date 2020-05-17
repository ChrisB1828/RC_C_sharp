using System;
using System.Diagnostics;

namespace Day10_MD
{
    class Program
    {
        static double timeBubble = 0;
        static double timeOddEven = 0;

        static void Main(string[] args)
        {
            //Task_V1 both algorithms in the same methode
            //Task_V2 both algorithms in diferent methodes

            Task_V1(); //if both algorithms are in the same method, then times spent sorting is higher than if both algorithms are in seperate methods
            Task_V2();  

        }

        static void Task_V2() 
        {
            Console.WriteLine("Task_V2");

            int[] numbers = new int[10000];
            RandomNumbers(numbers);

            int[] numbersBubble = new int[10000];
            int[] numbersOddEven = new int[10000];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbersBubble[i] = numbers[i];
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                numbersOddEven[i] = numbers[i];
            }

            Console.WriteLine("------------------");

            Bubble(numbersBubble);


            OddEven(numbersOddEven);

            Console.WriteLine("------------------");

            TimeCompare(timeBubble, timeOddEven);
            Console.WriteLine();

        }

        static void Task_V1() 
        {
            Console.WriteLine("Task_V1");

            int[] numbers = new int[10000];
            RandomNumbers(numbers);

            int[] numbersBubble = new int[10000];
            int[] numbersOddEven = new int[10000];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbersBubble[i] = numbers[i];
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                numbersOddEven[i] = numbers[i];
            }

            //Print(numbers);
            //Print(numbersBubble);
            //Print(numbersOddEven);

            Console.WriteLine("------------------");

            //Print(numbers);

            //Bubble sort 
            Stopwatch time1 = Stopwatch.StartNew();
            time1.Start();

            for (int i = 0; i < numbersBubble.Length - 1; i++)
            {
                for (int j = 0; j < numbersBubble.Length - 1 - i; j++)
                {
                    if (numbers[j] > numbersBubble[j + 1])
                    {
                        int tempNumber = numbersBubble[j];
                        numbersBubble[j] = numbersBubble[j + 1];
                        numbersBubble[j + 1] = tempNumber;
                    }
                }
            }

            time1.Stop();
            Console.WriteLine("(Bubble sort) Time spent sorting: {0}", time1.Elapsed);

            //Print(numbersBubble);

            //Odd Even sort
            Stopwatch time2 = Stopwatch.StartNew();
            time2.Start();

            bool sorted = false;

            while (!sorted)
            {
                sorted = true;

                for (int i = 1; i <= numbersOddEven.Length - 2; i = i + 2)
                {
                    if (numbersOddEven[i] > numbersOddEven[i + 1])
                    {
                        int tempNumber = numbersOddEven[i];
                        numbersOddEven[i] = numbersOddEven[i + 1];
                        numbersOddEven[i + 1] = tempNumber;
                        sorted = false;
                    }
                }
                for (int i = 0; i <= numbersOddEven.Length - 2; i = i + 2)
                {
                    if (numbersOddEven[i] > numbersOddEven[i + 1])
                    {
                        int tempNumber = numbersOddEven[i];
                        numbersOddEven[i] = numbersOddEven[i + 1];
                        numbersOddEven[i + 1] = tempNumber;
                        sorted = false;
                    }
                }
            }

            time2.Stop();
            Console.WriteLine("(Odd Even) Time spent sorting: {0}", time2.Elapsed);
            //Print(numbersOddEven);

            Console.WriteLine("------------------");

            double timeOne = time1.Elapsed.TotalMilliseconds;
            double timeTwo = time2.Elapsed.TotalMilliseconds;

            double timeDif = 0;

            if (timeOne > timeTwo)
            {
                timeDif = timeOne - timeTwo;
            }
            else
            {
                timeDif = timeTwo - timeOne;
            }
            
            Console.WriteLine("Time difference in Task_V1: {0:0,000} seconds.", timeDif);
            Console.WriteLine();
            Console.WriteLine();
        }

        static void OddEven(int[] numbers)
        {
            Stopwatch time = Stopwatch.StartNew();
            time.Start();

            bool sorted = false;

            while (!sorted)
            {
                sorted = true;

                for (int i = 1; i <= numbers.Length - 2; i = i + 2)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        int tempNumber = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = tempNumber;
                        sorted = false;
                    }
                }
                for (int i = 0; i <= numbers.Length - 2; i = i + 2)
                {
                    if (numbers[i] > numbers [i + 1]) 
                    {
                        int tempNumber = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = tempNumber;
                        sorted = false;
                    }
                }
            }

            time.Stop();
            Console.WriteLine("(Odd Even) Time spent sorting: {0}", time.Elapsed);
            timeBubble = time.Elapsed.TotalMilliseconds;

        }

        static void Bubble(int[] numbers)
        {
            Stopwatch time = Stopwatch.StartNew();
            time.Start();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - 1 - i; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int tempNumber = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = tempNumber;
                    }
                }
            }

            time.Stop();
            Console.WriteLine("(Bubble sort) Time spent sorting: {0}", time.Elapsed);

            timeOddEven = time.Elapsed.TotalMilliseconds;

        }

        static void TimeCompare(double timeOne, double timeTwo)
        {
            double timeDif = 0;

            if (timeOne > timeTwo)
            {
                timeDif = timeOne - timeTwo;
            }
            else
            {
                timeDif = timeTwo - timeOne;
            }

            Console.WriteLine("Time difference in Task_V2: {0:0,000} seconds.", timeDif);
            
        }

        static void RandomNumbers(int[] numbers)
        {
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(10001);
            }

        }

       static void Print(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + "|");
            }
            Console.WriteLine();
        }
    }
}
