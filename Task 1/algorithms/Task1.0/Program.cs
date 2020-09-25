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
                int[] mas = new int[masLength]; //create array
                FillMassive(masLength, mas); //fill the array
                Display(masLength, mas); //outputting an array with data

                int Sum = new int(); //middle output
                for (int i = 0; i < masLength; i++)
                {
                    Sum += mas[i];
                }

                Console.WriteLine(
                    $"Middle v1: {Sum / 2}, Middle v2: {mas[masLength / 2 - 1]}"); //two ways to find the middle

                Console.WriteLine($"Minimum: {mas.Min()}, Maximum: {mas.Max()}"); //First way
                //Console.WriteLine("Minimum: {0}, Maximum: {1}", mas.Min(), mas.Max()); The second way.

                Console.ReadKey(); //the console did not close
            }
            catch (Exception)
            {
                Console.WriteLine("Ops! Something went wrong!");
            }
        }

        static void FillMassive(int masLength, int[] mas)
        {
            int x1 = masLength;
            int x2 = 53;
            int x3 = 44;
            int seed = 3;
            ref int pointer = ref seed;
            for (int i = 0; i < masLength; i++)
            {
                mas[i] = GetRandom(x1, x2, x3, ref pointer);
            }
        }

        static ref int GetRandom(int x1, int x2, int x3, ref int seed)
        {
            seed = (x1 * seed + x2) % x3;
            return ref seed;
        }

        static void Display(int masLength, int[] mas)
        {
            for (int i = 0; i < masLength; i++)
            {
                Console.WriteLine($"Element {i + 1} = {mas[i]}"); //array output
            }
        }
    }
}