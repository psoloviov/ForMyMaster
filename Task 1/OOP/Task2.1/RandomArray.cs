using System;

namespace Task2._1
{
    public class RandomArray
    {
        private int[] valuesRange;
        private Random rand = new Random();

        public RandomArray(int[] numbers, int[] weight)
        {
            var weightsSum = new int();
            foreach (var i in weight)
            {
                weightsSum += i;
            }

            valuesRange = new int[weightsSum];
            int index = 0;

            for (int i = 0; i < weight.Length; i++)
            {
                for (int j = 0; j < weight[i]; j++)
                {
                    valuesRange[index] = numbers[i];
                    index++;
                }
            }
        }

        public void PrintArray()
        {
            for (int i = 0; i < valuesRange.Length; i++)
            {
                Console.Write($"{valuesRange[i]} ");
            }

            Console.WriteLine();
        }

        public int[] GetRandomArray()
        {

            for (int i = valuesRange.Length - 1; i >= 1; i--)
            {
                int j = rand.Next(i + 1);
                var tmp = valuesRange[j];
                valuesRange[j] = valuesRange[i];
                valuesRange[i] = tmp;
            }

            return valuesRange;
        }

        public int GetRandomNumber()
        {
            int randomNumber = rand.Next(0, valuesRange.Length - 1);
            int number = valuesRange[randomNumber];
            return number;
        }
    }
}