using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Switch example");
            //Console.WriteLine("Chose your programming language");
            //int n = Int32.Parse(Console.ReadLine());
            //switch(n)
            //{
            //    case 1:
            //        Console.WriteLine("Good choice, C# is a fine language.");
            //        break;

            //    case 2:
            //        Console.WriteLine("VB: OOP, multithreading, and more!");
            //        break;
            //    default:
            //        Console.WriteLine("Well... good luck with that!");
            //        break;
            //}
            //Console.WriteLine("C# or VB");
            //Console.WriteLine("Chose your programming language");
            //string m = Console.ReadLine();
            //switch (m)
            //{
            //    case "C#": 
            //        Console.WriteLine("Good choice, C# is a fine language.");
            //        break; //goto case "VB";

            //    case "VB":
            //        Console.WriteLine("VB: OOP, multithreading, and more!");
            //        goto default;

            //    default:
            //        Console.WriteLine("Well... good luck with that!");
            //        break;
            //}

            Console.WriteLine("1 [Integer (5)], 2 [String (\"Hi\")]z 3 [Decimal(2.5)]");
            Console.Write("Please choose an option: ");
            string userChoice = Console.ReadLine();
            object choice;

            //This is a standard constant pattern switch statement to set up the example
            switch (userChoice)
            {
                case "1":
                    choice = 5;
                    break;
                case "2":
                    choice = "Hi";
                    break;
                case "3":
                    choice = 2.5;
                    break;
                default:
                    choice = 5;
                    break;
            }

            switch (choice)
            {
                case int i:
                    Console.WriteLine($"Your choice is an integer {i}.");
                    // Выбрано целое число
                    break;
                case string s:
                    Console.WriteLine($"Your choice is a string {s}.");
                    // Выбрана строка
                    break;
                case decimal d:
                    Console.WriteLine($"Your choice is a decimal {d}.");
                    // Выбрано десятичное число
                    break;
                default:
                    Console.WriteLine($"Your choice is something else");
                    // Выбрано что-то другое
                    break;
            }
            Console.WriteLine();


            //Console.WriteLine("1 [C#], 2 [VB]");
            //Console.Write("Please pick your language preference: ");
            //object langChoice = Console.ReadLine();

            //var choice = int.TryParse(langChoice.ToString(), out int с) ? c : langChoice;
            //switch (choice)
            //{
            //    case int i when i == 2:
            //    case string s when s.Equals("VB", StringComparison.OrdinalIgnoreCase):
            //        Console.WriteLine("VB: OOP, multithreading, and more!");
            //        // VB: ООП, многопоточность и многое другое!
            //        break;
            //    case int i when i == 1:
            //    case string s when s.Equals("C#", StringComparison.OrdinalIgnoreCase):
            //        Console.WriteLine("Good choice, C# is a fine language.");
            //        // Хороший выбор. C# - замечательный язык.
            //        break;
            //    default:
            //        Console.WriteLine("Well...good luck with that!");
            //        // Хорошо, удачи с этим!
            //        break;
            //}
            //Console.WriteLine();
        }
    }
}
