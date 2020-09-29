using System;

namespace Task2._1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = new[] {1, 2, 3};
            int[] weight = new[] {1, 2, 10};
            RandomArray rand = new RandomArray(numbers, weight);

            

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(rand.getRandom());
            }
        }
    }
}