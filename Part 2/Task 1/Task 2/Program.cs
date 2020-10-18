﻿using System;
using System.Collections.Generic;
using System.IO;

namespace Task_2
{
    internal class Program
    {
        struct table
        {
            public string Name;
            public string Value;
        }

        public static void Main(string[] args)
        {
            string path = Console.ReadLine();
            if (File.Exists(path))
            {
                var list = new List<table>();
                foreach (string s in File.ReadAllLines(path))
                    list.Add(new table() {Name = s.Split(' ')[0], Value = s.Split(' ')[1]});
                string str = Console.ReadLine();
                while (!int.TryParse(str, out int tmp))
                {
                    Console.WriteLine("Вы ввели некоррекное число");
                    str = Console.ReadLine();
                }
                FilterAge(list, Convert.ToInt32(str));
            }
            else
            {
                Console.WriteLine("Такого файла не существует!");
            }
        }

        static void FilterAge(List<table> list, int upperAge)
        {
            var lineNumber = new int();
            foreach (var str in list)
            {
                if (int.TryParse(str.Value, out int age))
                {
                    if (upperAge <= age)
                    {
                        Console.WriteLine($"{str.Name} {age}"); 
                    }
                    lineNumber++;
                }
                else
                {
                    Console.WriteLine($"Ошибка распознать возраст в строчке номер {lineNumber}!");
                    Console.WriteLine("Проверьте формат записи в файле.");
                    Console.WriteLine("Правильный формат: <Фамилия> <Возраст>");
                }
            }
        }
    }
}