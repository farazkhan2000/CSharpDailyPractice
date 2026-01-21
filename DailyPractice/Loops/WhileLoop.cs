using System;

namespace DailyPractice.Loops
{
    public class WhileLoop
    {
        public static void Run()
        {
            Console.WriteLine("=== While Loop ===");
            Console.WriteLine();

            // Example 1: Count up until condition is false
            int count = 1;
            Console.WriteLine("Counting up while < 6:");
            while (count <= 5)
            {
                Console.Write(count + " ");
                count++;  // very important – otherwise infinite loop!
            }
            Console.WriteLine("\n");

            // Example 2: Keep asking until correct password (simple simulation)
            string password = "";
            Console.WriteLine("Enter password (hint: it's 'csharp'):");
            while (password != "csharp")
            {
                password = Console.ReadLine()?.Trim().ToLower() ?? "";
                if (password != "csharp")
                {
                    Console.WriteLine("Wrong! Try again:");
                }
            }
            Console.WriteLine("Correct! Welcome.");
        }
    }
}