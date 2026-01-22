using System;

namespace DailyPractice.ArraysCollections
{
    public class ArrayOperations
    {
        public static void Run()
        {
            Console.WriteLine("══════════════════════════════════════════");
            Console.WriteLine("       Array Operations (Sum, Min, Max)     ");
            Console.WriteLine("══════════════════════════════════════════");
            Console.WriteLine();

            int[] numbers = { 12, 45, 7, 23, 89, 3, 56, 14 };

            Console.WriteLine("Numbers: " + string.Join(", ", numbers));

            // Sum with loop
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            Console.WriteLine($"Sum: {sum}");

            // Find min and max
            int min = numbers[0];
            int max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min) min = numbers[i];
                if (numbers[i] > max) max = numbers[i];
            }

            Console.WriteLine($"Smallest: {min}");
            Console.WriteLine($"Largest : {max}");

            // Average (using sum)
            double average = (double)sum / numbers.Length;
            Console.WriteLine($"Average : {average:F1}");
        }
    }
}