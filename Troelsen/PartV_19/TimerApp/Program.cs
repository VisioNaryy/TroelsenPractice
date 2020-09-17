using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TimerApp
{
    class Program
    {
        static void Main(string[] args)
        {

            TimerCallback timerCallback = new TimerCallback(PrintTime);
            //Timer t = new Timer
            //(
            //    timerCallback,
            //    null,
            //    0,
            //    1000
            //);
            Console.WriteLine("Hit key to terminate");
            // Установить параметры таймера.
            Timer t1 = new Timer(timerCallback, "Hello From Main", 0, 1000);

            Console.ReadKey();
        }

        private static void PrintTime(object state)
        {
            Console.WriteLine($"Time is {DateTime.Now.ToLongTimeString()}, Param is {state.ToString()}");
        }
    }
}
