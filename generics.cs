using System;
using System.Collections.Generic; // Required for List<T>, Dictionary<T>

namespace CSharpBasic
{
    class Generics
    {
        public static void Run()
        {
            Console.WriteLine("=== C# Generics ===");

            // --- 1. Generic Collections: List<T> ---
            // <T> ensures type safety. We don't need casting.
            List<string> names = new List<string>();
            names.Add("Alice");
            names.Add("Bob");
            names.Add("Charlie");

            Console.WriteLine("Generic List<string>:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            // List of Integers
            List<int> numbers = new List<int> { 1, 5, 10, 20 };
            Console.WriteLine($"\nGeneric List<int> Count: {numbers.Count}");

            // --- 2. Generic Collections: Dictionary<TKey, TValue> ---
            Dictionary<int, string> employees = new Dictionary<int, string>();
            employees.Add(101, "John Doe");
            employees.Add(102, "Jane Smith");

            Console.WriteLine("\nGeneric Dictionary<int, string>:");
            foreach (var kvp in employees)
            {
                Console.WriteLine($"ID: {kvp.Key}, Name: {kvp.Value}");
            }

            // --- 3. Generic Methods ---
            Console.WriteLine("\nGeneric Swap Method:");
            int a = 10, b = 20;
            Console.WriteLine($"Before Swap: a={a}, b={b}");
            Swap<int>(ref a, ref b);
            Console.WriteLine($"After Swap:  a={a}, b={b}");

            string x = "Hello", y = "World";
            Console.WriteLine($"Before Swap: x={x}, y={y}");
            Swap<string>(ref x, ref y);
            Console.WriteLine($"After Swap:  x={x}, y={y}");

            // --- 4. Generic Classes ---
            GenericBox<int> intBox = new GenericBox<int>(123);
            Console.WriteLine($"\nGenericBox<int>: {intBox.GetContent()}");

            GenericBox<string> strBox = new GenericBox<string>("Fragile");
            Console.WriteLine($"GenericBox<string>: {strBox.GetContent()}");
        }

        // Generic Method Definition
        // 'T' can be any type
        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
    }

    // Generic Class Definition
    class GenericBox<T>
    {
        private T content;

        public GenericBox(T content)
        {
            this.content = content;
        }

        public T GetContent()
        {
            return content;
        }
    }
}
