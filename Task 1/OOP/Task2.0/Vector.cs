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

        public double Length()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }

        public double ScalarProduct(Vector vector)
        {
            return x * vector.x + y * vector.y + z * vector.z;
        }

        public Vector CrossProduct(Vector vector)
        {
            return new Vector(
                y * vector.z - z * vector.y,
                z * vector.x - x * vector.z,
                x * vector.y - y * vector.x);
        }

        public double Cos(Vector vector)
        {
            return ScalarProduct(vector) / (Length() * vector.Length());
        }

        public Vector Add(Vector vector)
        {
            return new Vector(
                x + vector.x,
                y + vector.y,
                z + vector.z
            );
        }

        public Vector Subtract(Vector vector)
        {
            return new Vector(
                x - vector.x,
                y - vector.y,
                z - vector.z);
        }

        public static Vector[] Generate(int n)
        {
            Vector[] vectors = new Vector[n];
            var rand = new Random();
            for (int i = 0; i < n; i++)
            {
                vectors[i] = new Vector(rand.Next(), rand.Next(), rand.Next());
            }

            return vectors;
        }

        public String String()
        {
            return $"Vector[ x = {x}, y = {y}, z = {z} ]";
        }
    }
}