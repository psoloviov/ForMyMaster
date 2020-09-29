using System;

namespace Task2._1
{
    public class RandomArray
    {
        private int[] valuesRange;

        public RandomArray(int[] numbers, int[] weight)
        {
            int sum = 0;    
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
            Random rand = new Random();
            int randomNumber = rand.Next() % (valuesRange.Length - 1);
            return valuesRange[randomNumber];
        }
    }
}