using System;
using System.Reflection;

namespace DynamicKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            //FIbonachi(9);

        }

        //private static void FIbonachi(int length)
        //{
        //    int a = 1, b = 1, c = 0;
        //    Console.Write($"{a} {b}");
        //    for (int i = 3; i < length; i++)
        //    {
        //        c = a + b;
        //        Console.Write($" {c}");
        //        a = b;
        //        b = c;
        //    }
        //}

        static void InvokeMembersOnDynamicData()
        {
            dynamic textData1 = "Hello";
            try
            {
                Console.WriteLine(textData1.ToUpper());
                Console.WriteLine(textData1.toupper());
                Console.WriteLine(textData1.Foo(10, "ee", DateTime.Now));
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void InvokeMethodWithDynamicKeyword(Assembly asm)
        {
            try
            {
                // Получить метаданные для типа MiniVan.
                //Type miniVan = asm.GetType("CarLibrary.MiniVan");
                // Создать экземпляр MiniVan на лету.
                //object obj = Activator.Createlnstance(miniVan);
                // Получить информацию о TurboBoost.
                //Methodlnfo mi = miniVan.GetMethod("TurboBoost");
                // Вызвать метод (null означает отсутствие параметров).
                //mi.Invoke(obj, null);


                // Получить метаданные для типа Minivan, используя dynamic
                Type miniVan = asm.GetType("CarLibrary.MiniVan");
                // Создать экземпляр MiniVan на лету и вызвать метод.
                dynamic obj = Activator.CreateInstance(miniVan);
                obj.TurboBoost();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
