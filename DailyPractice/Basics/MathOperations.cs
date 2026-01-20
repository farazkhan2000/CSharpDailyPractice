using System;

namespace DailyPractice.Basics
{
    public class MathOperations
    {
        public static void Run()
        {
            Console.WriteLine("=== Basic Math Operations ===");
            Console.WriteLine();

            int a = 15;
            int b = 4;

            Console.WriteLine($"Numbers: a = {a}, b = {b}");
            Console.WriteLine("-----------------------------");

            // Addition
            int sum = a + b;
            Console.WriteLine($"Addition:       {a} + {b} = {sum}");

            // Subtraction
            int difference = a - b;
            Console.WriteLine($"Subtraction:    {a} - {b} = {difference}");

            // Multiplication
            int product = a * b;
            Console.WriteLine($"Multiplication: {a} * {b} = {product}");

            // Division (integer division – drops decimal part)
            int quotient = a / b;
            Console.WriteLine($"Division (int): {a} / {b} = {quotient}");

            // Division with decimal result (use double)
            double realDivision = (double)a / b;
            Console.WriteLine($"Real division:  {a} / {b} = {realDivision:F2}");  // :F2 = 2 decimal places

            // Modulo (remainder)
            int remainder = a % b;
            Console.WriteLine($"Remainder:      {a} % {b} = {remainder}");

            Console.WriteLine();
            Console.WriteLine("Quick examples:");
            Console.WriteLine($"10 + 5 * 2 = {10 + 5 * 2}   (multiplication first)");
            Console.WriteLine($"(10 + 5) * 2 = {(10 + 5) * 2}   (parentheses first)");
        }
    }
}