using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;

namespace IDisposableDemo
{
    /// class Disposable implementing IDisposable interface.
    class Disposable : IDisposable
        {
            private bool disposed = false; // disposed variable is used as a flag which is set after dispose is called.
            SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true); // handle collecting all the unmanaged resources , here its a pointer 
            /// implementing Dispose method of interface ; which calls dispose method and supresses finalize as dispose is already cleaning unmanaged resources. 
            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }
        /// this method performs the actual work of releasing data.
            protected virtual void Dispose(bool disposing)
            {
                //block for unmanaged resources
                if (disposed)
                    return;
                // block for managed resources which we created to implement dispose.
                if (disposing)
                {
                    handle.Dispose();
                }
                disposed = true;
            }
            
            public static void Main(string[] args)
            {

            }
            ~Disposable()
            {
            Dispose(false);
            }
            

        
    }

}