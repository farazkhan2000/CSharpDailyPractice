using System;

namespace DailyPractice.Loops
{
    public class DoWhileLoop
    {
        public static void Run()
        {
            Console.WriteLine("=== Do-While Loop ===");
            Console.WriteLine();

            // Difference: do-while runs AT LEAST once, even if condition is false

            // Example 1: Simple count (runs once even if condition false)
            int number = 10;
            Console.WriteLine("Do-while example (starts with number = 10):");
            do
            {
                Console.WriteLine("Number is: " + number);
                number++;
            } while (number <= 5);  // condition is already false → still runs once!

            Console.WriteLine("\n");

            // Example 2: Keep asking for positive number
            int positiveNum;
            do
            {
                Console.Write("Enter a positive number: ");
                string input = Console.ReadLine();
                int.TryParse(input, out positiveNum);

                if (positiveNum <= 0)
                {
                    Console.WriteLine("That's not positive. Try again.");
                }
            } while (positiveNum <= 0);

            Console.WriteLine($"Thanks! You entered: {positiveNum}");
        }
    }
}