using System;

namespace DailyPractice.ArraysCollections
{
    public class SingleDimensionArrays
    {
        public static void Run()
        {
            Console.WriteLine("══════════════════════════════════════════");
            Console.WriteLine("       Single Dimension Arrays              ");
            Console.WriteLine("══════════════════════════════════════════");
            Console.WriteLine();

            // Declare and initialize in one line
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            Console.WriteLine("Days of the week:");
            for (int i = 0; i < daysOfWeek.Length; i++)
            {
                Console.WriteLine($"  {i + 1,2}. {daysOfWeek[i]}");
            }

            Console.WriteLine($"\nTotal days: {daysOfWeek.Length}");

            // Change one element
            daysOfWeek[5] = "Weekend Day 1"; // Saturday
            daysOfWeek[6] = "Weekend Day 2"; // Sunday

            Console.WriteLine("\nAfter weekend rename:");
            Console.WriteLine(string.Join(" | ", daysOfWeek));
        }
    }
}