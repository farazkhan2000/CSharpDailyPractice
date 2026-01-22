using System;

namespace DailyPractice.Methods
{
    public class MethodOverloading
    {
        public static void Run()
        {
            Console.WriteLine("══════════════════════════════════════════");
            Console.WriteLine("         Method Overloading (Same Name)     ");
            Console.WriteLine("══════════════════════════════════════════");
            Console.WriteLine();

            // Same method name, different parameters
            DisplayInfo("Faraz");
            DisplayInfo(25);
            DisplayInfo("Faraz", 25);

            Console.WriteLine("\n→ Overloading = same method name, different parameter lists");
        }

        // Overload 1: one string
        private static void DisplayInfo(string name)
        {
            Console.WriteLine($"Name: {name}");
        }

        // Overload 2: one int
        private static void DisplayInfo(int age)
        {
            Console.WriteLine($"Age: {age} years");
        }

        // Overload 3: string + int
        private static void DisplayInfo(string name, int age)
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }
}