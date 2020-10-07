using System;

namespace Task2._1
{
    public class RandomArray
    {
        private int[] valuesRange;
        private Random rand = new Random();
        private int sum = new int();

        public RandomArray(int[] numbers, int[] weight)
        {
            foreach (var i in weight)
            {
                sum += i;
            }

            valuesRange = new int[sum];
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


        public int getRandom()
        {
            int randomNumber = rand.Next(0, valuesRange.Length - 1);
            int number = valuesRange[randomNumber];
            return number;
        }
    }
}