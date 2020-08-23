using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int Main(string[] args)
        {
            string[] theArgs = Environment.GetCommandLineArgs();
            foreach (var arg in theArgs)
            {
                Console.WriteLine(arg);
            }
            ShowEnvironmentalDetailes();
            Console.ReadLine();

            return -1;
        }

        private static void ShowEnvironmentalDetailes()
        {
            // Вывести информацию о дисковых устройствах
            // данной машины и другие интересные детали,
            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine("Drive: {0}", drive); // Логические устройства
            Console.WriteLine("OS: {0}", Environment.OSVersion); // Версия
                                                                 // операционной системы
            Console.WriteLine("Number of processors: {0}",
            Environment.ProcessorCount); // Количество процессоров
            Console.WriteLine(".NET Version: {0}",
            Environment.Version); // Версия платформы .NET
        }
    }
}
