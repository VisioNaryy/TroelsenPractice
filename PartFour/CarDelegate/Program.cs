using System;

namespace CarDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Car cl = new Car("Slugbug", 10, 100);
            cl.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));
            //cl.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent2));
            //cl.UnRegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent2));
            Car.CarEngineHandler handler2 = new Car.CarEngineHandler(OnCarEngineEvent2);
            cl.RegisterWithCarEngine(handler2);
            // Увеличить скорость (это инициирует события).
            Console.WriteLine("***** Speeding пр *****");
            for (int i = 0; i < 6; i++)
            {
                cl.Accelerate(20);
            }
            
            // Отменить регистрацию второго обработчика
            cl.UnRegisterWithCarEngine(handler2);
            Console.WriteLine("***** Speeding пр *****");
            for (int i = 0; i < 6; i++)
            {
                cl.Accelerate(20);
            }
            Console.ReadKey();
        }

        public static void OnCarEngineEvent(string message)
        {
            Console.WriteLine(message);
        }
        public static void OnCarEngineEvent2(string message)
        {
            Console.WriteLine(message.ToUpper());
        }
    }
}
