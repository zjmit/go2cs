// Copyright 2015 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// +build linux
// +build mips64 mips64le

// package runtime -- go2cs converted at 2020 August 29 08:20:16 UTC
// import "runtime" ==> using runtime = go.runtime_package
// Original source: C:\Go\src\runtime\signal_linux_mips64x.go
using sys = go.runtime.@internal.sys_package;
using @unsafe = go.@unsafe_package;
using static go.builtin;

namespace go
{
    public static partial class runtime_package
    {
        private partial struct sigctxt
        {
            public ptr<siginfo> info;
            public unsafe.Pointer ctxt;
        }

        //go:nosplit
        //go:nowritebarrierrec
        private static ref sigcontext regs(this ref sigctxt c)
        {
            return ref (ucontext.Value)(c.ctxt).uc_mcontext;
        }

        private static ulong r0(this ref sigctxt c)
        {
            return c.regs().sc_regs[0L];
        }
        private static ulong r1(this ref sigctxt c)
        {
            return c.regs().sc_regs[1L];
        }
        private static ulong r2(this ref sigctxt c)
        {
            return c.regs().sc_regs[2L];
        }
        private static ulong r3(this ref sigctxt c)
        {
            return c.regs().sc_regs[3L];
        }
        private static ulong r4(this ref sigctxt c)
        {
            return c.regs().sc_regs[4L];
        }
        private static ulong r5(this ref sigctxt c)
        {
            return c.regs().sc_regs[5L];
        }
        private static ulong r6(this ref sigctxt c)
        {
            return c.regs().sc_regs[6L];
        }
        private static ulong r7(this ref sigctxt c)
        {
            return c.regs().sc_regs[7L];
        }
        private static ulong r8(this ref sigctxt c)
        {
            return c.regs().sc_regs[8L];
        }
        private static ulong r9(this ref sigctxt c)
        {
            return c.regs().sc_regs[9L];
        }
        private static ulong r10(this ref sigctxt c)
        {
            return c.regs().sc_regs[10L];
        }
        private static ulong r11(this ref sigctxt c)
        {
            return c.regs().sc_regs[11L];
        }
        private static ulong r12(this ref sigctxt c)
        {
            return c.regs().sc_regs[12L];
        }
        private static ulong r13(this ref sigctxt c)
        {
            return c.regs().sc_regs[13L];
        }
        private static ulong r14(this ref sigctxt c)
        {
            return c.regs().sc_regs[14L];
        }
        private static ulong r15(this ref sigctxt c)
        {
            return c.regs().sc_regs[15L];
        }
        private static ulong r16(this ref sigctxt c)
        {
            return c.regs().sc_regs[16L];
        }
        private static ulong r17(this ref sigctxt c)
        {
            return c.regs().sc_regs[17L];
        }
        private static ulong r18(this ref sigctxt c)
        {
            return c.regs().sc_regs[18L];
        }
        private static ulong r19(this ref sigctxt c)
        {
            return c.regs().sc_regs[19L];
        }
        private static ulong r20(this ref sigctxt c)
        {
            return c.regs().sc_regs[20L];
        }
        private static ulong r21(this ref sigctxt c)
        {
            return c.regs().sc_regs[21L];
        }
        private static ulong r22(this ref sigctxt c)
        {
            return c.regs().sc_regs[22L];
        }
        private static ulong r23(this ref sigctxt c)
        {
            return c.regs().sc_regs[23L];
        }
        private static ulong r24(this ref sigctxt c)
        {
            return c.regs().sc_regs[24L];
        }
        private static ulong r25(this ref sigctxt c)
        {
            return c.regs().sc_regs[25L];
        }
        private static ulong r26(this ref sigctxt c)
        {
            return c.regs().sc_regs[26L];
        }
        private static ulong r27(this ref sigctxt c)
        {
            return c.regs().sc_regs[27L];
        }
        private static ulong r28(this ref sigctxt c)
        {
            return c.regs().sc_regs[28L];
        }
        private static ulong r29(this ref sigctxt c)
        {
            return c.regs().sc_regs[29L];
        }
        private static ulong r30(this ref sigctxt c)
        {
            return c.regs().sc_regs[30L];
        }
        private static ulong r31(this ref sigctxt c)
        {
            return c.regs().sc_regs[31L];
        }
        private static ulong sp(this ref sigctxt c)
        {
            return c.regs().sc_regs[29L];
        }

        //go:nosplit
        //go:nowritebarrierrec
        private static ulong pc(this ref sigctxt c)
        {
            return c.regs().sc_pc;
        }

        private static ulong link(this ref sigctxt c)
        {
            return c.regs().sc_regs[31L];
        }
        private static ulong lo(this ref sigctxt c)
        {
            return c.regs().sc_mdlo;
        }
        private static ulong hi(this ref sigctxt c)
        {
            return c.regs().sc_mdhi;
        }

        private static uint sigcode(this ref sigctxt c)
        {
            return uint32(c.info.si_code);
        }
        private static ulong sigaddr(this ref sigctxt c)
        {
            return c.info.si_addr;
        }

        private static void set_r28(this ref sigctxt c, ulong x)
        {
            c.regs().sc_regs[28L] = x;

        }
        private static void set_r30(this ref sigctxt c, ulong x)
        {
            c.regs().sc_regs[30L] = x;

        }
        private static void set_pc(this ref sigctxt c, ulong x)
        {
            c.regs().sc_pc = x;

        }
        private static void set_sp(this ref sigctxt c, ulong x)
        {
            c.regs().sc_regs[29L] = x;

        }
        private static void set_link(this ref sigctxt c, ulong x)
        {
            c.regs().sc_regs[31L] = x;

        }

        private static void set_sigcode(this ref sigctxt c, uint x)
        {
            c.info.si_code = int32(x);

        }
        private static void set_sigaddr(this ref sigctxt c, ulong x)
        {
            (uintptr.Value)(add(@unsafe.Pointer(c.info), 2L * sys.PtrSize)).Value;

            uintptr(x);
        }
    }
}