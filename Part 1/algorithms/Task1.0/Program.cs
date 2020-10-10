using System;
using System.Linq;

namespace Task1._0
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                int masLength =
                    Convert.ToInt32(Console.ReadLine()); /* all input console information have string format.
                                                        i convert string to int */
                int[] array = new int[masLength]; //create array
                FillMassive(array); //fill the array
                Display(array); //outputting an array with data

                int Sum = new int(); //middle output
                for (int i = 0; i < masLength; i++)
                {
                    Sum += array[i];
                }

                Console.WriteLine(
                    $"Middle v1: {Sum / 2}, Middle v2: {array[masLength / 2 - 1]}"); //two ways to find the middle

                Console.WriteLine($"Minimum: {array.Min()}, Maximum: {array.Max()}"); //First way
                //Console.WriteLine("Minimum: {0}, Maximum: {1}", mas.Min(), mas.Max()); The second way.

                Console.ReadKey(); //the console did not close
            }
            catch (Exception)
            {
                Console.WriteLine("Ops! Something went wrong!");
            }
        }

        static void FillMassive(int[] mas)
        {
            int x1 = mas.Length;
            int x2 = 53;
            int x3 = 44;
            int seed = 3;
            ref int pointer = ref seed;
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = GetRandom(x1, x2, x3, ref pointer);
            }
        }

        static ref int GetRandom(int x1, int x2, int x3, ref int seed)
        {
            seed = (x1 * seed + x2) % x3;
            return ref seed;
        }

        static void Display(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine($"Element {i + 1} = {mas[i]}"); //array output
            }
        }
    }
}