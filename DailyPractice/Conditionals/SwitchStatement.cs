using System;

namespace DailyPractice.Conditionals
{
    public class SwitchStatement
    {
        public static void Run()
        {
            Console.WriteLine("=== switch Statement - Day of the Week ===");
            Console.WriteLine();

            Console.Write("Enter a number (1-7): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int day))
            {
                switch (day)
                {
                    case 1:
                        Console.WriteLine("Monday - Start of the week!");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Friday - Almost weekend!");
                        break;
                    case 6:
                        Console.WriteLine("Saturday - Weekend!");
                        break;
                    case 7:
                        Console.WriteLine("Sunday - Rest day");
                        break;
                    default:
                        Console.WriteLine("Invalid day number (use 1-7)");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}