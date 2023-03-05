// Meet the natives... of Windows...
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace BitarInjector
{
    internal static class Natives
    {
        [DllImport("kernel32.dll")]
        internal static extern IntPtr OpenProcess(
            int desiredAcess,
            bool bInheritedHandle,
            int dwProcessId
            );

        [DllImport("kernel32.dll")]
        internal static extern IntPtr GetModuleHandle(
            string lpModuleName
            );

        [DllImport("kernel32.dll")]
        internal static extern IntPtr GetProcAddress(
            IntPtr hModule,
            string procName
            );

        [DllImport("kernel32.dll")]
        internal static extern IntPtr VirtualAllocEx(
            IntPtr hProcess,
            IntPtr lpBaseAddress,
            uint dwSize,
            uint fAllocationType,
            uint flProtect
            );

        [DllImport("kernel32.dll")]
        internal static extern bool WriteProcessMemory(
            IntPtr hProcess,
            IntPtr lpBaseAdress,
            byte[] lpBuffer,
            uint nSize,
            out UIntPtr numberOfBytesWritten
            );

        [DllImport("kernel32.dll")]
        internal static extern IntPtr CreateRemoteThread(
            IntPtr hProcess,
            IntPtr threadAttributes,
            uint dwStackSize,
            IntPtr lpStartAddress,
            IntPtr lpParameter,
            uint dwCreationFlags,
            IntPtr lpThreadId
            );

        [DllImport("kernel32.dll")]
        public static extern bool IsWow64Process(
            IntPtr hProc,
            out bool wow64Process
            );
    }
}
