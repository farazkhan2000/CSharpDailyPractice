using System;

namespace DailyPractice.Basics
{
    public class MathOperations
    {
        public static void Run()
        {
            Console.WriteLine("══════════════════════════════════════════");
            Console.WriteLine("         Basic Math Operations Demo         ");
            Console.WriteLine("══════════════════════════════════════════");
            Console.WriteLine();

            int a = 15;
            int b = 4;

            Console.WriteLine($"Using numbers →  a = {a},  b = {b}");
            Console.WriteLine("──────────────────────────────────────────");

            Console.WriteLine($"Addition         : {a} + {b} = {a + b}");
            Console.WriteLine($"Subtraction      : {a} - {b} = {a - b}");
            Console.WriteLine($"Multiplication   : {a} * {b} = {a * b}");
            Console.WriteLine($"Integer division : {a} / {b} = {a / b}     (drops decimal part)");
            Console.WriteLine($"Real division    : {a} / {b} = {(double)a / b:F2}");
            Console.WriteLine($"Remainder        : {a} % {b} = {a % b}");

            Console.WriteLine();
            Console.WriteLine("Operator precedence examples:");
            Console.WriteLine($"10 + 5 * 2   = {10 + 5 * 2}    (multiplication first)");
            Console.WriteLine($"(10 + 5) * 2 = {(10 + 5) * 2}    (parentheses first)");

            Console.WriteLine();
        }
    }
}