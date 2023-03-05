namespace BitarInjector
{
    public enum ProcessPrivleges : int
    {
        MEM_COMMIT = 0x00001000,
        MEM_RESERVE = 0x00002000,
        MEM_RESET = 0x00080000,
        MEM_RESET_UNDO = 0x1000000,
        MEM_LARGE_PAGES = 0x20000000,
        MEM_PHYSICAL = 0x00400000,
        MEM_TOP_DOWN = 0x00100000
    }

    public enum ProcessAccessRight : int
    {
        PROCESS_ALL_ACCESS = 0xFFFF,
        PROCESS_CREATE_PROCESS = 0x0080,
        PROCESS_CREATE_THREAD = 0x0002,
        PROCESS_DUP_HANDLE = 0x0040,
        PROCESS_QUERY_INFORMATION = 0x0400,
        PROCESS_QUERY_LIMITED_INFORMATION = 0x1000,
        PROCESS_SET_INFORMATION = 0x0200,
        PROCESS_SET_QUOTA = 0x0100,
        PROCESS_SUSPEND_RESUME = 0x0800,
        PROCESS_TERMINATE = 0x0001,
        PROCESS_VM_OPERATION = 0x0008,
        PROCESS_VM_READ = 0x0010,
        PROCESS_VM_WRITE = 0x0020,
    }

    public enum MemoryProtections : int
    {
        PAGE_EXECUTE = 0x10,
        PAGE_EXECUTE_READ = 0x20,
        PAGE_EXECUTE_READWRITE = 0x40,
        PAGE_EXECUTE_WRITECOPY = 0x80,
        PAGE_NOACCESS = 0x01,
        PAGE_READONLY = 0x02,
        PAGE_READWRITE = 0x04,
        PAGE_WRITECOPY = 0x08,
        PAGE_TARGETS_INVALID = 0x40000000,
        PAGE_TARGETS_NO_UPDATE = 0x40000000
    }
}
