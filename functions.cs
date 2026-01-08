using System;

namespace CSharpBasic
{
    class Functions
    {
        public static void Run()
        {
            Console.WriteLine("=== C# Functions (Methods) ===");

            // Calling a simple method
            SayHello();

            // Calling a method with parameters
            GreetUser("Alice", 25);

            // Calling a method with return value
            int result = Add(5, 10);
            Console.WriteLine($"5 + 10 = {result}");

            // Method Overloading
            Console.WriteLine($"Add ints: {Add(2, 3)}");
            Console.WriteLine($"Add doubles: {Add(2.5, 3.5)}");

            // Named arguments
            GreetUser(age: 30, name: "Bob");

            // Ref parameter (modifies original variable)
            int valueToDouble = 10;
            DoubleValue(ref valueToDouble);
            Console.WriteLine($"Ref Value (DoubleValue): {valueToDouble}"); // 20

            // Out parameter (must be assigned inside method)
            int sumResult;
            int diffResult;
            GetSumAndDifference(10, 4, out sumResult, out diffResult);
            Console.WriteLine($"Out Params - Sum: {sumResult}, Diff: {diffResult}");
        }

        // 1. Simple Void Method
        static void SayHello()
        {
            Console.WriteLine("Hello from a function!");
        }

        // 2. Method with Parameters
        static void GreetUser(string name, int age)
        {
            Console.WriteLine($"Hello {name}, you are {age} years old.");
        }

        // 3. Method with Return Value
        static int Add(int a, int b)
        {
            return a + b;
        }

        // 4. Method Overloading (same name, different parameters)
        static double Add(double a, double b)
        {
            return a + b;
        }

        // 5. Ref Parameter
        // The 'ref' keyword passes a reference to the actual variable, not just its value.
        static void DoubleValue(ref int x)
        {
            x = x * 2;
        }

        // 6. Out Parameter
        // The 'out' keyword is used to return multiple values from a method.
        static void GetSumAndDifference(int a, int b, out int sum, out int diff)
        {
            sum = a + b;
            diff = a - b;
        }
    }
}
