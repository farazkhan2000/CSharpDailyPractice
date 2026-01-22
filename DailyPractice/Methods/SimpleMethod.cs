using System;

namespace DailyPractice.Methods
{
    public class SimpleMethod
    {
        public static void Run()
        {
            Console.WriteLine("══════════════════════════════════════════");
            Console.WriteLine("          Simple Method (No Parameters)     ");
            Console.WriteLine("══════════════════════════════════════════");
            Console.WriteLine();

            // Calling a method with no parameters
            PrintWelcomeMessage();
            PrintWelcomeMessage(); // we can call it multiple times

            Console.WriteLine("\n→ A method is like a reusable block of code.");
        }

        // Method definition – no parameters, no return value
        private static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to C# Methods!");
            Console.WriteLine("This message comes from a separate method.");
        }
    }
}