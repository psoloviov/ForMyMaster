using System;

namespace Task2._0
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Vector vector1 = new Vector(2,5,4);
            Vector vector2 = new Vector(4, -1, -6);
            Console.WriteLine(vector1.ScalarProduct(vector2));
            Console.WriteLine(vector1.Cos(vector2));
        }
    }
}