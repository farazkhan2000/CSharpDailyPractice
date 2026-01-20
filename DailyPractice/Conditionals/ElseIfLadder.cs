using System;

namespace DailyPractice.Conditionals
{
    public class ElseIfLadder
    {
        public static void Run()
        {
            Console.WriteLine("=== else-if Ladder - Grade Calculator ===");
            Console.WriteLine();

            Console.Write("Enter your score (0-100): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int score))
            {
                if (score >= 90 && score <= 100)
                {
                    Console.WriteLine("Grade: A - Excellent!");
                }
                else if (score >= 80)
                {
                    Console.WriteLine("Grade: B - Very good");
                }
                else if (score >= 70)
                {
                    Console.WriteLine("Grade: C - Good");
                }
                else if (score >= 60)
                {
                    Console.WriteLine("Grade: D - Pass");
                }
                else if (score >= 0)
                {
                    Console.WriteLine("Grade: F - Fail");
                }
                else
                {
                    Console.WriteLine("Score cannot be negative.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
}