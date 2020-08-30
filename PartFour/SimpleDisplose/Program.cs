using System;

namespace SimpleDisplose
{
    class Program
    {
        static void Main(string[] args)
        {
            MyResourceWrapper rw = new MyResourceWrapper();
            rw.Dispose();
            Console.ReadLine();
        }

        public class MyResourceWrapper:IDisposable
        {
            // The object user should call this method
            // when they finish with the object.
            public void Dispose()
            {
                // Clean up unmanaged resources...
                // Dispose other contained disposable objects...
                // Just for a test.
                Console.WriteLine("***** In Dispose! *****");
            }
        }
    }
}
