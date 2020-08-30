using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFinalize
{
    public class MyAnotherResourceWrapper : IDisposable
    {
        //// The garbage collector will call this method if the object user forgets to call Dispose().
        //~MyResourceWrapper()
        //{
        //    // Clean up any internal unmanaged resources.
        //    // Do **not** call Dispose() on any managed objects.
        //}
        //// The object user will call this method to clean up resources ASAP.
        //public void Dispose()
        //{
        //    // Clean up unmanaged resources here.
        //    // Call Dispose() on other contained disposable objects.
        //    // No need to finalize if user called Dispose(), so suppress finalization.
        //    GC.SuppressFinalize(this);
        //}

        // Used to determine if Dispose() has already been called.
        private bool disposed = false;
        public void Dispose()
        {
            // Call our helper method.
            // Specifying "true" signifies that the object user triggered the cleanup.
            CleanUp(true);
            // Now suppress finalization.
            GC.SuppressFinalize(this);
        }
        private void CleanUp(bool disposing)
        {
            // Be sure we have not already been disposed!
            if (!this.disposed)
            {
                // If disposing equals true, dispose all managed resources.
                if (disposing)
                {
                    // Dispose managed resources.
                }
                // Clean up unmanaged resources here.
            }
            disposed = true;
        }
        ~MyAnotherResourceWrapper()
        {
            // Call our helper method.
            // Specifying "false" signifies that the GC triggered the cleanup.
            Console.Beep();
            // Call our helper method.
            // Specifying "false" signifies that the GC triggered the cleanup.
            CleanUp(false);

        }

    }
}
