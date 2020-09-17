using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AddWithThreads
{
    class Program
    {
        private static AutoResetEvent waitHandle = new AutoResetEvent(false);
        static void Main(string[] args)
        {
            Console.WriteLine($"ID of thread in Main() is {Thread.CurrentThread.ManagedThreadId}");
            AddParams ap = new AddParams(5, 12);
            Thread t = new Thread(new ParameterizedThreadStart(Add));
            //t.Start(ap);
            //Теперь это фоновый поток.
            t.IsBackground = true;
            t.Start(ap);
            // Ожидать, пока не поступит уведомление!
            waitHandle.WaitOne();
            Console.WriteLine("Other thread is done!");
            Console.ReadKey();
        }

        private static void Add(object data)
        {
            if (data is AddParams)
            {
                Console.WriteLine("ID of thread in Add(): {0}", Thread.CurrentThread.ManagedThreadId);
                Console.WriteLine($"Is thread in Add() is background? -> {Thread.CurrentThread.IsBackground}");
                AddParams ap = (AddParams)data;
                Console.WriteLine($"{ap.a} + {ap.b} is {ap.a+ap.b}");
                // Сообщить другому потоку о том, что работа завершена.
                waitHandle.Set();
            }
        }
    }
    public class AddParams
    {
        public int a { get; set; }
        public int b { get; set; }
        public AddParams(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
    }
}
