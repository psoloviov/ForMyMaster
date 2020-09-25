using System;

namespace Task1._1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var array = new int[10];
            GenerateMassive(array);
            BubbleSort(array);
            Display(array);
        }
        
        static int IndexOfMin(int[] array, int n)
        {
            int result = n;
            for (var i = n; i < array.Length; ++i)
            {
                if (array[i] < array[result])
                {
                    result = i;
                }
            }

            return result;
        }

        static int[] SelectionSort(int[] mas, int currentIndex = 0)
        {
            if (currentIndex == mas.Length)
                return mas;

            var index = IndexOfMin(mas, currentIndex);
            if (index != currentIndex)
            {
                var tmp = mas[index];
                mas[index] = mas[currentIndex];
                mas[currentIndex] = tmp;
            }

            return SelectionSort(mas, currentIndex + 1);
        }

        static void InsertSort(int[] mas)
        {
            for (var i = 1; i < mas.Length; i++)
            {
                var key = mas[i];
                var j = i;
                while ((j > 1) && (mas[j - 1] > key))
                {
                    var temp = mas[j - 1];
                    mas[j - 1] = mas[j];
                    mas[j] = temp;
                    j--;
                }

                mas[j] = key;
            }
        }

        static void BubbleSort(int[] mas)
        {
            for (var i = 0; i < mas.Length; i++)
            {
                for (var j = 0; j < mas.Length - i - 1; j++)
                {
                    if (mas[j] > mas[j + 1])
                    {
                        var tmp = mas[j];
                        mas[j] = mas[j + 1];
                        mas[j + 1] = tmp;
                    }
                }
            }
        }

        static void GenerateMassive(int[] mas)
        {
            var random = new Random();
            for (var i = 0; i < 10; i++)
            {
                mas[i] = random.Next(-20, 20);
            }
        }

        static void Display(int[] mas)
        {
            for (var i = 0; i < mas.Length; i++)
            {
                Console.WriteLine($"Element {i + 1} = {mas[i]}"); //array output
            }
        }
    }
}