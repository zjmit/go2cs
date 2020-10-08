// Code generated by linux/mkall.go generatePtracePair("mipsle", "mips64le"). DO NOT EDIT.

// +build linux
// +build mipsle mips64le

// package unix -- go2cs converted at 2020 October 08 04:49:29 UTC
// import "cmd/vendor/golang.org/x/sys/unix" ==> using unix = go.cmd.vendor.golang.org.x.sys.unix_package
// Original source: C:\Go\src\cmd\vendor\golang.org\x\sys\unix\zptrace_mipsnnle_linux.go
using @unsafe = go.@unsafe_package;
using static go.builtin;

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class unix_package
    {
        // PtraceRegsMipsle is the registers used by mipsle binaries.
        public partial struct PtraceRegsMipsle
        {
            public array<ulong> Regs;
            public ulong Lo;
            public ulong Hi;
            public ulong Epc;
            public ulong Badvaddr;
            public ulong Status;
            public ulong Cause;
        }

        // PtraceGetRegsMipsle fetches the registers used by mipsle binaries.
        public static error PtraceGetRegsMipsle(long pid, ptr<PtraceRegsMipsle> _addr_regsout)
        {
            ref PtraceRegsMipsle regsout = ref _addr_regsout.val;

            return error.As(ptrace(PTRACE_GETREGS, pid, 0L, uintptr(@unsafe.Pointer(regsout))))!;
        }

        // PtraceSetRegsMipsle sets the registers used by mipsle binaries.
        public static error PtraceSetRegsMipsle(long pid, ptr<PtraceRegsMipsle> _addr_regs)
        {
            ref PtraceRegsMipsle regs = ref _addr_regs.val;

            return error.As(ptrace(PTRACE_SETREGS, pid, 0L, uintptr(@unsafe.Pointer(regs))))!;
        }

        // PtraceRegsMips64le is the registers used by mips64le binaries.
        public partial struct PtraceRegsMips64le
        {
            public array<ulong> Regs;
            public ulong Lo;
            public ulong Hi;
            public ulong Epc;
            public ulong Badvaddr;
            public ulong Status;
            public ulong Cause;
        }

        // PtraceGetRegsMips64le fetches the registers used by mips64le binaries.
        public static error PtraceGetRegsMips64le(long pid, ptr<PtraceRegsMips64le> _addr_regsout)
        {
            ref PtraceRegsMips64le regsout = ref _addr_regsout.val;

            return error.As(ptrace(PTRACE_GETREGS, pid, 0L, uintptr(@unsafe.Pointer(regsout))))!;
        }

        // PtraceSetRegsMips64le sets the registers used by mips64le binaries.
        public static error PtraceSetRegsMips64le(long pid, ptr<PtraceRegsMips64le> _addr_regs)
        {
            ref PtraceRegsMips64le regs = ref _addr_regs.val;

            return error.As(ptrace(PTRACE_SETREGS, pid, 0L, uintptr(@unsafe.Pointer(regs))))!;
        }
    }
}}}}}}
