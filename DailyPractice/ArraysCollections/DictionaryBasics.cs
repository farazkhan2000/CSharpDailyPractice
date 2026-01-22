using System;
using System.Collections.Generic;

namespace DailyPractice.ArraysCollections
{
    public class DictionaryBasics
    {
        public static void Run()
        {
            Console.WriteLine("══════════════════════════════════════════");
            Console.WriteLine("       Dictionary Basics (Key-Value)        ");
            Console.WriteLine("══════════════════════════════════════════");
            Console.WriteLine();

            // Create dictionary: key = string, value = int
            Dictionary<string, int> ages = new Dictionary<string, int>();

            // Add entries
            ages["Faraz"] = 25;
            ages["Alex"] = 32;
            ages["Sara"] = 19;

            Console.WriteLine("Ages dictionary:");
            foreach (var pair in ages)
            {
                Console.WriteLine($"  {pair.Key}: {pair.Value} years");
            }

            // Access by key
            Console.WriteLine($"\nFaraz's age: {ages["Faraz"]}");

            // Check if key exists + update
            if (ages.ContainsKey("Sara"))
            {
                ages["Sara"] = 20; // update
                Console.WriteLine("Sara's age updated to 20");
            }

            Console.WriteLine("\nUpdated dictionary:");
            foreach (var pair in ages)
            {
                Console.WriteLine($"  {pair.Key} → {pair.Value}");
            }
        }
    }
}