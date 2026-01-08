using System;

namespace CSharpBasic
{
    class NullableTypes
    {
        public static void Run()
        {
            Console.WriteLine("=== C# Nullable Types ===");

            // --- 1. Nullable Value Types ---
            // Value types (int, bool, double) cannot normally be null.
            // int i = null; // Error
            
            // Use '?' to allow null
            int? nullableInt = null;
            Console.WriteLine($"Nullable Int: {nullableInt}");

            nullableInt = 100;
            if (nullableInt.HasValue)
            {
                Console.WriteLine($"Has Value: {nullableInt.Value}");
            }

            // --- 2. Null Coalescing Operator (??) ---
            // Returns the left-hand operand if required not null; otherwise returns the right-hand operand.
            int? x = null;
            int y = x ?? -1; // If x is null, use -1
            Console.WriteLine($"\nResult of (null ?? -1): {y}");

            x = 55;
            y = x ?? -1; // If x is 55, use 55
            Console.WriteLine($"Result of (55 ?? -1): {y}");

            // --- 3. Null Coalescing Assignment (??=) ---
            string text = null;
            text ??= "Default Value"; // If text is null, assign "Default Value"
            Console.WriteLine($"\nText after ??=: {text}");

            // --- 4. Null Conditional Operator (?.) ---
            // Used to access members only if the object is not null. Also known as "Safe Navigation".
            string message = null;
            // int length = message.Length; // Throws NullReferenceException

            int? length = message?.Length; // Returns null if message is null
            Console.WriteLine($"\nLength of null string: {length}"); // blank/null

            message = "Hello";
            Console.WriteLine($"Length of 'Hello': {message?.Length}"); // 5
        }
    }
}
