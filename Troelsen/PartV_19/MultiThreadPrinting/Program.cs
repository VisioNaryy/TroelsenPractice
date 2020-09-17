using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Printer p = new Printer();
            // Создать 10 потоков, которые указывают на один
            //и тот же метод того же самого объекта.
            Thread[] threads = new Thread[10];
            for (int i = 0; i < 10; i++)
            {
                threads[i] = new Thread(new ThreadStart(p.PrintNumbers))
                {
                    Name = $"Worker thread #{i}"
                };
                // Теперь запустить их все.
                foreach (Thread t in threads)
                {
                    t.Start();
                }
                Console.ReadLine();
            }
        }
        public class Printer
        {
            //lock marker
            private object threadLock = new object();
            public void PrintNumbers()
            {
                lock (threadLock)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name} is executing PrintNumbers");
                    //output numbers
                    Console.WriteLine("Your numbers: ");
                    for (int i = 0; i < 10; i++)
                    {
                        Random r = new Random();
                        Thread.Sleep(1000 * r.Next(5));
                        Console.Write($"{i}, ");
                    }
                    Console.WriteLine();
                }
               
            }


        }
    }
}

