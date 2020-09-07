using System;
using System.IO;
using System.Reflection;

namespace LateBindingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Late Binding *****");
            // Try to load a local copy of CarLibrary.
            Assembly a = null;
            try
            {
                a = Assembly.LoadFrom("CarLibrary");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            if (a != null)
                CreateUsingLateBinding(a);
                //InvokeMethodWithArgsUsingLateBinding(a);
            Console.ReadLine();
        }
        static void CreateUsingLateBinding(Assembly asm)
        {
            try
            {
                // Get metadata for the Minivan type
                Type miniVan = asm.GetType("CarLibrary.MiniVan");
                // Create a Minivan instance on the fly.
                object obj = Activator.CreateInstance(miniVan);
                Console.WriteLine("Created a {0} using late binding!", obj);
                MethodInfo m1 = miniVan.GetMethod("TurboBoost");
                m1.Invoke(obj, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void InvokeMethodWithArgsUsingLateBinding(Assembly asm)
        {
            try
            {
                // Получить описание метаданных для типа SportsCar.
                Type sport = asm.GetType("CarLibrary.SportsCar");
                // Создать объект типа SportsCar.
                object obj = Activator.CreateInstance(sport);
                // Вызвать метод TurnOnRadio() с аргументами.
                MethodInfo mi = sport.GetMethod("TurnOnRadio");
                mi.Invoke(obj, new object[] { true, 2 });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
