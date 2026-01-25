using System;

namespace DailyPractice.MiniProjects
{
    public class SimpleCalculator
    {
        public static void Run()
        {
            Console.WriteLine("══════════════════════════════════════════");
            Console.WriteLine("         Simple Calculator                  ");
            Console.WriteLine("══════════════════════════════════════════");
            Console.WriteLine();

            Console.WriteLine("Enter first number:");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Invalid number. Exiting.");
                return;
            }

            Console.WriteLine("Enter second number:");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Invalid number. Exiting.");
                return;
            }

            Console.WriteLine("\nChoose operation:");
            Console.WriteLine("  +   Add");
            Console.WriteLine("  -   Subtract");
            Console.WriteLine("  *   Multiply");
            Console.WriteLine("  /   Divide");
            Console.Write("Enter symbol (+ - * /): ");

            string operation = Console.ReadLine()?.Trim();

            double result = 0;
            bool valid = true;

            switch (operation)
            {
                case "+":
                    result = Add(num1, num2);
                    break;
                case "-":
                    result = Subtract(num1, num2);
                    break;
                case "*":
                    result = Multiply(num1, num2);
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Cannot divide by zero!");
                        valid = false;
                    }
                    else
                    {
                        result = Divide(num1, num2);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation!");
                    valid = false;
                    break;
            }

            if (valid)
            {
                Console.WriteLine($"\nResult: {num1} {operation} {num2} = {result:F2}");
            }
        }

        // Helper methods
        private static double Add(double a, double b) => a + b;
        private static double Subtract(double a, double b) => a - b;
        private static double Multiply(double a, double b) => a * b;
        private static double Divide(double a, double b) => a / b;
    }
}