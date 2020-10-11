using System;

namespace Task_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var array = new int[5];
            var index = new int();
            string str = null;
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
                            array[index++] = Int32.Parse(str);
                            str = null;
                        }
                        break;

                    // case ConsoleKey.OemMinus:
                    //     str += '-';
                    //     break;

                    default:
                        Console.WriteLine(" Упс, кажется вы ввели не число!");
                        break;
                }
            } while (Convert.ToInt32(str) > 0 || str == null);

            Console.WriteLine();
            Console.Write("Вывод чисел: ");
            foreach(var n in array)
                Console.Write($"{n} ");
        }
    }
}