using System;

namespace Task1._3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] array = new[] {1, 4, 2, 5, 2, 7, 0, 2};
            Display(array);
            RemoveNumber(ref array, 2);
            Display(array);
        }

        static void RemoveNumber(ref int[] array, int number)
        {
            int newLength = array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    newLength--;
                }
            }

            int[] newArray = new int [newLength];

            var diff = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != number)
                {
                    newArray[i - diff] = array[i];
                }
                else
                {
                    diff++;
                }
            }
        }

        static void Display(int[] mas)
        {
            Console.Write("[ ");
            foreach (var i in mas)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("]");
        }
    }
}

/* program output:

[ 1 4 2 5 2 7 0 2 ]
[ 1 4 5 7 0 ]

 */