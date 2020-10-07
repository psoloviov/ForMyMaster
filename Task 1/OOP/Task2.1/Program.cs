using System;

namespace Task2._1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = new[] {1, 2, 3};
            int[] weight = new[] {1, 2, 10};

            var r = new RandomArray(numbers, weight);
            
            var one = new int();
            var two = new int();
            var three = new int();
            
            for (int i = 0; i < 13; i++)
            {
                int x = r.getRandom();
                switch (x)
                {
                    case 1:
                        one++;
                        break;
                    case 2:
                        two++;
                        break;
                    case 3:
                        three++;
                        break;
                }
            }

            Console.WriteLine($"Number one dropped {one} times");
            Console.WriteLine($"Number two dropped {two} times");
            Console.WriteLine($"Number three dropped {three} times");
        }
    }
}