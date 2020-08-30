using System;

namespace SimpleFinalize
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Finalizers *****\n'j");
            Console.WriteLine("Hit the return key to shut down this app");
            Console.WriteLine("and force the GC to invoke FinalizeO");
            Console.WriteLine("for finalizable objects created in this AppDomain.");

            

            MyResourceWrapper rw = new MyResourceWrapper();

            Console.WriteLine("***** Dispose() / Destructor Combo Platter *****");
            // Call Dispose() manually. This will not call the finalizer.
            MyAnotherResourceWrapper rw2 = new MyAnotherResourceWrapper();
            rw2.Dispose();
            // Don't call Dispose(). This will trigger the finalizer and cause a beep.
            MyAnotherResourceWrapper rw3 = new MyAnotherResourceWrapper();
            Console.ReadLine();
        }
        public class MyResourceWrapper
        {
            // Clean up unmanaged resources here.
            // Beep when destroyed (testing purposes only!)
            ~MyResourceWrapper() => Console.Beep();
        }
    }
}
