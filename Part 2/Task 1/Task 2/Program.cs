using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace Task_2
{
    internal class Program
    {
        struct str
        {
            public string Name;
            public string Value;
        }
        public static void Main(string[] args)
        {
            string path = Console.ReadLine();
            if (File.Exists(path))
            {
                var list=new List<str>();
                foreach (string s in File.ReadAllLines(path))
                    list.Add(new str { Name = s.Split(' ')[0], Value = s.Split(' ')[1] });
            }
            else
            {
                Console.WriteLine("Такого файла не существует!");
            }
        }
    }
}