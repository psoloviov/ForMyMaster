using System;
using System.Linq;

namespace Task1._0
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); /*в шарпе все данные которые введены в консоль имеют
                                                        имеют тип данных string, от того и вводимое число 
                                                        сразу конвертируется в int */

            int[] mas = new int[n]; //создаю масив с пользовательскими данными
            GenerateMassive(n, mas); //заполняю массив случайными числами
            Display(n, mas); //вывожу массив с данными на экран

            int Sum = new int(); // для вывода среднего числа
            for (int i = 0; i < n; i++)
            {
                Sum += mas[i];
            }

            Console.WriteLine(
                $"Middle v1: {Sum / 2}, Middle v2: {mas[n / 2 - 1]}"); //не было уточнения какое именно "среднее"

            Console.WriteLine($"Minimum: {mas.Min()}, Maximum: {mas.Max()}"); //перавый способ вывода, ниже второй
            //Console.WriteLine("Minimum: {0}, Maximum: {1}", mas.Min(), mas.Max());

            Console.ReadKey(); //чтобы не закрывалась консоль
        }

        static void GenerateMassive(int n, int[] mas)
        {
            Random random = new Random(); //переменная имеющая случайное число
            for (int i = 0; i < n; i++)
            {
                mas[i] = random.Next(-20, 20); //присваиваю рандом число от -20 до 20
            }
        }

        static void Display(int n, int[] mas)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Element {i + 1} = {mas[i]}"); //вывел числа массива
            }
        }
    }
}