using System;
using System.Collections.Generic;
using System.Linq; // Essential usage used for LINQ

namespace CSharpBasic
{
    class LinqExample
    {
        public static void Run()
        {
            Console.WriteLine("=== C# LINQ (Language Integrated Query) ===");

            // Sample Data
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David", "Eve" };

            // --- 1. Query Syntax (SQL-like) ---
            // Find even numbers
            var evenQuery = from num in numbers
                            where num % 2 == 0
                            select num;

            Console.WriteLine("Even Numbers (Query Syntax):");
            foreach (var n in evenQuery) Console.Write($"{n} ");
            Console.WriteLine();

            // --- 2. Method Syntax (Fluent API - Most Common) ---
            // Find numbers greater than 5
            var largeNumbers = numbers.Where(n => n > 5).ToList();

            Console.WriteLine("Numbers > 5 (Method Syntax):");
            largeNumbers.ForEach(n => Console.Write($"{n} "));
            Console.WriteLine();

            // --- 3. Sorting ---
            var sortedNames = names.OrderByDescending(n => n).ToList(); // Reverse alphabetical
            Console.WriteLine("Names (Reverse Order): " + string.Join(", ", sortedNames));

            // --- 4. Projection (Select) ---
            // Transform data: Get lengths of names
            var nameLengths = names.Select(n => $"{n} ({n.Length})");
            Console.WriteLine("Name Lengths: " + string.Join(", ", nameLengths));

            // --- 5. Aggregation ---
            int sum = numbers.Sum();
            int count = numbers.Count();
            double average = numbers.Average();
            int max = numbers.Max();

            Console.WriteLine($"Stats - Sum: {sum}, Count: {count}, Avg: {average}, Max: {max}");

            // --- 6. First / Single ---
            // First: Returns first match or exception if none
            string firstStartWithA = names.First(n => n.StartsWith("A"));
            Console.WriteLine($"First name starting with A: {firstStartWithA}");

            // FirstOrDefault: Returns null (or default) if not found
            string notFound = names.FirstOrDefault(n => n.StartsWith("Z"));
            Console.WriteLine($"Name starting with Z: {notFound ?? "None"}");
        }
    }
}
