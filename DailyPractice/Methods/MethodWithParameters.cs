using System;

namespace DailyPractice.Methods
{
    public class MethodWithParameters
    {
        public static void Run()
        {
            Console.WriteLine("══════════════════════════════════════════");
            Console.WriteLine("       Methods with Parameters              ");
            Console.WriteLine("══════════════════════════════════════════");
            Console.WriteLine();

            GreetPerson("Faraz");
            GreetPerson("Alex");
            GreetPerson("Sara");

            Console.WriteLine();

            AddNumbers(8, 12);
            AddNumbers(25, 7);
        }

        // Method with one parameter
        private static void GreetPerson(string name)
        {
            Console.WriteLine($"Hello, {name}! Nice to meet you.");
        }

        // Method with two parameters
        private static void AddNumbers(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine($"{num1} + {num2} = {result}");
        }
    }
}