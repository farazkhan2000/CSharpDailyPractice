using System;

namespace DailyPractice.Loops
{
    public class ForLoopBasics
    {
        public static void Run()
        {
            Console.WriteLine("=== For Loop Basics ===");
            Console.WriteLine();

            // Example 1: Count from 1 to 10
            Console.WriteLine("Counting from 1 to 10:");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");

            // Example 2: Count down from 5
            Console.WriteLine("Countdown from 5:");
            for (int i = 5; i >= 1; i--)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");

            // Example 3: Even numbers only (step by 2)
            Console.WriteLine("Even numbers 0 to 20:");
            for (int i = 0; i <= 20; i += 2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}