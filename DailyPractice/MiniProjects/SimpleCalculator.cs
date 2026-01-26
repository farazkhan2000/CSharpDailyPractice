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

            bool continueCalculating = true;

            while (continueCalculating)
            {
                // Get first number
                Console.Write("Enter first number: ");
                if (!double.TryParse(Console.ReadLine(), out double num1))
                {
                    Console.WriteLine("Invalid number! Starting over...\n");
                    continue;
                }

                // Get second number
                Console.Write("Enter second number: ");
                if (!double.TryParse(Console.ReadLine(), out double num2))
                {
                    Console.WriteLine("Invalid number! Starting over...\n");
                    continue;
                }

                // Show menu
                Console.WriteLine("\nChoose an operation:");
                Console.WriteLine("  1 → Addition       (+)");
                Console.WriteLine("  2 → Subtraction    (-)");
                Console.WriteLine("  3 → Multiplication (×)");
                Console.WriteLine("  4 → Division       (÷)");
                Console.Write("\nYour choice (1-4): ");

                if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 4)
                {
                    Console.WriteLine("Invalid choice! Please select 1, 2, 3 or 4.\n");
                    continue;
                }

                Console.WriteLine(); // empty line for readability

                double result = 0;
                bool validOperation = true;

                switch (choice)
                {
                    case 1:
                        result = num1 + num2;
                        Console.WriteLine($"{num1} + {num2} = {result}");
                        break;

                    case 2:
                        result = num1 - num2;
                        Console.WriteLine($"{num1} - {num2} = {result}");
                        break;

                    case 3:
                        result = num1 * num2;
                        Console.WriteLine($"{num1} × {num2} = {result}");
                        break;

                    case 4:
                        if (num2 == 0)
                        {
                            Console.WriteLine("Error: Division by zero is not allowed!");
                            validOperation = false;
                        }
                        else
                        {
                            result = num1 / num2;
                            Console.WriteLine($"{num1} ÷ {num2} = {result}");
                        }
                        break;

                    default:
                        validOperation = false;
                        break;
                }

                if (validOperation)
                {
                    Console.WriteLine(); // spacing after result
                }

                // Ask to continue
                Console.Write("Would you like to do another calculation? (y/n): ");
                string answer = Console.ReadLine()?.Trim().ToLower();
                continueCalculating = answer == "y" || answer == "yes";

                Console.WriteLine();
            }

            Console.WriteLine("Thank you for using the calculator. Goodbye!");
        }
    }
}