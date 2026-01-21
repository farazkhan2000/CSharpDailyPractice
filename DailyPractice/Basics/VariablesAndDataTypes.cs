using System;

namespace DailyPractice.Basics
{
    public class VariablesAndDataTypes
    {
        public static void Run()
        {
            Console.WriteLine("══════════════════════════════════════════");
            Console.WriteLine("       Variables and Data Types Demo        ");
            Console.WriteLine("══════════════════════════════════════════");
            Console.WriteLine();

            // Different data types with meaningful names
            string name = "Faraz";
            string favoriteColor = "Blue";
            int age = 25;
            int yearStartedCSharp = 2026;
            double heightInMeters = 1.68;
            float currentTemperature = 22.5f;   // 'f' suffix for float
            bool likesProgramming = true;
            char favoriteLetter = 'F';

            // Nice aligned output using string interpolation
            Console.WriteLine($"Name              : {name}");
            Console.WriteLine($"Age               : {age} years");
            Console.WriteLine($"Height            : {heightInMeters:F2} m");
            Console.WriteLine($"Temperature       : {currentTemperature:F1} °C");
            Console.WriteLine($"Favorite color    : {favoriteColor}");
            Console.WriteLine($"Favorite letter   : {favoriteLetter}");
            Console.WriteLine($"Started C# in     : {yearStartedCSharp}");
            Console.WriteLine($"Likes programming?: {(likesProgramming ? "Yes" : "No")}");

            Console.WriteLine();
            Console.WriteLine("→ These values are stored in different variable types!");
        }
    }
}