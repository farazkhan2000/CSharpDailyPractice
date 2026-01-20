using System;

// Add using for every folder you use exercises from
using DailyPractice.Basics;
//using DailyPractice.Conditionals;
// using DailyPractice.Loops;          // uncomment when you add this folder
// using DailyPractice.Methods;         // uncomment later

namespace DailyPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("     C# Daily Practice - Menu        ");
            Console.WriteLine("=====================================");
            Console.WriteLine();

            // ── MENU OPTIONS ────────────────────────────────────────
            Console.WriteLine("Basics:");
            Console.WriteLine("  1   Hello World");
            Console.WriteLine("  2   Variables and Data Types");
            Console.WriteLine("  3   Math Operations");
            Console.WriteLine("  4   String Basics");

            Console.WriteLine("\nConditionals:");
            //Console.WriteLine("  3   Simple if-else");
            // Console.WriteLine("  4   Else-if ladder");     // add when ready
            // Console.WriteLine("  5   Switch example");

            // Console.WriteLine("\nLoops:");
            // Console.WriteLine("  6   For loop basics");
            // ... add more later

            Console.WriteLine("\n0   Exit");
            Console.WriteLine("=====================================");
            Console.Write("\nEnter number (0 to exit): ");

            string choice = Console.ReadLine()?.Trim() ?? "";

            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    HelloWorld.Run();
                    break;

                case "2":
                    VariablesAndDataTypes.Run();
                    break;

                case "3":
                    MathOperations.Run();
                    break;

                case "4":
                    StringBasics.Run();
                    break;

                //case "3":
                //    IfElseSimple.Run();
                //    break;

                // case "4":
                //     ElseIfLadder.Run();
                //     break;

                case "0":
                    Console.WriteLine("Goodbye! See you next time.");
                    return;  // exit the program

                default:
                    Console.WriteLine("Invalid choice. Press any key to try again...");
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);  // restart menu (simple recursion)
                    return;
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to return to menu...");
            Console.ReadKey();
            Console.Clear();

            // Loop back to show menu again
            Main(args);
        }
    }
}