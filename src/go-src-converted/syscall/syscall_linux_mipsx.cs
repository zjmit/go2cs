// Copyright 2016 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// +build linux
// +build mips mipsle

// package syscall -- go2cs converted at 2020 October 08 03:27:33 UTC
// import "syscall" ==> using syscall = go.syscall_package
// Original source: C:\Go\src\syscall\syscall_linux_mipsx.go
using @unsafe = go.@unsafe_package;
using static go.builtin;

namespace go
{
    public static partial class syscall_package
    {
        private static readonly var _SYS_setgroups = (var)SYS_SETGROUPS;



        public static (System.UIntPtr, System.UIntPtr, Errno) Syscall9(System.UIntPtr trap, System.UIntPtr a1, System.UIntPtr a2, System.UIntPtr a3, System.UIntPtr a4, System.UIntPtr a5, System.UIntPtr a6, System.UIntPtr a7, System.UIntPtr a8, System.UIntPtr a9)
;

        //sys    Dup2(oldfd int, newfd int) (err error)
        //sysnb    EpollCreate(size int) (fd int, err error)
        //sys    Fchown(fd int, uid int, gid int) (err error)
        //sys    fstatat(dirfd int, path string, stat *Stat_t, flags int) (err error) = SYS_FSTATAT64
        //sys    Ftruncate(fd int, length int64) (err error) = SYS_FTRUNCATE64
        //sysnb    Getegid() (egid int)
        //sysnb    Geteuid() (euid int)
        //sysnb    Getgid() (gid int)
        //sysnb    Getuid() (uid int)
        //sys    Lchown(path string, uid int, gid int) (err error)
        //sys    Listen(s int, n int) (err error)
        //sys    Pause() (err error)
        //sys    Pread(fd int, p []byte, offset int64) (n int, err error) = SYS_PREAD64
        //sys    Pwrite(fd int, p []byte, offset int64) (n int, err error) = SYS_PWRITE64
        //sys    Renameat(olddirfd int, oldpath string, newdirfd int, newpath string) (err error)
        //sys    Select(nfd int, r *FdSet, w *FdSet, e *FdSet, timeout *Timeval) (n int, err error) = SYS__NEWSELECT
        //sys    sendfile(outfd int, infd int, offset *int64, count int) (written int, err error) = SYS_SENDFILE64
        //sys    Setfsgid(gid int) (err error)
        //sys    Setfsuid(uid int) (err error)
        //sysnb    Setregid(rgid int, egid int) (err error)
        //sysnb    Setresgid(rgid int, egid int, sgid int) (err error)
        //sysnb    Setresuid(ruid int, euid int, suid int) (err error)

        //sysnb    Setreuid(ruid int, euid int) (err error)
        //sys    Shutdown(fd int, how int) (err error)
        //sys    Splice(rfd int, roff *int64, wfd int, woff *int64, len int, flags int) (n int, err error)

        //sys    SyncFileRange(fd int, off int64, n int64, flags int) (err error)
        //sys    Truncate(path string, length int64) (err error) = SYS_TRUNCATE64
        //sys    Ustat(dev int, ubuf *Ustat_t) (err error)
        //sys    accept(s int, rsa *RawSockaddrAny, addrlen *_Socklen) (fd int, err error)
        //sys    accept4(s int, rsa *RawSockaddrAny, addrlen *_Socklen, flags int) (fd int, err error)
        //sys    bind(s int, addr unsafe.Pointer, addrlen _Socklen) (err error)
        //sys    connect(s int, addr unsafe.Pointer, addrlen _Socklen) (err error)
        //sysnb    getgroups(n int, list *_Gid_t) (nn int, err error)
        //sysnb    setgroups(n int, list *_Gid_t) (err error)
        //sys    getsockopt(s int, level int, name int, val unsafe.Pointer, vallen *_Socklen) (err error)
        //sys    setsockopt(s int, level int, name int, val unsafe.Pointer, vallen uintptr) (err error)
        //sysnb    socket(domain int, typ int, proto int) (fd int, err error)
        //sysnb    socketpair(domain int, typ int, proto int, fd *[2]int32) (err error)
        //sysnb    getpeername(fd int, rsa *RawSockaddrAny, addrlen *_Socklen) (err error)
        //sysnb    getsockname(fd int, rsa *RawSockaddrAny, addrlen *_Socklen) (err error)
        //sys    recvfrom(fd int, p []byte, flags int, from *RawSockaddrAny, fromlen *_Socklen) (n int, err error)
        //sys    sendto(s int, buf []byte, flags int, to unsafe.Pointer, addrlen _Socklen) (err error)
        //sys    recvmsg(s int, msg *Msghdr, flags int) (n int, err error)
        //sys    sendmsg(s int, msg *Msghdr, flags int) (n int, err error)

