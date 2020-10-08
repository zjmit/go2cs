// go run mksyscall.go -tags linux,ppc64le syscall_linux.go syscall_linux_ppc64x.go
// Code generated by the command above; see README.md. DO NOT EDIT.

// +build linux,ppc64le

// package unix -- go2cs converted at 2020 October 08 04:52:11 UTC
// import "cmd/vendor/golang.org/x/sys/unix" ==> using unix = go.cmd.vendor.golang.org.x.sys.unix_package
// Original source: C:\Go\src\cmd\vendor\golang.org\x\sys\unix\zsyscall_linux_ppc64le.go
using syscall = go.syscall_package;
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
        private static syscall.Errno _ = default;

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        private static error fanotifyMark(long fd, ulong flags, ulong mask, long dirFd, ptr<byte> _addr_pathname)
        {
            error err = default!;
            ref byte pathname = ref _addr_pathname.val;

            var (_, _, e1) = Syscall6(SYS_FANOTIFY_MARK, uintptr(fd), uintptr(flags), uintptr(mask), uintptr(dirFd), uintptr(@unsafe.Pointer(pathname)), 0L);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        public static error Fallocate(long fd, uint mode, long off, long len)
        {
            error err = default!;

            var (_, _, e1) = Syscall6(SYS_FALLOCATE, uintptr(fd), uintptr(mode), uintptr(off), uintptr(len), 0L, 0L);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        public static (long, error) Tee(long rfd, long wfd, long len, long flags)
        {
            long n = default;
            error err = default!;

            var (r0, _, e1) = Syscall6(SYS_TEE, uintptr(rfd), uintptr(wfd), uintptr(len), uintptr(flags), 0L, 0L);
            n = int64(r0);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        private static error dup2(long oldfd, long newfd)
        {
            error err = default!;

            var (_, _, e1) = Syscall(SYS_DUP2, uintptr(oldfd), uintptr(newfd), 0L);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        public static (long, error) EpollCreate(long size)
        {
            long fd = default;
            error err = default!;

            var (r0, _, e1) = RawSyscall(SYS_EPOLL_CREATE, uintptr(size), 0L, 0L);
            fd = int(r0);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        public static (long, error) EpollWait(long epfd, slice<EpollEvent> events, long msec)
        {
            long n = default;
            error err = default!;

            unsafe.Pointer _p0 = default;
            if (len(events) > 0L)
            {
                _p0 = @unsafe.Pointer(_addr_events[0L]);
            }
            else
            {
                _p0 = @unsafe.Pointer(_addr__zero);
            }

            var (r0, _, e1) = Syscall6(SYS_EPOLL_WAIT, uintptr(epfd), uintptr(_p0), uintptr(len(events)), uintptr(msec), 0L, 0L);
            n = int(r0);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        public static error Fadvise(long fd, long offset, long length, long advice)
        {
            error err = default!;

            var (_, _, e1) = Syscall6(SYS_FADVISE64, uintptr(fd), uintptr(offset), uintptr(length), uintptr(advice), 0L, 0L);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        public static error Fchown(long fd, long uid, long gid)
        {
            error err = default!;

            var (_, _, e1) = Syscall(SYS_FCHOWN, uintptr(fd), uintptr(uid), uintptr(gid));
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        public static error Fstat(long fd, ptr<Stat_t> _addr_stat)
        {
            error err = default!;
            ref Stat_t stat = ref _addr_stat.val;

            var (_, _, e1) = Syscall(SYS_FSTAT, uintptr(fd), uintptr(@unsafe.Pointer(stat)), 0L);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        public static error Fstatat(long dirfd, @string path, ptr<Stat_t> _addr_stat, long flags)
        {
            error err = default!;
            ref Stat_t stat = ref _addr_stat.val;

            ptr<byte> _p0;
            _p0, err = BytePtrFromString(path);
            if (err != null)
            {
                return ;
            }

            var (_, _, e1) = Syscall6(SYS_NEWFSTATAT, uintptr(dirfd), uintptr(@unsafe.Pointer(_p0)), uintptr(@unsafe.Pointer(stat)), uintptr(flags), 0L, 0L);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        public static error Fstatfs(long fd, ptr<Statfs_t> _addr_buf)
        {
            error err = default!;
            ref Statfs_t buf = ref _addr_buf.val;

            var (_, _, e1) = Syscall(SYS_FSTATFS, uintptr(fd), uintptr(@unsafe.Pointer(buf)), 0L);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        public static error Ftruncate(long fd, long length)
        {
            error err = default!;

            var (_, _, e1) = Syscall(SYS_FTRUNCATE, uintptr(fd), uintptr(length), 0L);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        public static long Getegid()
        {
            long egid = default;

            var (r0, _) = RawSyscallNoError(SYS_GETEGID, 0L, 0L, 0L);
            egid = int(r0);
            return ;
        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        public static long Geteuid()
        {
            long euid = default;

            var (r0, _) = RawSyscallNoError(SYS_GETEUID, 0L, 0L, 0L);
            euid = int(r0);
            return ;
        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        public static long Getgid()
        {
            long gid = default;

            var (r0, _) = RawSyscallNoError(SYS_GETGID, 0L, 0L, 0L);
            gid = int(r0);
            return ;
        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        public static error Getrlimit(long resource, ptr<Rlimit> _addr_rlim)
        {
            error err = default!;
            ref Rlimit rlim = ref _addr_rlim.val;

            var (_, _, e1) = RawSyscall(SYS_UGETRLIMIT, uintptr(resource), uintptr(@unsafe.Pointer(rlim)), 0L);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        public static long Getuid()
        {
            long uid = default;

            var (r0, _) = RawSyscallNoError(SYS_GETUID, 0L, 0L, 0L);
            uid = int(r0);
            return ;
        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        public static (long, error) InotifyInit()
        {
            long fd = default;
            error err = default!;

            var (r0, _, e1) = RawSyscall(SYS_INOTIFY_INIT, 0L, 0L, 0L);
            fd = int(r0);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        public static error Ioperm(long from, long num, long on)
        {
            error err = default!;

            var (_, _, e1) = Syscall(SYS_IOPERM, uintptr(from), uintptr(num), uintptr(on));
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        public static error Iopl(long level)
        {
            error err = default!;

            var (_, _, e1) = Syscall(SYS_IOPL, uintptr(level), 0L, 0L);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        public static error Lchown(@string path, long uid, long gid)
        {
            error err = default!;

            ptr<byte> _p0;
            _p0, err = BytePtrFromString(path);
            if (err != null)
            {
                return ;
            }

            var (_, _, e1) = Syscall(SYS_LCHOWN, uintptr(@unsafe.Pointer(_p0)), uintptr(uid), uintptr(gid));
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        public static error Listen(long s, long n)
        {
            error err = default!;

            var (_, _, e1) = Syscall(SYS_LISTEN, uintptr(s), uintptr(n), 0L);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        public static error Lstat(@string path, ptr<Stat_t> _addr_stat)
        {
            error err = default!;
            ref Stat_t stat = ref _addr_stat.val;

            ptr<byte> _p0;
            _p0, err = BytePtrFromString(path);
            if (err != null)
            {
                return ;
            }

            var (_, _, e1) = Syscall(SYS_LSTAT, uintptr(@unsafe.Pointer(_p0)), uintptr(@unsafe.Pointer(stat)), 0L);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        public static error Pause()
        {
            error err = default!;

            var (_, _, e1) = Syscall(SYS_PAUSE, 0L, 0L, 0L);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        public static (long, error) Pread(long fd, slice<byte> p, long offset)
        {
            long n = default;
            error err = default!;

            unsafe.Pointer _p0 = default;
            if (len(p) > 0L)
            {
                _p0 = @unsafe.Pointer(_addr_p[0L]);
            }
            else
            {
                _p0 = @unsafe.Pointer(_addr__zero);
            }

            var (r0, _, e1) = Syscall6(SYS_PREAD64, uintptr(fd), uintptr(_p0), uintptr(len(p)), uintptr(offset), 0L, 0L);
            n = int(r0);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        public static (long, error) Pwrite(long fd, slice<byte> p, long offset)
        {
            long n = default;
            error err = default!;

            unsafe.Pointer _p0 = default;
            if (len(p) > 0L)
            {
                _p0 = @unsafe.Pointer(_addr_p[0L]);
            }
            else
            {
                _p0 = @unsafe.Pointer(_addr__zero);
            }

            var (r0, _, e1) = Syscall6(SYS_PWRITE64, uintptr(fd), uintptr(_p0), uintptr(len(p)), uintptr(offset), 0L, 0L);
            n = int(r0);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        public static error Renameat(long olddirfd, @string oldpath, long newdirfd, @string newpath)
        {
            error err = default!;

            ptr<byte> _p0;
            _p0, err = BytePtrFromString(oldpath);
            if (err != null)
            {
                return ;
            }

            ptr<byte> _p1;
            _p1, err = BytePtrFromString(newpath);
            if (err != null)
            {
                return ;
            }

            var (_, _, e1) = Syscall6(SYS_RENAMEAT, uintptr(olddirfd), uintptr(@unsafe.Pointer(_p0)), uintptr(newdirfd), uintptr(@unsafe.Pointer(_p1)), 0L, 0L);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        public static (long, error) Seek(long fd, long offset, long whence)
        {
            long off = default;
            error err = default!;

            var (r0, _, e1) = Syscall(SYS_LSEEK, uintptr(fd), uintptr(offset), uintptr(whence));
            off = int64(r0);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        public static (long, error) Select(long nfd, ptr<FdSet> _addr_r, ptr<FdSet> _addr_w, ptr<FdSet> _addr_e, ptr<Timeval> _addr_timeout)
        {
            long n = default;
            error err = default!;
            ref FdSet r = ref _addr_r.val;
            ref FdSet w = ref _addr_w.val;
            ref FdSet e = ref _addr_e.val;
            ref Timeval timeout = ref _addr_timeout.val;

            var (r0, _, e1) = Syscall6(SYS__NEWSELECT, uintptr(nfd), uintptr(@unsafe.Pointer(r)), uintptr(@unsafe.Pointer(w)), uintptr(@unsafe.Pointer(e)), uintptr(@unsafe.Pointer(timeout)), 0L);
            n = int(r0);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        private static (long, error) sendfile(long outfd, long infd, ptr<long> _addr_offset, long count)
        {
            long written = default;
            error err = default!;
            ref long offset = ref _addr_offset.val;

            var (r0, _, e1) = Syscall6(SYS_SENDFILE, uintptr(outfd), uintptr(infd), uintptr(@unsafe.Pointer(offset)), uintptr(count), 0L, 0L);
            written = int(r0);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        private static (long, error) setfsgid(long gid)
        {
            long prev = default;
            error err = default!;

            var (r0, _, e1) = Syscall(SYS_SETFSGID, uintptr(gid), 0L, 0L);
            prev = int(r0);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        private static (long, error) setfsuid(long uid)
        {
            long prev = default;
            error err = default!;

            var (r0, _, e1) = Syscall(SYS_SETFSUID, uintptr(uid), 0L, 0L);
            prev = int(r0);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        public static error Setregid(long rgid, long egid)
        {
            error err = default!;

            var (_, _, e1) = RawSyscall(SYS_SETREGID, uintptr(rgid), uintptr(egid), 0L);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        public static error Setresgid(long rgid, long egid, long sgid)
        {
            error err = default!;

            var (_, _, e1) = RawSyscall(SYS_SETRESGID, uintptr(rgid), uintptr(egid), uintptr(sgid));
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        public static error Setresuid(long ruid, long euid, long suid)
        {
            error err = default!;

            var (_, _, e1) = RawSyscall(SYS_SETRESUID, uintptr(ruid), uintptr(euid), uintptr(suid));
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        public static error Setrlimit(long resource, ptr<Rlimit> _addr_rlim)
        {
            error err = default!;
            ref Rlimit rlim = ref _addr_rlim.val;

            var (_, _, e1) = RawSyscall(SYS_SETRLIMIT, uintptr(resource), uintptr(@unsafe.Pointer(rlim)), 0L);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        public static error Setreuid(long ruid, long euid)
        {
            error err = default!;

            var (_, _, e1) = RawSyscall(SYS_SETREUID, uintptr(ruid), uintptr(euid), 0L);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        public static error Shutdown(long fd, long how)
        {
            error err = default!;

            var (_, _, e1) = Syscall(SYS_SHUTDOWN, uintptr(fd), uintptr(how), 0L);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        public static (long, error) Splice(long rfd, ptr<long> _addr_roff, long wfd, ptr<long> _addr_woff, long len, long flags)
        {
            long n = default;
            error err = default!;
            ref long roff = ref _addr_roff.val;
            ref long woff = ref _addr_woff.val;

            var (r0, _, e1) = Syscall6(SYS_SPLICE, uintptr(rfd), uintptr(@unsafe.Pointer(roff)), uintptr(wfd), uintptr(@unsafe.Pointer(woff)), uintptr(len), uintptr(flags));
            n = int64(r0);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        public static error Stat(@string path, ptr<Stat_t> _addr_stat)
        {
            error err = default!;
            ref Stat_t stat = ref _addr_stat.val;

            ptr<byte> _p0;
            _p0, err = BytePtrFromString(path);
            if (err != null)
            {
                return ;
            }

            var (_, _, e1) = Syscall(SYS_STAT, uintptr(@unsafe.Pointer(_p0)), uintptr(@unsafe.Pointer(stat)), 0L);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        public static error Statfs(@string path, ptr<Statfs_t> _addr_buf)
        {
            error err = default!;
            ref Statfs_t buf = ref _addr_buf.val;

            ptr<byte> _p0;
            _p0, err = BytePtrFromString(path);
            if (err != null)
            {
                return ;
            }

            var (_, _, e1) = Syscall(SYS_STATFS, uintptr(@unsafe.Pointer(_p0)), uintptr(@unsafe.Pointer(buf)), 0L);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        public static error Truncate(@string path, long length)
        {
            error err = default!;

            ptr<byte> _p0;
            _p0, err = BytePtrFromString(path);
            if (err != null)
            {
                return ;
            }

            var (_, _, e1) = Syscall(SYS_TRUNCATE, uintptr(@unsafe.Pointer(_p0)), uintptr(length), 0L);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        public static error Ustat(long dev, ptr<Ustat_t> _addr_ubuf)
        {
            error err = default!;
            ref Ustat_t ubuf = ref _addr_ubuf.val;

            var (_, _, e1) = Syscall(SYS_USTAT, uintptr(dev), uintptr(@unsafe.Pointer(ubuf)), 0L);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        private static (long, error) accept(long s, ptr<RawSockaddrAny> _addr_rsa, ptr<_Socklen> _addr_addrlen)
        {
            long fd = default;
            error err = default!;
            ref RawSockaddrAny rsa = ref _addr_rsa.val;
            ref _Socklen addrlen = ref _addr_addrlen.val;

            var (r0, _, e1) = Syscall(SYS_ACCEPT, uintptr(s), uintptr(@unsafe.Pointer(rsa)), uintptr(@unsafe.Pointer(addrlen)));
            fd = int(r0);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        private static (long, error) accept4(long s, ptr<RawSockaddrAny> _addr_rsa, ptr<_Socklen> _addr_addrlen, long flags)
        {
            long fd = default;
            error err = default!;
            ref RawSockaddrAny rsa = ref _addr_rsa.val;
            ref _Socklen addrlen = ref _addr_addrlen.val;

            var (r0, _, e1) = Syscall6(SYS_ACCEPT4, uintptr(s), uintptr(@unsafe.Pointer(rsa)), uintptr(@unsafe.Pointer(addrlen)), uintptr(flags), 0L, 0L);
            fd = int(r0);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        private static error bind(long s, unsafe.Pointer addr, _Socklen addrlen)
        {
            error err = default!;

            var (_, _, e1) = Syscall(SYS_BIND, uintptr(s), uintptr(addr), uintptr(addrlen));
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        private static error connect(long s, unsafe.Pointer addr, _Socklen addrlen)
        {
            error err = default!;

            var (_, _, e1) = Syscall(SYS_CONNECT, uintptr(s), uintptr(addr), uintptr(addrlen));
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        private static (long, error) getgroups(long n, ptr<_Gid_t> _addr_list)
        {
            long nn = default;
            error err = default!;
            ref _Gid_t list = ref _addr_list.val;

            var (r0, _, e1) = RawSyscall(SYS_GETGROUPS, uintptr(n), uintptr(@unsafe.Pointer(list)), 0L);
            nn = int(r0);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        private static error setgroups(long n, ptr<_Gid_t> _addr_list)
        {
            error err = default!;
            ref _Gid_t list = ref _addr_list.val;

            var (_, _, e1) = RawSyscall(SYS_SETGROUPS, uintptr(n), uintptr(@unsafe.Pointer(list)), 0L);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        private static error getsockopt(long s, long level, long name, unsafe.Pointer val, ptr<_Socklen> _addr_vallen)
        {
            error err = default!;
            ref _Socklen vallen = ref _addr_vallen.val;

            var (_, _, e1) = Syscall6(SYS_GETSOCKOPT, uintptr(s), uintptr(level), uintptr(name), uintptr(val), uintptr(@unsafe.Pointer(vallen)), 0L);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        private static error setsockopt(long s, long level, long name, unsafe.Pointer val, System.UIntPtr vallen)
        {
            error err = default!;

            var (_, _, e1) = Syscall6(SYS_SETSOCKOPT, uintptr(s), uintptr(level), uintptr(name), uintptr(val), uintptr(vallen), 0L);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        private static (long, error) socket(long domain, long typ, long proto)
        {
            long fd = default;
            error err = default!;

            var (r0, _, e1) = RawSyscall(SYS_SOCKET, uintptr(domain), uintptr(typ), uintptr(proto));
            fd = int(r0);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        private static error socketpair(long domain, long typ, long proto, ptr<array<int>> _addr_fd)
        {
            error err = default!;
            ref array<int> fd = ref _addr_fd.val;

            var (_, _, e1) = RawSyscall6(SYS_SOCKETPAIR, uintptr(domain), uintptr(typ), uintptr(proto), uintptr(@unsafe.Pointer(fd)), 0L, 0L);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        private static error getpeername(long fd, ptr<RawSockaddrAny> _addr_rsa, ptr<_Socklen> _addr_addrlen)
        {
            error err = default!;
            ref RawSockaddrAny rsa = ref _addr_rsa.val;
            ref _Socklen addrlen = ref _addr_addrlen.val;

            var (_, _, e1) = RawSyscall(SYS_GETPEERNAME, uintptr(fd), uintptr(@unsafe.Pointer(rsa)), uintptr(@unsafe.Pointer(addrlen)));
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        private static error getsockname(long fd, ptr<RawSockaddrAny> _addr_rsa, ptr<_Socklen> _addr_addrlen)
        {
            error err = default!;
            ref RawSockaddrAny rsa = ref _addr_rsa.val;
            ref _Socklen addrlen = ref _addr_addrlen.val;

            var (_, _, e1) = RawSyscall(SYS_GETSOCKNAME, uintptr(fd), uintptr(@unsafe.Pointer(rsa)), uintptr(@unsafe.Pointer(addrlen)));
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        private static (long, error) recvfrom(long fd, slice<byte> p, long flags, ptr<RawSockaddrAny> _addr_from, ptr<_Socklen> _addr_fromlen)
        {
            long n = default;
            error err = default!;
            ref RawSockaddrAny from = ref _addr_from.val;
            ref _Socklen fromlen = ref _addr_fromlen.val;

            unsafe.Pointer _p0 = default;
            if (len(p) > 0L)
            {
                _p0 = @unsafe.Pointer(_addr_p[0L]);
            }
            else
            {
                _p0 = @unsafe.Pointer(_addr__zero);
            }

            var (r0, _, e1) = Syscall6(SYS_RECVFROM, uintptr(fd), uintptr(_p0), uintptr(len(p)), uintptr(flags), uintptr(@unsafe.Pointer(from)), uintptr(@unsafe.Pointer(fromlen)));
            n = int(r0);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        private static error sendto(long s, slice<byte> buf, long flags, unsafe.Pointer to, _Socklen addrlen)
        {
            error err = default!;

            unsafe.Pointer _p0 = default;
            if (len(buf) > 0L)
            {
                _p0 = @unsafe.Pointer(_addr_buf[0L]);
            }
            else
            {
                _p0 = @unsafe.Pointer(_addr__zero);
            }

            var (_, _, e1) = Syscall6(SYS_SENDTO, uintptr(s), uintptr(_p0), uintptr(len(buf)), uintptr(flags), uintptr(to), uintptr(addrlen));
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        private static (long, error) recvmsg(long s, ptr<Msghdr> _addr_msg, long flags)
        {
            long n = default;
            error err = default!;
            ref Msghdr msg = ref _addr_msg.val;

            var (r0, _, e1) = Syscall(SYS_RECVMSG, uintptr(s), uintptr(@unsafe.Pointer(msg)), uintptr(flags));
            n = int(r0);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        private static (long, error) sendmsg(long s, ptr<Msghdr> _addr_msg, long flags)
        {
            long n = default;
            error err = default!;
            ref Msghdr msg = ref _addr_msg.val;

            var (r0, _, e1) = Syscall(SYS_SENDMSG, uintptr(s), uintptr(@unsafe.Pointer(msg)), uintptr(flags));
            n = int(r0);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        private static (System.UIntPtr, error) mmap(System.UIntPtr addr, System.UIntPtr length, long prot, long flags, long fd, long offset)
        {
            System.UIntPtr xaddr = default;
            error err = default!;

            var (r0, _, e1) = Syscall6(SYS_MMAP, uintptr(addr), uintptr(length), uintptr(prot), uintptr(flags), uintptr(fd), uintptr(offset));
            xaddr = uintptr(r0);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        private static error futimesat(long dirfd, @string path, ptr<array<Timeval>> _addr_times)
        {
            error err = default!;
            ref array<Timeval> times = ref _addr_times.val;

            ptr<byte> _p0;
            _p0, err = BytePtrFromString(path);
            if (err != null)
            {
                return ;
            }

            var (_, _, e1) = Syscall(SYS_FUTIMESAT, uintptr(dirfd), uintptr(@unsafe.Pointer(_p0)), uintptr(@unsafe.Pointer(times)));
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        public static error Gettimeofday(ptr<Timeval> _addr_tv)
        {
            error err = default!;
            ref Timeval tv = ref _addr_tv.val;

            var (_, _, e1) = RawSyscall(SYS_GETTIMEOFDAY, uintptr(@unsafe.Pointer(tv)), 0L, 0L);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        public static (Time_t, error) Time(ptr<Time_t> _addr_t)
        {
            Time_t tt = default;
            error err = default!;
            ref Time_t t = ref _addr_t.val;

            var (r0, _, e1) = RawSyscall(SYS_TIME, uintptr(@unsafe.Pointer(t)), 0L, 0L);
            tt = Time_t(r0);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        public static error Utime(@string path, ptr<Utimbuf> _addr_buf)
        {
            error err = default!;
            ref Utimbuf buf = ref _addr_buf.val;

            ptr<byte> _p0;
            _p0, err = BytePtrFromString(path);
            if (err != null)
            {
                return ;
            }

            var (_, _, e1) = Syscall(SYS_UTIME, uintptr(@unsafe.Pointer(_p0)), uintptr(@unsafe.Pointer(buf)), 0L);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        private static error utimes(@string path, ptr<array<Timeval>> _addr_times)
        {
            error err = default!;
            ref array<Timeval> times = ref _addr_times.val;

            ptr<byte> _p0;
            _p0, err = BytePtrFromString(path);
            if (err != null)
            {
                return ;
            }

            var (_, _, e1) = Syscall(SYS_UTIMES, uintptr(@unsafe.Pointer(_p0)), uintptr(@unsafe.Pointer(times)), 0L);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        private static error pipe(ptr<array<_C_int>> _addr_p)
        {
            error err = default!;
            ref array<_C_int> p = ref _addr_p.val;

            var (_, _, e1) = RawSyscall(SYS_PIPE, uintptr(@unsafe.Pointer(p)), 0L, 0L);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        private static (long, error) poll(ptr<PollFd> _addr_fds, long nfds, long timeout)
        {
            long n = default;
            error err = default!;
            ref PollFd fds = ref _addr_fds.val;

            var (r0, _, e1) = Syscall(SYS_POLL, uintptr(@unsafe.Pointer(fds)), uintptr(nfds), uintptr(timeout));
            n = int(r0);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        private static error syncFileRange2(long fd, long flags, long off, long n)
        {
            error err = default!;

            var (_, _, e1) = Syscall6(SYS_SYNC_FILE_RANGE2, uintptr(fd), uintptr(flags), uintptr(off), uintptr(n), 0L, 0L);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        private static error kexecFileLoad(long kernelFd, long initrdFd, long cmdlineLen, @string cmdline, long flags)
        {
            error err = default!;

            ptr<byte> _p0;
            _p0, err = BytePtrFromString(cmdline);
            if (err != null)
            {
                return ;
            }

            var (_, _, e1) = Syscall6(SYS_KEXEC_FILE_LOAD, uintptr(kernelFd), uintptr(initrdFd), uintptr(cmdlineLen), uintptr(@unsafe.Pointer(_p0)), uintptr(flags), 0L);
            if (e1 != 0L)
            {
                err = errnoErr(e1);
            }

            return ;

        }
    }
}}}}}}
