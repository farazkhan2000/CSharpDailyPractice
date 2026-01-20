using System;

namespace DailyPractice.Basics
{
    public class StringBasics
    {
        public static void Run()
        {
            Console.WriteLine("=== String Basics ===");
            Console.WriteLine();

            string greeting = "Hello";
            string name = "Faraz";

            // Concatenation (old way)
            string message1 = greeting + ", " + name + "!";
            Console.WriteLine("Concatenation: " + message1);

            // String interpolation (modern & cleaner – recommended)
            string message2 = $"{greeting}, {name}! Welcome to C#.";
            Console.WriteLine("Interpolation: " + message2);

            // Length
            Console.WriteLine($"Length of name: {name.Length} characters");

            // ToUpper / ToLower
            Console.WriteLine($"Uppercase: {name.ToUpper()}");
            Console.WriteLine($"Lowercase: {name.ToLower()}");

            // Contains, StartsWith, EndsWith
            string sentence = "I love learning C# programming.";
            Console.WriteLine($"Contains 'C#': {sentence.Contains("C#")}");
            Console.WriteLine($"Starts with 'I': {sentence.StartsWith("I")}");
            Console.WriteLine($"Ends with 'ing.': {sentence.EndsWith("ing.")}");

            // Replace
            string replaced = sentence.Replace("C#", "C Sharp");
            Console.WriteLine($"Replaced: {replaced}");
        }
    }
}