using System;

namespace Task2._0
{
    public class Vector
    {
        private readonly double x;
        private readonly double y;
        private readonly double z;

        public Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double length()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }

        public double scalarProduct(Vector vector)
        {
            return (x * vector.x + y * vector.y + z * vector.z);
        }

        public Vector crossProduct(Vector vector)
        {
            return new Vector(
                y * vector.z - vector.y * z,
                z * vector.x - vector.z * x,
                x * vector.y - vector.x + y);
        }

        public Vector Add(Vector vector)
        {
            return new Vector(
                x + vector.x,
                y + vector.y,
                z + vector.z);
        }

        public Vector Minus(Vector vector)
        {
            return new Vector(
                x - vector.x,
                y - vector.y,
                z - vector.z);
        }

        public static Vector[] generate(int length)
        {
            Random rand = new Random();
            Vector[] vectors = new Vector[length];
            for (int i = 0; i < length; i++)
            {
                vectors[i] = new Vector(rand.Next(-9, 9), rand.Next(-9, 9), rand.Next(-9, 9));
            }

            return vectors;
        }

        public string output()
        {
            return $"x = {x},\t" +
                   $"y = {y},\t" +
                   $"z = {z}";
        }

        public double cos(Vector vector)
        {
            return scalarProduct(vector) / length() * vector.length();
        }
    }
}