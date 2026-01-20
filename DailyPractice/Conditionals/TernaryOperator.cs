using System;

namespace DailyPractice.Conditionals
{
    public class TernaryOperator
    {
        public static void Run()
        {
            Console.WriteLine("=== Ternary Operator ( ? : ) Examples ===");
            Console.WriteLine();

            // Example 1: Simple yes/no
            Console.Write("Enter temperature: ");
            string tempInput = Console.ReadLine();

            if (int.TryParse(tempInput, out int temp))
            {
                string weather = temp >= 25 ? "Hot" : "Cool";
                Console.WriteLine($"Weather today: {weather}");
            }

            // Example 2: Even/Odd
            Console.Write("Enter a number: ");
            string numInput = Console.ReadLine();

            if (int.TryParse(numInput, out int number))
            {
                string parity = number % 2 == 0 ? "even" : "odd";
                Console.WriteLine($"The number {number} is {parity}.");
            }

            // Example 3: Discount message
            Console.Write("Enter purchase amount: ");
            string amountInput = Console.ReadLine();

            if (double.TryParse(amountInput, out double amount))
            {
                string discountMsg = amount >= 100 ? "You get 10% discount!" : "No discount this time.";
                Console.WriteLine(discountMsg);
            }
            else
            {
                Console.WriteLine("Invalid amount.");
            }
        }
    }
}