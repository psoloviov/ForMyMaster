using System;
using System.Collections.Generic;

namespace Task_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var list = new LinkedList<int>();
            EnterNumbers(ref list);
            
            Console.Write("Введите число, которым хотите разделить массив: ");
            var userInput = int.Parse(Console.ReadLine());
            Output(ref list, userInput);
            Console.Write("Вывод чисел: ");
            foreach (var item in list)
                Console.Write($"{item} ");
        }

        public static void Output(ref LinkedList<int> list, int userInput)
        {
            Console.Write("Числа больше: ");
            foreach (var item in list)
            {
                if (item <= userInput)
                    Console.Write($"{item} ");
            }

            Console.WriteLine();
            Console.Write("Числа меньше: ");
            foreach (var item in list)
            {
                if (item > userInput)
                    Console.Write($"{item} ");
            }

            Console.WriteLine();
        }

        public static void EnterNumbers(ref LinkedList<int> list)
        {
            Console.Write("Введите положительные числа: ");
            string str = null;
            bool validNumber = true;
            do
            {
                var key = Console.ReadKey().Key;

                switch (key)
                {
                    case ConsoleKey.NumPad1:
                    case ConsoleKey.D1:
                        str += 1;
                        break;

                    case ConsoleKey.NumPad2:
                    case ConsoleKey.D2:
                        str += 2;
                        break;

                    case ConsoleKey.NumPad3:
                    case ConsoleKey.D3:
                        str += 3;
                        break;

                    case ConsoleKey.NumPad4:
                    case ConsoleKey.D4:
                        str += 4;
                        break;

                    case ConsoleKey.NumPad5:
                    case ConsoleKey.D5:
                        str += 5;
                        break;

                    case ConsoleKey.NumPad6:
                    case ConsoleKey.D6:
                        str += 6;
                        break;

                    case ConsoleKey.NumPad7:
                    case ConsoleKey.D7:
                        str += 7;
                        break;

                    case ConsoleKey.NumPad8:
                    case ConsoleKey.D8:
                        str += 8;
                        break;

                    case ConsoleKey.NumPad9:
                    case ConsoleKey.D9:
                        str += 9;
                        break;

                    case ConsoleKey.NumPad0:
                    case ConsoleKey.D0:
                        str += 0;
                        break;

                    case ConsoleKey.Spacebar:
                        if (str != null)
                        {
                            int tmp = Int32.Parse(str);
                            if (tmp > 0)
                            {
                                list.AddLast(tmp);
                                str = null;
                            }
                            else
                            {
                                validNumber = false;
                            }
                        }

                        break;

                    case ConsoleKey.OemMinus:
                        str += '-';
                        break;

                    default:
                        Console.WriteLine(" Упс, кажется вы ввели не число!");
                        Console.Write("Попробуйте снова:");
                        str = null;
                        break;
                }
            } while (validNumber);

            Console.WriteLine();
        }
    }
}