using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Integer");
            Console.WriteLine(123_456);
            Console.Write("Long:");
            Console.WriteLine(123_456_789L);
            Console.Write("Float:");
            Console.WriteLine(123_456.1234F);
            Console.Write("Double:");
            Console.WriteLine(123_456.12);
            Console.Write("Decimal:");
            Console.WriteLine(123_456.12M);

            //
            Console.WriteLine("=> Escape characters:\a");
            string strWithTabs = "Model\tColor\tSpeed\tPet Name\a ";
            Console.WriteLine(strWithTabs);
            Console.WriteLine("Everyone loves V'Hello World\"\a ");
            Console.WriteLine("C:\\MyApp\\bin\\Debug\a ");
            // Добавить четыре пустых строки и снова выдать звуковой сигнал.
            Console.WriteLine("All finished.\n\n\n\a ");
            Console.WriteLine();
            Console.WriteLine(@"С:\MyApp\bin\Debug");

            string myLongString = @"This is a very
                very
                very
                long string";
            Console.WriteLine(myLongString);
        }
    }
}
