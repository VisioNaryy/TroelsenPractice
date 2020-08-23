using System;

namespace AnonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            BuildAnonType("Volvo", "Silver", 100);

            Console.ReadKey();
        }

        private static void BuildAnonType(string make, string color, int currSp)
        {
            var car = new { Make = make, Color = color, Speed = currSp };
            Console.WriteLine($"You have a {car.Color} {car.Make} going {car.Speed} MPH");
            // Анонимные типы имеют специальные реализации каждого
            // виртуального метода System.Object. Например:
            Console.WriteLine($"ToString() == {car.ToString()}");
        }
    }
}
