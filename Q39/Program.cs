﻿namespace Q39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Console.WriteLine("\nInput first integer:");

            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input second integer:");

            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input third integer:");

            int z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Largest of three: " + Math.Max(x, Math.Max(y, z)));

            Console.WriteLine("Lowest of three: " + Math.Min(x, Math.Min(y, z)));
        }
    }
}
