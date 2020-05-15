using System;
using System.Collections.Generic;
using System.Text;

namespace Day10_Algorithms
{
    class Bubble
    {


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

            int tempNumberHolder = 0;

            for (int i = 0; i < bubbleNumbers.Length-1; i++)
            {
                for (int j = 0; j < bubbleNumbers.Length-i-1; j++)
                {
                    if (bubbleNumbers[j] > bubbleNumbers[j + 1])
                    {
                        tempNumberHolder = bubbleNumbers[j];
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
