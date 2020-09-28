using System;

namespace Task1._1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var array = new int[10];
            Console.WriteLine("***** Bubble Sort *****");
            GenerateMassive(array);
            Display(array);
            BubbleSort(array);
            Display(array);
            Console.WriteLine();

            Console.WriteLine("***** Insert Sort *****");
            GenerateMassive(array);
            Display(array);
            InsertSort(array);
            Display(array);
            Console.WriteLine();

            Console.WriteLine("***** Selection Sort *****");
            GenerateMassive(array);
            Display(array);
            SelectionSort(array);
            Display(array);
            Console.WriteLine();

            Console.WriteLine("***** Merge Sort *****");
            GenerateMassive(array);
            Display(array);
            MergeSort(array);
            Display(array);
            Console.WriteLine();

            Console.WriteLine("***** Quick Sort *****");
            GenerateMassive(array);
            Display(array);
            QuickSort(array);
            Display(array);
            Console.WriteLine();

            Console.ReadKey();
        }

        static void Swap(ref int x, ref int y)
        {
            var t = x;
            x = y;
            y = t;
        }

        static int Partition(int[] array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }

        static int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            var pivotIndex = Partition(array, minIndex, maxIndex);
            QuickSort(array, minIndex, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }

        static int[] QuickSort(int[] array)
        {
            return QuickSort(array, 0, array.Length - 1);
        }

        static void Merge(int[] array, int lowIndex, int middleIndex, int highIndex)
        {
            var left = lowIndex;
            var right = middleIndex + 1;
            var tempArray = new int[highIndex - lowIndex + 1];
            var index = 0;

            while ((left <= middleIndex) && (right <= highIndex))
            {
                if (array[left] < array[right])
                {
                    tempArray[index] = array[left];
                    left++;
                }
                else
                {
                    tempArray[index] = array[right];
                    right++;
                }

                index++;
            }

            for (var i = left; i <= middleIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }

            for (var i = right; i <= highIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }

            for (var i = 0; i < tempArray.Length; i++)
            {
                array[lowIndex + i] = tempArray[i];
            }
        }

        static int[] MergeSort(int[] array, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                MergeSort(array, lowIndex, middleIndex);
                MergeSort(array, middleIndex + 1, highIndex);
                Merge(array, lowIndex, middleIndex, highIndex);
            }

            return array;
        }

        static int[] MergeSort(int[] array)
        {
            return MergeSort(array, 0, array.Length - 1);
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

        static int[] SelectionSort(int[] array, int currentIndex = 0)
        {
            if (currentIndex == array.Length)
                return array;

            var index = IndexOfMin(array, currentIndex);
            if (index != currentIndex)
            {
                Swap(ref array[index], ref array[currentIndex]);
            }

            return SelectionSort(array, currentIndex + 1);
        }

        static int[] InsertSort(int[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                var key = array[i];
                var j = i;
                while ((j > 1) && (array[j - 1] > key))
                {
                    Swap(ref array[j - 1], ref array[j]);
                    j--;
                }

                array[j] = key;
            }

            return array;
        }

        static int[] BubbleSort(int[] array)
        {
            var len = array.Length;
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }

            return array;
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

    ***** Bubble Sort *****
[ -13 0 4 4 10 11 -10 4 -10 -17 ]
[ -17 -13 -10 -10 0 4 4 4 10 11 ]

    ***** Insert Sort *****
[ -13 0 4 4 10 11 -10 4 -10 -17 ]
[ -13 -17 -10 -10 0 4 4 4 10 11 ]

    ***** Selection Sort *****
[ -13 0 4 4 10 11 -10 4 -10 -17 ]
[ -17 -13 -10 -10 0 4 4 4 10 11 ]

    ***** Merge Sort *****
[ -13 0 4 4 10 11 -10 4 -10 -17 ]
[ -17 -13 -10 -10 0 4 4 4 10 11 ]

    ***** Quick Sort *****
[ -13 0 4 4 10 11 -10 4 -10 -17 ]
[ -17 -13 -10 -10 0 4 4 4 10 11 ]

*/