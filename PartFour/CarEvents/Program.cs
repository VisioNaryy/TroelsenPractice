using System;

namespace CarEvents
{
    class Program
    {
        static void Main(string[] args)
        {

            Car cl = new Car("SlugBug", 10, 100);
            // Зарегистрировать обработчики событий,
            cl.AboutToBlow += CarlsAlmostDoomed;
            cl.AboutToBlow += CarAboutToBlow;
            cl.Exploded += CarExploded;
            //с помощью лямбда-выражения
            cl.Exploded += ((object sender, CarEventArgs e) =>
            {
                Console.WriteLine(e.message);
            });
            Console.WriteLine("***** Speeding up *****");
            for (int i = 0; i < 6; i++) 
                cl.Accelerate(20);
            cl.Exploded -= CarExploded;
            Console.WriteLine("\n***** Speeding up *****");
            for (int i = 0; i < 6; i++)
                cl.Accelerate(20);
            Console.ReadLine();

        }
        public static void CarAboutToBlow(object sender, CarEventArgs e)
        { 
            Console.WriteLine(e.message); 
        }
        public static void CarlsAlmostDoomed(object sender, CarEventArgs e)
        {
            Console.WriteLine($"=> Critical Message from Car: {e.message}");
        }
        public static void CarExploded(object sender, CarEventArgs e)
        { 
            Console.WriteLine(e.message);
        }
    }
}
