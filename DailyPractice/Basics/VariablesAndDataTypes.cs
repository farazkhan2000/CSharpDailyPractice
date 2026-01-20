using System;

namespace DailyPractice.Basics
{
    public class VariablesAndDataTypes
    {
        public static void Run()
        {
            Console.WriteLine("=== Variables and Data Types ===");
            Console.WriteLine();

            // Text (string)
            string name = "Faraz";
            string favoriteColor = "Blue";

            // Whole numbers
            int age = 25;
            int yearLearningCSharp = 2026;

            // Numbers with decimals
            double heightInMeters = 1.68;
            float temperature = 22.5f;          // note the 'f' at the end

            // True/False
            bool likesProgramming = true;

            // Character (single letter/symbol)
            char favoriteLetter = 'F';

            // Print everything nicely
            Console.WriteLine($"My name is {name}");
            Console.WriteLine($"I am {age} years old");
            Console.WriteLine($"Height: {heightInMeters} meters");
            Console.WriteLine($"Current temperature: {temperature} °C");
            Console.WriteLine($"Favorite color: {favoriteColor}");
            Console.WriteLine($"Favorite letter: {favoriteLetter}");
            Console.WriteLine($"Started learning C# in: {yearLearningCSharp}");
            Console.WriteLine($"Do I like programming? {likesProgramming}");

            Console.WriteLine("\nAll these values are stored in variables!");
        }
    }
}