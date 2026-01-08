using System;
using System.IO;

namespace CSharpBasic
{
    class FileIo
    {
        public static void Run()
        {
            Console.WriteLine("=== C# File I/O ===");

            string fileName = "example_test_file.txt";
            string currentDirectory = Directory.GetCurrentDirectory();
            string filePath = Path.Combine(currentDirectory, fileName);

            Console.WriteLine($"Working with file: {filePath}");

            // --- 1. Write to File (Overwrites) ---
            string content = "Hello, this is a test file.\nC# File I/O is easy!";
            File.WriteAllText(filePath, content);
            Console.WriteLine("=> File 'WriteAllText' completed.");

            // --- 2. Append to File ---
            File.AppendAllText(filePath, "\nThis line was appended.");
            Console.WriteLine("=> File 'AppendAllText' completed.");

            // --- 3. Read File Content ---
            if (File.Exists(filePath))
            {
                string readContent = File.ReadAllText(filePath);
                Console.WriteLine("\n--- File Contents ---");
                Console.WriteLine(readContent);
                Console.WriteLine("---------------------");
            }
            else
            {
                Console.WriteLine("File not found!");
            }

            // --- 4. Read Lines (Array of strings) ---
            Console.WriteLine("\nReading line by line:");
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                Console.WriteLine($"[Line]: {line}");
            }

            // --- 5. File Information ---
            FileInfo fi = new FileInfo(filePath);
            Console.WriteLine($"\nFile Size: {fi.Length} bytes");
            Console.WriteLine($"Created On: {fi.CreationTime}");

            // --- Cleanup (Optional) ---
            // File.Delete(filePath);
            // Console.WriteLine("File deleted.");
        }
    }
}
