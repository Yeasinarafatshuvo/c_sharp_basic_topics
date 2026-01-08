using System;

namespace CSharpBasic
{
    class ControlFlow
    {
        public static void Run()
        {
            Console.WriteLine("=== C# Control Flow ===");

            // --- 1. If-Else Statement ---
            int number = 10;
            if (number > 0)
            {
                Console.WriteLine("Number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("Number is negative.");
            }
            else
            {
                Console.WriteLine("Number is zero.");
            }

            // --- 2. Switch Statement ---
            int day = 3;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                default:
                    Console.WriteLine("Other day");
                    break;
            }

            // --- 3. For Loop ---
            // Use when you know exactly how many times you want to loop.
            Console.WriteLine("\nFor Loop:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            // --- 4. While Loop ---
            // Use when you want to loop as long as a condition is true.
            Console.WriteLine("\nWhile Loop:");
            int j = 0;
            while (j < 5)
            {
                Console.Write($"{j} ");
                j++;
            }
            Console.WriteLine();

            // --- 5. Do-While Loop ---
            // Executes the block code once, before checking if the condition is true.
            Console.WriteLine("\nDo-While Loop:");
            int k = 0;
            do
            {
                Console.Write($"{k} ");
                k++;
            }
            while (k < 5);
            Console.WriteLine();

            // --- 6. Foreach Loop ---
            // Exclusively used to loop through elements in an array or other data sets.
            Console.WriteLine("\nForeach Loop:");
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string car in cars)
            {
                Console.Write($"{car} ");
            }
            Console.WriteLine();

            // --- 7. Break and Continue ---
            Console.WriteLine("\nBreak and Continue:");
            for (int x = 0; x < 10; x++)
            {
                if (x == 4)
                {
                    continue; // Skips the current iteration
                }
                if (x == 8)
                {
                    break; // Exits the loop
                }
                Console.Write($"{x} ");
            }
            Console.WriteLine();
        }
    }
}
