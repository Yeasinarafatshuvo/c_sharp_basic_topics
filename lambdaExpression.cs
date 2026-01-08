using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpBasic
{
    class LambdaExpression
    {
        public static void Run()
        {
            Console.WriteLine("=== C# Lambda Expressions ===");

            // Lambda syntax: (parameters) => expression
            // It's a concise way to represent an anonymous method.

            // --- 1. Basic Lambda with Func ---
            // Func<int, int> takes an int, returns an int
            Func<int, int> square = x => x * x;
            Console.WriteLine($"Square of 5: {square(5)}");

            // --- 2. Lambda with Block Body ---
            Func<int, int, int> addValues = (x, y) =>
            {
                int temp = x + y;
                return temp;
            };
            Console.WriteLine($"Sum: {addValues(10, 20)}");

            // --- 3. Lambda with Action ---
            // Action takes parameters, returns void
            Action<string> greet = name => Console.WriteLine($"Hello, {name}!");
            greet("Developer");

            // --- 4. Lambdas in Generic Lists (Most Common Use) ---
            List<int> numbers = new List<int> { 1, 5, 8, 12, 15, 20 };

            // Find all numbers greater than 10
            // logic: n => n > 10
            List<int> bigNumbers = numbers.FindAll(n => n > 10);
            
            Console.WriteLine("\nNumbers > 10:");
            foreach (var num in bigNumbers)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();

            // Using ForEach with Lambda
            Console.WriteLine("\nPrinting all numbers using ForEach:");
            numbers.ForEach(n => Console.Write($"{n} "));
            Console.WriteLine();

            // --- 5. Custom Delegate with Lambda ---
            MyMathOperation op = (a, b) => a * b + 1;
            Console.WriteLine($"\nCustom Delegate Result: {op(5, 5)}"); // 26
        }

        delegate int MyMathOperation(int x, int y);
    }
}
