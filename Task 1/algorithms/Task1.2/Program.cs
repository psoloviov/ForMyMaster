using System;

namespace Task1._2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var min = Convert.ToInt32(Console.ReadLine());
                var max = Convert.ToInt32(Console.ReadLine());
                DisplayRange(min, max);
            }
            catch (Exception)
            {
                Console.WriteLine("Wops! Something went wrong!");
            }

            Console.ReadKey();
        }

        static void DisplayRange(int min, int max)
        {
            for (int i = min; i <= max; i++)
            {
                bool b = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0 & i % 1 == 0)
                    {
                        b = false;
                    }
                }

                if (b)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}