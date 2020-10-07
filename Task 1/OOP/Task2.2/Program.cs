using System;
using System.Collections.Generic;
using System.Threading;

namespace Task2._2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var list = new LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            list.Delete(3);
            
            Console.ReadKey();
        }
    }
}