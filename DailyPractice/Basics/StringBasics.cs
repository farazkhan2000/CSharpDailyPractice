using System;

namespace DailyPractice.Basics
{
    public class StringBasics
    {
        public static void Run()
        {
            Console.WriteLine("══════════════════════════════════════════");
            Console.WriteLine("           String Basics & Methods          ");
            Console.WriteLine("══════════════════════════════════════════");
            Console.WriteLine();

            string greeting = "Hello";
            string name = "Faraz";
            string sentence = "I love learning C# programming.";

            // Basic operations
            Console.WriteLine($"Greeting + name  : {greeting}, {name}!");
            Console.WriteLine($"Full message     : {greeting}, {name}! Welcome to C#.");

            Console.WriteLine();
            Console.WriteLine($"Name length      : {name.Length} characters");
            Console.WriteLine($"Uppercase        : {name.ToUpper()}");
            Console.WriteLine($"Lowercase        : {name.ToLower()}");

            Console.WriteLine();
            Console.WriteLine("String checks:");
            Console.WriteLine($"Contains 'C#'    : {sentence.Contains("C#")}");
            Console.WriteLine($"Starts with 'I'  : {sentence.StartsWith("I")}");
            Console.WriteLine($"Ends with 'ing.' : {sentence.EndsWith("ing.")}");
            Console.WriteLine($"Ends with '.'    : {sentence.EndsWith(".")}");

            Console.WriteLine();
            Console.WriteLine("Replace example:");
            Console.WriteLine($"Original         : {sentence}");
            Console.WriteLine($"Replaced 'C#'    : {sentence.Replace("C#", "C Sharp")}");
        }
    }
}