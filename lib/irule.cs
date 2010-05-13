// The code is new, but the idea is from http://wiki.tcl.tk/9563

using System;
using System.Runtime.InteropServices;

namespace Irule
{
    public class TclInterp
    {
        [DllImport("libtcl.dylib")]
        protected static extern IntPtr Tcl_CreateInterp();

        [DllImport("libtcl.dylib")]
        protected static extern int Tcl_Init(IntPtr interp);

        [DllImport("libtcl.dylib")]
        protected static extern int Tcl_Eval(IntPtr interp, string script);

        [DllImport("libtcl.dylib")]
        protected static extern IntPtr Tcl_GetStringResult(IntPtr interp);

        [DllImport("libtcl.dylib")]
        protected static extern void Tcl_DeleteInterp(IntPtr interp);

        [DllImport("libtcl.dylib")]
        protected static extern void Tcl_Finalize();

        private IntPtr interp;
        private bool disposed;

        public TclInterp()
        {
            interp = Tcl_CreateInterp();
            Tcl_Init(interp);

            disposed = false;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing && interp != IntPtr.Zero)
                {
                    Tcl_DeleteInterp(interp);
                    Tcl_Finalize();
                }

                interp = IntPtr.Zero;
                disposed = true;
            }
        }

        public string Eval(string text)
        {
            if (disposed)
            {
                throw new ObjectDisposedException("Attempt to use disposed Tcl interpreter");
            }

            Tcl_Eval(interp, text);
            var result  = Tcl_GetStringResult(interp);
            return Marshal.PtrToStringAnsi(result);
        }
    }
}
