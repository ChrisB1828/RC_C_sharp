using System;
using System.Collections.Generic;
using System.Text;

namespace Day10_Algorithms
{
    class Bubble
    {

        public void EvenOdd()
        {
            int[] EvenOddNumbers = new int[10];

            for (int i = 0; i < EvenOddNumbers.Length; i++)
            {
                EvenOddNumbers[i] = RandomNumber();
            }

            foreach (int a in EvenOddNumbers)
            {
                Console.Write(a + " ");
            }

            Console.WriteLine();
            Console.WriteLine("-------------------");
 
            bool sorted = false;

            while (!sorted)
            {
                sorted = true;

                for (int i = 1; i <= EvenOddNumbers.Length - 2; i = i + 2)
                {
                    if (EvenOddNumbers[i] > EvenOddNumbers[i + 1])
                    {
                        int tempNumberHolder = EvenOddNumbers[i];
                        EvenOddNumbers[i] = EvenOddNumbers[i + 1];
                        EvenOddNumbers[i + 1] = tempNumberHolder;
                        sorted = false;
                    }
                }
                for (int i = 0; i <= EvenOddNumbers.Length - 2; i = i + 2)
                {
                    if (EvenOddNumbers[i] > EvenOddNumbers[i + 1])
                    {
                        int tempNumberHolder = EvenOddNumbers[i];
                        EvenOddNumbers[i] = EvenOddNumbers[i + 1];
                        EvenOddNumbers[i + 1] = tempNumberHolder;
                        sorted = false;
                    }
                }
            }

            foreach (int a in EvenOddNumbers)
            {
                Console.Write(a + " ");
            }

            Console.WriteLine();
            Console.WriteLine("-------------------");
        }

        public void BubbleNumber()
        {
            int [] bubbleNumbers = new int [10];
            
            for (int i = 0; i < bubbleNumbers.Length; i++)
            {
                bubbleNumbers[i] = RandomNumber();
            }

            foreach (int a in bubbleNumbers)
            {
                Console.Write(a + " ");
            }

            Console.WriteLine();
            Console.WriteLine("-------------------");

            for (int i = 0; i < bubbleNumbers.Length-1; i++)
            {
                for (int j = 0; j < bubbleNumbers.Length-i-1; j++)
                {
                    if (bubbleNumbers[j] > bubbleNumbers[j + 1])
                    {
                        int tempNumberHolder = bubbleNumbers[j];
                        bubbleNumbers[j] = bubbleNumbers[j + 1];
                        bubbleNumbers[j + 1] = tempNumberHolder;
                    }
                }
            }

            foreach (int a in bubbleNumbers)
            {
                Console.Write(a + " ");
            }
            
            Console.WriteLine();
            Console.WriteLine("-------------------");

        }

        public int RandomNumber(int min = 0, int max = 41)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        
    }
}
