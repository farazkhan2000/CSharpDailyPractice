using System;

using DailyPractice.Basics;
using DailyPractice.Conditionals;
using DailyPractice.Loops;
using DailyPractice.Methods;

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
            Console.WriteLine("  5   Simple if-else");
            Console.WriteLine("  6   else-if Ladder");
            Console.WriteLine("  7   switch Statement");
            Console.WriteLine("  8   Ternary Operator");

            Console.WriteLine("\nLoops:");
            Console.WriteLine("  9   For Loop Basics");
            Console.WriteLine(" 10   While Loop");
            Console.WriteLine(" 11   Do-While Loop");
            Console.WriteLine(" 12   Break and Continue");

            Console.WriteLine("\nMethods:");
            Console.WriteLine(" 13   Simple Method (no parameters)");
            Console.WriteLine(" 14   Method with Parameters");
            Console.WriteLine(" 15   Methods that Return Values");
            Console.WriteLine(" 16   Method Overloading");

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

                case "5": 
                    IfElseSimple.Run(); 
                    break;

                case "6": 
                    ElseIfLadder.Run(); 
                    break;

                case "7": 
                    SwitchStatement.Run(); 
                    break;
                case "8": 
                    TernaryOperator.Run(); 
                    break;

                case "9":
                    ForLoopBasics.Run();
                    break;

                case "10":
                    WhileLoop.Run();
                    break;

                case "11":
                    DoWhileLoop.Run();
                    break;

                case "12":
                    BreakAndContinue.Run();
                    break;

                case "13":
                    SimpleMethod.Run();
                    break;

                case "14":
                    MethodWithParameters.Run();
                    break;

                case "15":
                    ReturnValueExample.Run();
                    break;

                case "16":
                    MethodOverloading.Run();
                    break;

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