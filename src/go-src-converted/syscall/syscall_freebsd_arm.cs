// Copyright 2012 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package syscall -- go2cs converted at 2020 August 29 08:37:57 UTC
// import "syscall" ==> using syscall = go.syscall_package
// Original source: C:\Go\src\syscall\syscall_freebsd_arm.go
using @unsafe = go.@unsafe_package;
using static go.builtin;

namespace go
{
    public static partial class syscall_package
    {
        private static Timespec setTimespec(long sec, long nsec)
        {
            return new Timespec(Sec:sec,Nsec:int32(nsec));
        }

        private static Timeval setTimeval(long sec, long usec)
        {
            return new Timeval(Sec:sec,Usec:int32(usec));
        }

        public static void SetKevent(ref Kevent_t k, long fd, long mode, long flags)
        {
            k.Ident = uint32(fd);
            k.Filter = int16(mode);
            k.Flags = uint16(flags);
        }

        private static void SetLen(this ref Iovec iov, long length)
        {
            iov.Len = uint32(length);
        }

        private static void SetControllen(this ref Msghdr msghdr, long length)
        {
            msghdr.Controllen = uint32(length);
        }

        private static void SetLen(this ref Cmsghdr cmsg, long length)
        {
            cmsg.Len = uint32(length);
        }

        private static (long, error) sendfile(long outfd, long infd, ref long offset, long count)
        {
            ulong writtenOut = 0L;
            var (_, _, e1) = Syscall9(SYS_SENDFILE, uintptr(infd), uintptr(outfd), uintptr(offset.Value), uintptr((offset.Value) >> (int)(32L)), uintptr(count), 0L, uintptr(@unsafe.Pointer(ref writtenOut)), 0L, 0L);

            written = int(writtenOut);

            if (e1 != 0L)
            {
                err = e1;
            }
            return;
        }

        public static (System.UIntPtr, System.UIntPtr, Errno) Syscall9(System.UIntPtr num, System.UIntPtr a1, System.UIntPtr a2, System.UIntPtr a3, System.UIntPtr a4, System.UIntPtr a5, System.UIntPtr a6, System.UIntPtr a7, System.UIntPtr a8, System.UIntPtr a9)
; // sic
    }
}