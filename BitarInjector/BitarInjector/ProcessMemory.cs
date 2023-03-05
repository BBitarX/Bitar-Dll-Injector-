// Did you ever think that furries might be commiting the animal equivalent to black face?
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BitarInjector;

namespace BitarInjector
{
    public class ProcessMemory
    {
        public ProcessMemory(Process process)
        {
            proc = process;
            ProcessHandle = Natives.OpenProcess(
                (int)ProcessAccessRight.PROCESS_CREATE_THREAD |
                (int)ProcessAccessRight.PROCESS_QUERY_INFORMATION |
                (int)ProcessAccessRight.PROCESS_VM_OPERATION |
                (int)ProcessAccessRight.PROCESS_VM_READ |
                (int)ProcessAccessRight.PROCESS_VM_WRITE,
                false,
                process.Id);
        }

        public IntPtr ProcessHandle { get; private set; }

        private Process proc;

        public bool Write(IntPtr baseAdress, string data)
        {
            return Write(baseAdress, Encoding.Default.GetBytes(data), (uint)data.Length + 1);
        }

        public bool Write(IntPtr baseAdress, byte[] buffer)
        {
            return Write(baseAdress, buffer, (uint)buffer.Length + 1);
        }

        public bool Write(IntPtr baseAdress, byte[] buffer, uint length)
        {
            UIntPtr bytesWritten;
            return Natives.WriteProcessMemory(ProcessHandle, baseAdress, buffer, length, out bytesWritten);
        }

        public IntPtr Alloc(IntPtr baseAdress, uint size)
        {
            return Alloc(baseAdress, size, ProcessPrivleges.MEM_COMMIT | ProcessPrivleges.MEM_RESERVE, MemoryProtections.PAGE_EXECUTE_READWRITE);
        }

        public IntPtr Alloc(IntPtr baseAdress, uint size, ProcessPrivleges privleges, MemoryProtections protections)
        {
            return Natives.VirtualAllocEx(ProcessHandle, baseAdress, size, (uint)privleges, (uint)protections);
        }
    }
}
