using System;
using System.Collections;
using System.Collections.Generic;

namespace SimpleLambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>{ 2, 4, 7, 17, 44, 82 };
            //List<int> evenNumbers2 = list.FindAll(delegate (int i)
            //{
            //    return i % 2 == 0;
            //});
            List<int> evenNumbers = list.FindAll(i => i % 2 == 0);
            foreach (var e in evenNumbers)
            {
                Console.WriteLine($"Even number in list: {e}");
            }
            Console.ReadKey();
        }

        static void LambdaExpressionSyntax()
        {
            // Создать список целочисленных значений.
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });
            // Обработать каждый аргумент внутри группы операторов кода.
            List<int> evenNumbers = list.FindAll((i) =>
            {
                Console.WriteLine("value of i is currently: {0}", i); //текущее значение l
                bool isEven = ((i % 2) == 0);
                return isEven;
            });
            // Вывести четные числа.
            Console.WriteLine("Here are your even numbers:");
            foreach (int evenNumber in evenNumbers)
            {
                Console.Write("{0}\t", evenNumber);
            }
            Console.WriteLine();
        }
    }
}
