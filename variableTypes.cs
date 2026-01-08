using System;

namespace CSharpBasic
{
    // Class wrapper to allow independent execution
    class VariableTypes
    {
        public static void Run()
        {
            Console.WriteLine("=== C# Variable Types & Data Types ===");

            // --- 1. Integer Types ---
            int myInt = 100;            // 32-bit signed integer
            long myLong = 100000L;      // 64-bit signed integer (L suffix)
            short myShort = 5000;       // 16-bit signed integer
            byte myByte = 255;          // 8-bit unsigned integer (0-255)

            Console.WriteLine($"Integer: {myInt}");
            Console.WriteLine($"Long: {myLong}");
            Console.WriteLine($"Short: {myShort}");
            Console.WriteLine($"Byte: {myByte}");

            // --- 2. Floating Point Types ---
            float myFloat = 3.14F;      // 32-bit (Precision ~6-9 digits), F suffix required
            double myDouble = 3.14159;  // 64-bit (Precision ~15-17 digits), default for decimals
            decimal myDecimal = 9.99M;  // 128-bit (High precision for financial), M suffix required

            Console.WriteLine($"Float: {myFloat}");
            Console.WriteLine($"Double: {myDouble}");
            Console.WriteLine($"Decimal: {myDecimal}");

            // --- 3. Text Types ---
            char myChar = 'A';          // Single character, single quotes
            string myString = "Hello C#"; // Sequence of characters, double quotes

            Console.WriteLine($"Char: {myChar}");
            Console.WriteLine($"String: {myString}");

            // --- 4. Boolean Type ---
            bool isCSharpFun = true;
            bool isFishTasty = false;

            Console.WriteLine($"Is C# Fun? {isCSharpFun}");
            Console.WriteLine($"Is Fish Tasty? {isFishTasty}");

            // --- 5. Implicit Typing (var) ---
            // Compiler infers the type based on the value on the right side.
            var inferredInt = 10;       // Becomes int
            var inferredString = "Hi";  // Becomes string

            Console.WriteLine($"Inferred Type of '10': {inferredInt.GetType()}");

            // --- 6. Constants ---
            // Value cannot be changed after declaration.
            const double Pi = 3.14159;
            Console.WriteLine($"Constant Pi: {Pi}");
            // Pi = 3.14; // Error: Property or indexer cannot be assigned to -- it is read only

            // --- 7. Type Casting ---
            // Implicit casting (smaller -> larger type)
            int myIntNum = 9;
            double myDoubleNum = myIntNum; 
            Console.WriteLine($"Implicit Cast (int 9 -> double): {myDoubleNum}");

            // Explicit casting (larger -> smaller type)
            double myDoubleVal = 9.78;
            int myIntVal = (int)myDoubleVal; // Manual casting: double to int
            Console.WriteLine($"Explicit Cast (double 9.78 -> int): {myIntVal}"); // Outputs 9 (truncated)

            // Conversion methods
            string numStr = "123";
            int parsedInt = Convert.ToInt32(numStr);
            Console.WriteLine($"Convert.ToInt32: {parsedInt}");
        }
    }
}
