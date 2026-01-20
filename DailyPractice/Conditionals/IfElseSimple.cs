using System;

namespace DailyPractice.Conditionals
{
    public class IfElseSimple
    {
        public static void Run()
        {
            Console.WriteLine("=== Simple if-else ===");
            Console.WriteLine();

            Console.Write("Enter your age: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int age))
            {
                if (age >= 18)
                {
                    Console.WriteLine("You are an adult.");
                }
                else
                {
                    Console.WriteLine("You are a minor.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}