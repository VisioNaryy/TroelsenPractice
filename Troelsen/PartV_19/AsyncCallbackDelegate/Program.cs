using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncCallbackDelegate
{
    public delegate int BinaryOp(int x, int y);
    class Program
    {
        private static bool isDone = false;
        static void Main(string[] args)
        {
            Console.WriteLine($"Main() invoked on thread {Thread.CurrentThread.ManagedThreadId}.");
            BinaryOp added = Add;
            //именно вторичный поток вызывает AddComplete()
            IAsyncResult ar = added.BeginInvoke(5, 5,
                new AsyncCallback(AddComplete), "Some message from BeginInvoke...");
            while (!isDone)
            {
                Console.WriteLine("Some work...");
                Thread.Sleep(1000);
            }


            Console.ReadKey();
        }

        private static void AddComplete(IAsyncResult iar)
        {
            Console.WriteLine($"AddComplete() invoked on thread {Thread.CurrentThread.ManagedThreadId}.");
            Console.WriteLine("Your addition is complete");
            // Теперь получить результат.
            AsyncResult ar = (AsyncResult)iar;
            BinaryOp b = (BinaryOp)ar.AsyncDelegate;
            Console.WriteLine("10 + 10 is {0}.", b.EndInvoke(iar));
            Console.WriteLine(iar.AsyncState);
            isDone = true;
        }

        private static int Add(int x, int y)
        {
            Console.WriteLine($"Add() invoked on thread {Thread.CurrentThread.ManagedThreadId}.");
            Thread.Sleep(5000);
            return x + y;
        }
    }
}
