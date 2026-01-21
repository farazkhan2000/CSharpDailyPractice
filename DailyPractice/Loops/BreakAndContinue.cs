using System;

namespace DailyPractice.Loops
{
    public class BreakAndContinue
    {
        public static void Run()
        {
            Console.WriteLine("=== Break and Continue in Loops ===");
            Console.WriteLine();

            // Example: for loop with break
            Console.WriteLine("For loop with break (stops at 7):");
            for (int i = 1; i <= 10; i++)
            {
                if (i == 7)
                {
                    Console.WriteLine("Breaking out at 7!");
                    break;  // exits the loop completely
                }
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");

            // Example: for loop with continue
            Console.WriteLine("For loop with continue (skips multiples of 3):");
            for (int i = 1; i <= 10; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("[skip] ");
                    continue;  // skips the rest of this iteration, goes to next
                }
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}