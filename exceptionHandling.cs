using System;

namespace CSharpBasic
{
    class ExceptionHandling
    {
        public static void Run()
        {
            Console.WriteLine("=== C# Exception Handling ===");

            // --- 1. Basic Try-Catch ---
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]); // Index out of bounds
            }
            catch (Exception e)
            {
                Console.WriteLine($"Something went wrong: {e.Message}");
            }

            // --- 2. Catching Specific Exceptions ---
            try
            {
                int divisor = 0;
                int result = 10 / divisor; // Divide by zero
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"Cannot divide by zero! ({e.Message})");
            }
            catch (Exception e) // Catch-all for other exceptions
            {
                Console.WriteLine($"General Error: {e.Message}");
            }

            // --- 3. Try-Catch-Finally ---
            // 'Finally' block executes regardless of the result
            try
            {
                Console.WriteLine("\nExecuting Try block...");
                // Simulate some work
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occurred.");
            }
            finally
            {
                Console.WriteLine("Finally block executed. (Cleanup code goes here)");
            }

            // --- 4. Throwing Exceptions ---
            try
            {
                CheckAge(15);
            }
            catch (AccessViolationException e)
            {
                Console.WriteLine($"\nCaught Thrown Exception: {e.Message}");
            }
        }

        static void CheckAge(int age)
        {
            if (age < 18)
            {
                // Manually throw an exception
                throw new AccessViolationException("Access denied - You must be at least 18 years old.");
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough!");
            }
        }
    }
}
