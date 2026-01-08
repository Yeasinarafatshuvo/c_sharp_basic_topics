using System;
using System.Text;

namespace CSharpBasic
{
    class StringOperations
    {
        public static void Run()
        {
            Console.WriteLine("=== C# String Operations ===");

            string sample = "  Hello, C# World!  ";

            // --- 1. Basic Methods ---
            Console.WriteLine($"Original: '{sample}'");
            Console.WriteLine($"Trimmed: '{sample.Trim()}'");
            Console.WriteLine($"Uppercase: '{sample.ToUpper()}'");
            Console.WriteLine($"Lowercase: '{sample.ToLower()}'");

            // --- 2. Checking Content ---
            string cleanSample = sample.Trim();
            Console.WriteLine($"Contains 'World': {cleanSample.Contains("World")}"); // True
            Console.WriteLine($"Starts with 'Hello': {cleanSample.StartsWith("Hello")}"); // True
            Console.WriteLine($"Ends with '!': {cleanSample.EndsWith("!")}"); // True

            // --- 3. Substring and Replacement ---
            // Substring(startIndex, length)
            string substr = cleanSample.Substring(7, 2); // "C#"
            Console.WriteLine($"Substring (7,2): {substr}");

            string replaced = cleanSample.Replace("World", "Developer");
            Console.WriteLine($"Replaced: {replaced}");

            // --- 4. Splitting and Joining ---
            string data = "Apple,Banana,Cherry";
            string[] fruits = data.Split(',');
            
            Console.WriteLine("Split Result:");
            foreach (string fruit in fruits)
            {
                Console.WriteLine($"- {fruit}");
            }

            string joined = string.Join(" | ", fruits);
            Console.WriteLine($"Joined Result: {joined}");

            // --- 5. String Interpolation ($) ---
            string name = "Alice";
            int age = 30;
            Console.WriteLine($"My name is {name} and I am {age} years old."); // Easier than "..." + "..."

            // --- 6. Verbatim Strings (@) ---
            // Ignores escape characters like \
            string path = @"C:\Users\Yeasin\Desktop\File.txt"; 
            Console.WriteLine($"Verbatim Path: {path}");

            // --- 7. StringBuilder ---
            // Efficient for manipulating strings in loops
            StringBuilder sb = new StringBuilder();
            sb.Append("This ");
            sb.Append("is ");
            sb.Append("efficient.");
            Console.WriteLine($"StringBuilder: {sb.ToString()}");
        }
    }
}
