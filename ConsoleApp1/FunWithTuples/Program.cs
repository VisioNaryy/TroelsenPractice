using System;

namespace FunWithTuples
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = ("a", 2, "t");
            Console.WriteLine(values.Item1);
            Console.WriteLine(values.Item2);
            Console.WriteLine(values.Item3);
            Console.WriteLine();

            var sample = FillTheseValuesWithTuples();
            Console.WriteLine(sample);
            Console.WriteLine(sample.a);
            Console.WriteLine(sample.b);
            Console.WriteLine(sample.c);
      

        }

        static void FillTheseValues(out int a, out string b, out bool c)
        {
            a = 5;
            b = "Hey!";
            c = true;
        } 

        static (int a, string b, bool c) FillTheseValuesWithTuples()
        {
            return (6, "Tuples", false);
        }

        static (string first, string middle, string last) SplitNames(string fullName)
        {
            // Действия, необходимые для расщепления полного имени,
            return ("Philip", "F", "Japikse");
        }
    }
}
