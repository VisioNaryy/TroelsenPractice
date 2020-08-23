using System;

namespace CarDelegateMethodGroupConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Car cl = new Car();
            cl.RegisterWithCarEngine(CallMeHere);
            Console.WriteLine("***** Speeding up *****");
            for (int i = 0; i < 6; i++)
                cl.Accelerate(20);
            // Отменить регистрацию простого имени метода.
            cl.UnRegisterWithCarEngine(CallMeHere);
            // Уведомления больше не поступают!
            for (int i = 0; i < 6; i++)
                cl.Accelerate(20);

            Console.ReadKey();
        }
        static void CallMeHere(string message)
        {
            Console.WriteLine(message);
        }
    }
}
