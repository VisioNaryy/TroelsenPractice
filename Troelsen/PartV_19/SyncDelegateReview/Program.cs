using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SyncDelegateReview
{
    public delegate int BinaryOp(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            BinaryOp added = Add;
            int answer = added(10, 10);

            Console.WriteLine("Doing more work in Main()");
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
