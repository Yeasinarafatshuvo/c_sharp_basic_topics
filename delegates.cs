using System;

namespace CSharpBasic
{
    class Delegates
    {
        // 1. Define a Delegate
        // Signature: takes two ints, returns void
        public delegate void OperationDelegate(int x, int y);

        // Signature: takes string, returns string
        public delegate string StringManipulator(string input);

        public static void Run()
        {
            Console.WriteLine("=== C# Delegates ===");

            // --- Basic Delegate Usage ---
            // Create instances of the delegate
            OperationDelegate add = Add;
            OperationDelegate multiply = Multiply;

            // Invoke delegates
            Console.WriteLine("Calling Add delegate:");
            add(10, 5);

            Console.WriteLine("Calling Multiply delegate:");
            multiply(10, 5);

            // --- Multicast Delegate ---
            // Chain multiple methods to one delegate
            Console.WriteLine("\nMulticast Delegate (Calls both Add and Multiply):");
            OperationDelegate multiOp = add;
            multiOp += multiply; // Add another method
            
            multiOp(20, 5); // Executes Add then Multiply

            // Remove a method
            multiOp -= add;
            Console.WriteLine("After removing Add:");
            multiOp(20, 5); // Executes only Multiply

            // --- Built-in Delegates: Action and Func ---
            // Action: Represents a method that takes parameters and returns void
            Console.WriteLine("\nAction<string> Delegate:");
            Action<string> printAction = PrintMessage;
            printAction("Hello from Action!");

            // Func: Represents a method that takes parameters and returns a value
            // Func<int, int, int> -> takes two ints, returns an int (last one is return type)
            Console.WriteLine("\nFunc<int, int, int> Delegate:");
            Func<int, int, int> adder = Sum;
            int result = adder(100, 200);
            Console.WriteLine($"Result: {result}");
        }

        // Methods matching the delegate signatures
        static void Add(int a, int b)
        {
            Console.WriteLine($"Sum: {a + b}");
        }

        static void Multiply(int a, int b)
        {
            Console.WriteLine($"Product: {a * b}");
        }

        static void PrintMessage(string msg)
        {
            Console.WriteLine(msg);
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
