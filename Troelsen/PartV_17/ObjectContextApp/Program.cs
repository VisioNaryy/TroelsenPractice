using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ObjectContextApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SportsCar sport = new SportsCar();
            Console.WriteLine();
            SportsCar sport2 = new SportsCar();
            Console.WriteLine();
            SportsCarTS synchroSport = new SportsCarTS();

            Console.WriteLine("*****");
            AppDomain ad = Thread.GetDomain();
            Console.WriteLine(ad);
            Context c = Thread.CurrentContext;
            Console.WriteLine(c);

            Console.ReadLine();
        }

    }
    public class SportsCar
    {

        public SportsCar()
        {
            Context context = Thread.CurrentContext;
            Console.WriteLine($"{this} object in context {context.ContextID}");
            foreach (var item in context.ContextProperties)
            {
                Console.WriteLine($"Context props: {item.Name}");
            }
        }
    }
    [Synchronization]
    public class SportsCarTS: ContextBoundObject
    {
        public SportsCarTS()
        {
            Context context = Thread.CurrentContext;
            Console.WriteLine($"{this} object in context {context.ContextID}");
            foreach (var item in context.ContextProperties)
            {
                Console.WriteLine($"Context props: {item.Name}");
            }
        }
    }


}
