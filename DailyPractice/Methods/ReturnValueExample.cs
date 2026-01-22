using System;

namespace DailyPractice.Methods
{
    public class ReturnValueExample
    {
        public static void Run()
        {
            Console.WriteLine("══════════════════════════════════════════");
            Console.WriteLine("       Methods that Return a Value          ");
            Console.WriteLine("══════════════════════════════════════════");
            Console.WriteLine();

            // Calling methods that return values
            int sum = AddAndReturn(45, 18);
            Console.WriteLine($"45 + 18 = {sum}");

            double average = CalculateAverage(10, 20, 30);
            Console.WriteLine($"Average of 10, 20, 30 = {average:F1}");

            string upperName = GetUppercase("faraz");
            Console.WriteLine($"Uppercase version: {upperName}");
        }

        // Returns an int
        private static int AddAndReturn(int a, int b)
        {
            return a + b;
        }

        // Returns a double
        private static double CalculateAverage(int num1, int num2, int num3)
        {
            return (num1 + num2 + num3) / 3.0; // 3.0 makes it floating-point division
        }

        // Returns a string
        private static string GetUppercase(string text)
        {
            return text.ToUpper();
        }
    }
}