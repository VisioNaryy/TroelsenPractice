using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadStats
{
    class Program
    {
        static void Main(string[] args)
        {
            // Получить имя текущего потока.
            Thread primaryThread = Thread.CurrentThread;
            primaryThread.Name = "ThePrimaryThread";
            // Показать детали обслуживающего домена приложения и контекста.
            Console.WriteLine("Name of current AppDomain: {0}", Thread.GetDomain().FriendlyName); // Имя текущего домена приложения
            Console.WriteLine("ID of current Context: {0}",
            Thread.CurrentContext.ContextID); // Идентификатор текущего контекста
            // Вывести некоторую статистику о текущем потоке.
            Console.WriteLine("Thread Name: {0}",primaryThread.Name); // Имя потока
            Console.WriteLine("Has thread started?: {0}", primaryThread.IsAlive); // Запущен ли поток
            Console.WriteLine("Priority Level: {0}", primaryThread.Priority); // Приоритет потока
            Console.WriteLine("Thread State: {0}",primaryThread.ThreadState); // Состояние потока
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