        //sysnb    InotifyInit() (fd int, err error)
        //sys    Ioperm(from int, num int, on int) (err error)
        //sys    Iopl(level int) (err error)

        //sys    futimesat(dirfd int, path string, times *[2]Timeval) (err error)
        //sysnb    Gettimeofday(tv *Timeval) (err error)
        //sysnb    Time(t *Time_t) (tt Time_t, err error)
        //sys    Utime(path string, buf *Utimbuf) (err error)
        //sys    utimes(path string, times *[2]Timeval) (err error)

        //sys    Lstat(path string, stat *Stat_t) (err error) = SYS_LSTAT64
        //sys    Fstat(fd int, stat *Stat_t) (err error) = SYS_FSTAT64
        //sys    Stat(path string, stat *Stat_t) (err error) = SYS_STAT64
        //sys    EpollWait(epfd int, events []EpollEvent, msec int) (n int, err error)

        public static error Fstatfs(long fd, ptr<Statfs_t> _addr_buf)
        {
            error err = default!;
            ref Statfs_t buf = ref _addr_buf.val;

            var (_, _, e) = Syscall(SYS_FSTATFS64, uintptr(fd), @unsafe.Sizeof(buf), uintptr(@unsafe.Pointer(buf)));
            if (e != 0L)
            {>>MARKER:FUNCTION_Syscall9_BLOCK_PREFIX<<
                err = errnoErr(e);
            }

            return ;

        }

        public static error Statfs(@string path, ptr<Statfs_t> _addr_buf)
        {
            error err = default!;
            ref Statfs_t buf = ref _addr_buf.val;

            var (p, err) = BytePtrFromString(path);
            if (err != null)
            {
                return error.As(err)!;
            }

            var (_, _, e) = Syscall(SYS_STATFS64, uintptr(@unsafe.Pointer(p)), @unsafe.Sizeof(buf), uintptr(@unsafe.Pointer(buf)));
            if (e != 0L)
            {
                err = errnoErr(e);
            }

            return ;

        }

        public static (long, error) Seek(long fd, long offset, long whence)
        {
            long off = default;
            error err = default!;

            var (_, _, e) = Syscall6(SYS__LLSEEK, uintptr(fd), uintptr(offset >> (int)(32L)), uintptr(offset), uintptr(@unsafe.Pointer(_addr_off)), uintptr(whence), 0L);
            if (e != 0L)
            {
                err = errnoErr(e);
            }

            return ;

        }

        private static Timespec setTimespec(long sec, long nsec)
        {
            return new Timespec(Sec:int32(sec),Nsec:int32(nsec));
        }

        private static Timeval setTimeval(long sec, long usec)
        {
            return new Timeval(Sec:int32(sec),Usec:int32(usec));
        }

        //sysnb pipe2(p *[2]_C_int, flags int) (err error)

        public static error Pipe2(slice<long> p, long flags)
        {
            error err = default!;

            if (len(p) != 2L)
            {
                return error.As(EINVAL)!;
            }

            ref array<_C_int> pp = ref heap(new array<_C_int>(2L), out ptr<array<_C_int>> _addr_pp);
            err = pipe2(_addr_pp, flags);
            p[0L] = int(pp[0L]);
            p[1L] = int(pp[1L]);
            return ;

        }

        //sysnb pipe() (p1 int, p2 int, err error)

        public static error Pipe(slice<long> p)
        {
            error err = default!;

            if (len(p) != 2L)
            {
                return error.As(EINVAL)!;
            }

            p[0L], p[1L], err = pipe();
            return ;

        }

