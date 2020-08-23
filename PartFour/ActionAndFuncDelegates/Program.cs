using System;

namespace ActionAndFuncDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            // Использовать делегат Action<T> для указания на DisplayMessage.
            //тип делегата Action<T> позволяет указывать только на методы, возвращающие void
            Action<string, ConsoleColor, int> actionTarget = DisplayMessage;
            actionTarget("Action message!", ConsoleColor.Yellow, 5);
            //
            Func<int, int, int> funcTarget = Add;
            Console.WriteLine(Add(5,6));
            Func<int, int, string> funcTarget2 = SumToString;
            Console.WriteLine(SumToString(10,12));
            Console.ReadKey();
        }

        // Это цель для делегата Actiono.
        static void DisplayMessage(string message, ConsoleColor txtColor, int printCount)
        {
            // Установить цвет текста консоли.
            ConsoleColor previous = Console.ForegroundColor;
            Console.ForegroundColor = txtColor;
            for (int i = 0; i < printCount; i++)
            {
                Console.WriteLine(message);
            }
            // Восстановить цвет.
            Console.ForegroundColor = previous;
        }
        // Цель для делегата Funco.
        static int Add(int x, int y) => x + y;
        static string SumToString(int x, int y)
        {
            return (x + y).ToString();
        }
    }
}
