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
            for (int i = min; i <= max; )
            {
                Console.Write($"{i} ");
                i++;
            }
        }
    }
}