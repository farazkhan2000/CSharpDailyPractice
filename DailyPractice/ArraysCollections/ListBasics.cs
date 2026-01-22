using System;
using System.Collections.Generic;

namespace DailyPractice.ArraysCollections
{
    public class ListBasics
    {
        public static void Run()
        {
            Console.WriteLine("══════════════════════════════════════════");
            Console.WriteLine("           List<T> Basics                   ");
            Console.WriteLine("══════════════════════════════════════════");
            Console.WriteLine();

            // Create an empty list
            List<string> shoppingList = new List<string>();

            // Add items
            shoppingList.Add("Milk");
            shoppingList.Add("Bread");
            shoppingList.Add("Eggs");
            shoppingList.Add("Apples");

            Console.WriteLine("Shopping list:");
            foreach (string item in shoppingList)
            {
                Console.WriteLine($" - {item}");
            }

            Console.WriteLine($"\nItems count: {shoppingList.Count}");

            // Insert, remove, check contains
            shoppingList.Insert(1, "Butter");                  // insert at index 1
            shoppingList.Remove("Eggs");                        // remove by value
            bool hasApples = shoppingList.Contains("Apples");

            Console.WriteLine("\nAfter changes:");
            Console.WriteLine(string.Join(" → ", shoppingList));
            Console.WriteLine($"Has apples? {hasApples}");

            // Access by index
            Console.WriteLine($"\nFirst item: {shoppingList[0]}");
        }
    }
}