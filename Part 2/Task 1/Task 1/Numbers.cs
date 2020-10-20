using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_1
{
    public class Numbers
    {
        private static string _str = null;
        private static readonly List<int> List = new List<int>();

        public Numbers()
        {
        }

        public void EnterNumbers()
        {
            Console.Write("Введите положительные числа: ");
            var validNumber = true;
            do
            {
                var key = Console.ReadKey().Key;

                switch (key)
                {
                    case ConsoleKey.NumPad1:
                    case ConsoleKey.D1:
                        _str += 1;
                        break;

                    case ConsoleKey.NumPad2:
                    case ConsoleKey.D2:
                        _str += 2;
                        break;

                    case ConsoleKey.NumPad3:
                    case ConsoleKey.D3:
                        _str += 3;
                        break;

                    case ConsoleKey.NumPad4:
                    case ConsoleKey.D4:
                        _str += 4;
                        break;

                    case ConsoleKey.NumPad5:
                    case ConsoleKey.D5:
                        _str += 5;
                        break;

                    case ConsoleKey.NumPad6:
                    case ConsoleKey.D6:
                        _str += 6;
                        break;

                    case ConsoleKey.NumPad7:
                    case ConsoleKey.D7:
                        _str += 7;
                        break;

                    case ConsoleKey.NumPad8:
                    case ConsoleKey.D8:
                        _str += 8;
                        break;

                    case ConsoleKey.NumPad9:
                    case ConsoleKey.D9:
                        _str += 9;
                        break;

                    case ConsoleKey.NumPad0:
                    case ConsoleKey.D0:
                        if (_str == null)
                            validNumber = false;
                        else
                            _str += 0;
                        break;

                    case ConsoleKey.Spacebar:
                        if (_str != null)
                        {
                            var tmp = int.Parse(_str);
                            if (tmp > 0)
                            {
                                List.Add(tmp);
                                _str = null;
                            }
                            else
                            {
                                validNumber = false;
                            }
                        }

                        break;

                    case ConsoleKey.OemMinus:
                        if (_str == null) _str += "-";
                        else
                        {
                            Error();
                            _str = null;
                        }

                        break;

                    default:
                        Error();
                        Console.Write("Попробуйте снова:");
                        _str = null;
                        break;
                }
            } while (validNumber);

            Console.WriteLine();
        }

        public void Output()
        {
            var noneOutput = true;
            do
            {
                Console.Write("Введите элемент по которому делить: ");
                if (int.TryParse(Console.ReadLine(), out var number))
                    if (List.Count > number && number >= 0)
                    {
                        Console.Write("Меньше выбранного числа: ");
                        foreach (var item in List.Where(item => item <= List[number]))
                            Console.Write($"{item} ");
                        Console.WriteLine();
                        Console.Write("Больше выбранного числа: ");
                        foreach (var item in List.Where(item => item > List[number]))
                            Console.Write($"{item} ");
                        Console.WriteLine();
                        noneOutput = false;
                    }
                    else
                    {
                        Error();
                    }
                else
                {
                    Error();
                }
            } while (noneOutput);
        }

        private static void Error()
        {
            Console.WriteLine("Error!");
        }
    }
}