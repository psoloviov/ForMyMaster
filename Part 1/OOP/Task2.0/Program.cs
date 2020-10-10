using System;

namespace Task2._0
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Vector vector1 = new Vector(2, 5, 4);
            Vector vector2 = new Vector(4, -2, -6);
            Console.WriteLine(vector1.scalarProduct(vector2));
            Console.WriteLine(vector1.cos(vector2));
            Vector[] vectors = Vector.generate(5);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(vectors[i].output());
            }
        }
    }
}