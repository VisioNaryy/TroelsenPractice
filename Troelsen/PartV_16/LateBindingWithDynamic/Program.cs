using System;
using System.Reflection;

namespace LateBindingWithDynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            AddWithReflection();
        }

        private static void AddWithReflection()
        {
            Assembly asm = Assembly.LoadFrom("MathLibrary");
            try
            {
                // Get metadata for the Minivan type.
                Type miniVan = asm.GetType("CarLibrary.MiniVan");
                // Create the Minivan on the fly.
                object obj = Activator.CreateInstance(miniVan);
                // Get info for TurboBoost.
                MethodInfo mi = miniVan.GetMethod("TurboBoost");
                // Invoke method ("null" for no parameters).
                mi.Invoke(obj, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
