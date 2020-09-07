using System;
using CarLibrary;

namespace CarLibraryReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //SportsCar sc = new SportsCar();
            //Type t = sc.GetType();
            //Console.WriteLine(t);

            Type t1 = typeof(SportsCar);
            //Console.WriteLine(t1);

            // Obtain type information using the static Type.GetType() method
            // (don't throw an exception if SportsCar cannot be found and ignore case).
            //Type t2 = Type.GetType("CarLibrary.SportsCar", false, true);

            Type t3 = Type.GetType("CarLibrary.SportsCar, CarLibrary");
            Console.WriteLine(t3);

            // Obtain type information for a nested enumeration
            // within the current assembly.
            Type t = Type.GetType("CarLibrary.SportsCar+EngineState");
            Console.WriteLine(t);

            Console.ReadKey();
        }
    }
}
