using System;
using System.Linq;

namespace Task1._0
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int masLength = Convert.ToInt32(Console.ReadLine()); /* all input console information have string format.
                                                        i convert string to int */

            int[] mas = new int[masLength]; //create array
            GenerateMassive(masLength, mas); //fill the array
            Display(masLength, mas); //outputting an array with data

            int Sum = new int(); //middle output
            for (int i = 0; i < masLength; i++)
            {
                Sum += mas[i];
            }

            Console.WriteLine(
                $"Middle v1: {Sum / 2}, Middle v2: {mas[masLength / 2 - 1]}"); //two ways to find the middle

            Console.WriteLine($"Minimum: {mas.Min()}, Maximum: {mas.Max()}"); //First way
            //Console.WriteLine("Minimum: {0}, Maximum: {1}", mas.Min(), mas.Max()); The second way is presented below.

            Console.ReadKey(); //the console did not close
        }

        static void GenerateMassive(int masLength, int[] mas)
        {
            
            Random random = new Random(); //переменная имеющая случайное число
            for (int i = 0; i < masLength; i++)
            {
                mas[i] = random.Next(-20, 20); //присваиваю рандом число от -20 до 20
            }
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