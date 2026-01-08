using System;
using System.Linq; // Needed for some array methods like Max, Min, Sum

namespace CSharpBasic
{
    class Arrays
    {
        public static void Run()
        {
            Console.WriteLine("=== C# Arrays ===");

            // --- 1. Declaration and Initialization ---
            // Create an array of strings
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            
            // Create an array of integers with size 4
            int[] numbers = new int[4];
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;

            // --- 2. Accessing Elements ---
            Console.WriteLine($"First Car: {cars[0]}");
            
            // Changing an element
            cars[0] = "Opel";
            Console.WriteLine($"First Car Modified: {cars[0]}");

            // --- 3. Array Length ---
            Console.WriteLine($"Number of cars: {cars.Length}");

            // --- 4. Loop Through an Array ---
            Console.WriteLine("\nLooping with For:");
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            Console.WriteLine("\nLooping with Foreach:");
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            // --- 5. Sorting Arrays ---
            Console.WriteLine("\nSorting Numbers:");
            int[] myNumbers = { 5, 1, 8, 9 };
            Array.Sort(myNumbers); // Sorts in ascending order
            foreach (int i in myNumbers)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            // --- 6. Useful Array Methods (System.Linq) ---
            Console.WriteLine($"Max Value: {myNumbers.Max()}");
            Console.WriteLine($"Min Value: {myNumbers.Min()}");
            Console.WriteLine($"Sum: {myNumbers.Sum()}");

            // --- 7. Multidimensional Arrays ---
            // A 2D array [row, column]
            int[,] matrix = { { 1, 4, 2 }, { 3, 6, 8 } };
            
            Console.WriteLine($"\nElement at [0,1]: {matrix[0, 1]}"); // Outputs 4

            Console.WriteLine("Looping 2D Array:");
            for (int i = 0; i < matrix.GetLength(0); i++) // Rows
            {
                for (int j = 0; j < matrix.GetLength(1); j++) // Columns
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