        //sys    mmap2(addr uintptr, length uintptr, prot int, flags int, fd int, pageOffset uintptr) (xaddr uintptr, err error)

        private static (System.UIntPtr, error) mmap(System.UIntPtr addr, System.UIntPtr length, long prot, long flags, long fd, long offset)
        {
            System.UIntPtr xaddr = default;
            error err = default!;

            var page = uintptr(offset / 4096L);
            if (offset != int64(page) * 4096L)
            {
                return (0L, error.As(EINVAL)!);
            }

            return mmap2(addr, length, prot, flags, fd, page);

        }

        private static readonly var rlimInf32 = (var)~uint32(0L);

        private static readonly var rlimInf64 = (var)~uint64(0L);



        private partial struct rlimit32
        {
            public uint Cur;
            public uint Max;
        }

        //sysnb getrlimit(resource int, rlim *rlimit32) (err error) = SYS_GETRLIMIT

        public static error Getrlimit(long resource, ptr<Rlimit> _addr_rlim)
        {
            error err = default!;
            ref Rlimit rlim = ref _addr_rlim.val;

            err = prlimit(0L, resource, null, rlim);
            if (err != ENOSYS)
            {
                return error.As(err)!;
            }

            ref rlimit32 rl = ref heap(new rlimit32(), out ptr<rlimit32> _addr_rl);
            err = getrlimit(resource, _addr_rl);
            if (err != null)
            {
                return ;
            }

            if (rl.Cur == rlimInf32)
            {
                rlim.Cur = rlimInf64;
            }
            else
            {
                rlim.Cur = uint64(rl.Cur);
            }

            if (rl.Max == rlimInf32)
            {
                rlim.Max = rlimInf64;
            }
            else
            {
                rlim.Max = uint64(rl.Max);
            }

            return ;

        }

        //sysnb setrlimit(resource int, rlim *rlimit32) (err error) = SYS_SETRLIMIT

        public static error Setrlimit(long resource, ptr<Rlimit> _addr_rlim)
        {
            error err = default!;
            ref Rlimit rlim = ref _addr_rlim.val;

            err = prlimit(0L, resource, rlim, null);
            if (err != ENOSYS)
            {
                return error.As(err)!;
            }

            ref rlimit32 rl = ref heap(new rlimit32(), out ptr<rlimit32> _addr_rl);
            if (rlim.Cur == rlimInf64)
            {
                rl.Cur = rlimInf32;
            }
            else if (rlim.Cur < uint64(rlimInf32))
            {
                rl.Cur = uint32(rlim.Cur);
            }
            else
            {
                return error.As(EINVAL)!;
            }

            if (rlim.Max == rlimInf64)
            {
                rl.Max = rlimInf32;
            }
            else if (rlim.Max < uint64(rlimInf32))
            {
                rl.Max = uint32(rlim.Max);
            }
            else
            {
                return error.As(EINVAL)!;
            }

            return error.As(setrlimit(resource, _addr_rl))!;

        }

        private static ulong PC(this ptr<PtraceRegs> _addr_r)
        {
            ref PtraceRegs r = ref _addr_r.val;

            return uint64(r.Regs[64L]);
        }

        private static void SetPC(this ptr<PtraceRegs> _addr_r, ulong pc)
        {
            ref PtraceRegs r = ref _addr_r.val;

            r.Regs[64L] = uint32(pc);
        }

        private static void SetLen(this ptr<Iovec> _addr_iov, long length)
        {
            ref Iovec iov = ref _addr_iov.val;

            iov.Len = uint32(length);
        }

        private static void SetControllen(this ptr<Msghdr> _addr_msghdr, long length)
        {
            ref Msghdr msghdr = ref _addr_msghdr.val;

            msghdr.Controllen = uint32(length);
        }

        private static void SetLen(this ptr<Cmsghdr> _addr_cmsg, long length)
        {
            ref Cmsghdr cmsg = ref _addr_cmsg.val;

            cmsg.Len = uint32(length);
        }

        private static (System.UIntPtr, Errno) rawVforkSyscall(System.UIntPtr trap, System.UIntPtr a1) => func((_, panic, __) =>
        {
            System.UIntPtr r1 = default;
            Errno err = default;

            panic("not implemented");
        });
    }
}
