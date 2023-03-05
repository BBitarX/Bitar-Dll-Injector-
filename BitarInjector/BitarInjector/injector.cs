// Who asked you say? Well no one... but HA! You cared enough to tell me that so :P
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BitarInjector
{
    public enum InjectorResult
    {
        InjectionComplete,
        FailedNoDllFound,
        FailedToWriteMemory
    }

    public class Injector
    {
        public InjectorResult InjectByProcName(string processName, string dllToInject)
        {
            return Inject(Process.GetProcessesByName(processName)[0], dllToInject);
        }

        public InjectorResult Inject(Process process, string dllToInject)
        {
            if (!File.Exists(dllToInject))
                return InjectorResult.FailedNoDllFound;

            ProcessMemory pMem = new ProcessMemory(process);

            // Get address of "LoadLibraryA()" func in the "kernel32.dll"
            IntPtr loadLibAddr = GetModuleHandleAdress("kernel32.dll", "LoadLibraryA");

            uint size = (uint)((dllToInject.Length + 1) * Marshal.SizeOf(typeof(char)));
            IntPtr allocAddress = pMem.Alloc(IntPtr.Zero, size);

            if (!pMem.Write(allocAddress, dllToInject))
                return InjectorResult.FailedToWriteMemory;

            Natives.CreateRemoteThread(
                pMem.ProcessHandle,
                IntPtr.Zero,
                0,
                loadLibAddr,
                allocAddress,
                0,
                IntPtr.Zero
                );

            return InjectorResult.InjectionComplete;
        }

        public IntPtr GetModuleHandleAdress(string moduleName, string funcName)
        {
            return Natives.GetProcAddress(Natives.GetModuleHandle(moduleName), funcName);
        }
    }
}
