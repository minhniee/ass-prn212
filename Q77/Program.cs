﻿namespace Q77
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is 'Exercise' plural? " + test("Exercise"));

            Console.WriteLine("Is 'Exercises' plural? " + test("Exercises"));
            Console.WriteLine("Is 'Books' plural? " + test("Books"));

            Console.WriteLine("Is 'Book' plural? " + test("Book"));
        }

        public static bool test(string word)
        {
            return word.EndsWith("s");
        }
    }
    }
}
