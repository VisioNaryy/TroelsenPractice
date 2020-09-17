using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FunWithCSharpAsync
{
    class Program
    {
        static async Task Main(string[] args)
        {
            List<int> l = default;
            //Console.WriteLine(DoWork());
            string mes = await DoWorkAsync();
            Console.WriteLine(mes);
            Console.WriteLine("Completed");
            Console.ReadLine();
        }
        static string DoWork()
        {
            Thread.Sleep(2000);
            return "Some work was done";
        }
        static async Task<string> DoWorkAsync()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(2000);
                return "Some work was done";
            });
        }
        static async Task MethodReturningSomeVoid()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Some work in async void method");
            });
        }
        static async ValueTask<int> ReturnAtInt()
        {
            await Task.Delay(1000);
            return 5;
        }
        static async Task MethodWithProblems(int fp, int sp)
        {
            Console.WriteLine("Enter");
            if(sp < 0)
            {
                Console.WriteLine("bad data");
                return;
            }
            actualImplementation();
            async Task actualImplementation()
            {
                await Task.Run(() =>
                {
                    Thread.Sleep(1000);
                    Console.WriteLine($"First complete");
                    // Вызвать еще один длительно выполняющийся метод, который терпит
                    // неудачу из-за того, что значение второго параметра выходит
                    //за пределы допустимого диапазона.
                    Console.WriteLine("Something bad happened");
                });
            }
            
        }
    }
}
