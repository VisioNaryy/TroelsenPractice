using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ASyncDelegate
{
    public delegate int BinaryOp(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Main() invoked on thread {Thread.CurrentThread.ManagedThreadId}.");

            //BinaryOp added = Add;
            //// После обработки следующего оператора вызывающий поток
            //// блокируется, пока не будет завершен Beginlnvoke() .
            //IAsyncResult ar = added.BeginInvoke(5, 5, null, null);
            //// Этот вызов занимает намного меньше пяти секунд!
            //Console.WriteLine("Doing more work in Main()");
            //// Снова происходит ожидание завершения другого потока!
            //int answer = added.EndInvoke(ar);
            //Console.WriteLine($"Answer is {answer}");

            //another case
            BinaryOp added = Add;

            IAsyncResult ar = added.BeginInvoke(5, 5, null, null);
            //while (!ar.IsCompleted)
            //{
            //    Console.WriteLine("Doing more work in Main()!");
            //    Thread.Sleep(1000);
            //}
            while (!ar.AsyncWaitHandle.WaitOne(1000, true))
            {
                Console.WriteLine("Doing more work in Main()");
            }

            int answer = added.EndInvoke(ar);
            Console.WriteLine($"Answer is {answer}");

            Console.ReadKey();
        }
        private static int Add(int x, int y)
        {
            Console.WriteLine($"Add() invoked on thread {Thread.CurrentThread.ManagedThreadId}.");
            Thread.Sleep(5000);
            return x + y;
        }
    }
}
