using System;
using System.Collections.Generic;

namespace InterfaceExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = { "this", "is", "example", "of", "interface", "extensions", "usage" };
            data.PrintDataNadBeep();

            List<int> myInt = new List<int> { 10, 2, 45, 62 };
            myInt.PrintDataNadBeep();
            Console.WriteLine(Data(10,20));

            Console.ReadKey();
        }
        private static int Data(int x, int y) => x + y;
    }
}
