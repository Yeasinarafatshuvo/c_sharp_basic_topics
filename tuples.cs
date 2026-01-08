using System;

namespace CSharpBasic
{
    class Tuples
    {
        public static void Run()
        {
            Console.WriteLine("=== C# Tuples ===");

            // Tuples allow you to return multiple values from a method without using out parameters or creating a class.

            // --- 1. Basic Tuple ---
            // (int, string)
            var person = (1, "Alice");
            Console.WriteLine($"ID: {person.Item1}, Name: {person.Item2}");

            // --- 2. Named Tuple Elements (Better Readability) ---
            (int Age, string Name) employee = (30, "Bob");
            Console.WriteLine($"Employee: {employee.Name}, Age: {employee.Age}");

            // Also can be defined like this:
            var product = (Id: 101, Price: 19.99);
            Console.WriteLine($"Product Price: {product.Price}");

            // --- 3. Returning Tuple from Method ---
            var stats = GetMathStats(10, 20);
            Console.WriteLine($"\nSum: {stats.Sum}");
            Console.WriteLine($"Product: {stats.Product}");

            // --- 4. Deconstructing Tuples ---
            // Unpacking values into separate variables
            var (s, p) = GetMathStats(5, 5);
            Console.WriteLine($"\nDeconstructed -> Sum: {s}, Product: {p}");

            // Discarding values (using _)
            var (_, prod) = GetMathStats(2, 3);
            Console.WriteLine($"Ignored Sum, Used Product: {prod}");
        }

        // Method returning a tuple
        static (int Sum, int Product) GetMathStats(int a, int b)
        {
            return (a + b, a * b);
        }
    }
}
