// go run mksyscall_solaris.go -illumos -tags illumos,amd64 syscall_illumos.go
// Code generated by the command above; see README.md. DO NOT EDIT.

// +build illumos,amd64

// package unix -- go2cs converted at 2020 October 08 04:51:27 UTC
// import "cmd/vendor/golang.org/x/sys/unix" ==> using unix = go.cmd.vendor.golang.org.x.sys.unix_package
// Original source: C:\Go\src\cmd\vendor\golang.org\x\sys\unix\zsyscall_illumos_amd64.go
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
        //go:cgo_import_dynamic libc_readv readv "libc.so"
        //go:cgo_import_dynamic libc_preadv preadv "libc.so"
        //go:cgo_import_dynamic libc_writev writev "libc.so"
        //go:cgo_import_dynamic libc_pwritev pwritev "libc.so"

        //go:linkname procreadv libc_readv
        //go:linkname procpreadv libc_preadv
        //go:linkname procwritev libc_writev
        //go:linkname procpwritev libc_pwritev
        private static syscallFunc procreadv = default;        private static syscallFunc procpreadv = default;        private static syscallFunc procwritev = default;        private static syscallFunc procpwritev = default;


        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        private static (long, error) readv(long fd, slice<Iovec> iovs)
        {
            long n = default;
            error err = default!;

            ptr<Iovec> _p0;
            if (len(iovs) > 0L)
            {
                _p0 = _addr_iovs[0L];
            }

            var (r0, _, e1) = sysvicall6(uintptr(@unsafe.Pointer(_addr_procreadv)), 3L, uintptr(fd), uintptr(@unsafe.Pointer(_p0)), uintptr(len(iovs)), 0L, 0L, 0L);
            n = int(r0);
            if (e1 != 0L)
            {
                err = e1;
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        private static (long, error) preadv(long fd, slice<Iovec> iovs, long off)
        {
            long n = default;
            error err = default!;

            ptr<Iovec> _p0;
            if (len(iovs) > 0L)
            {
                _p0 = _addr_iovs[0L];
            }

            var (r0, _, e1) = sysvicall6(uintptr(@unsafe.Pointer(_addr_procpreadv)), 4L, uintptr(fd), uintptr(@unsafe.Pointer(_p0)), uintptr(len(iovs)), uintptr(off), 0L, 0L);
            n = int(r0);
            if (e1 != 0L)
            {
                err = e1;
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        private static (long, error) writev(long fd, slice<Iovec> iovs)
        {
            long n = default;
            error err = default!;

            ptr<Iovec> _p0;
            if (len(iovs) > 0L)
            {
                _p0 = _addr_iovs[0L];
            }

            var (r0, _, e1) = sysvicall6(uintptr(@unsafe.Pointer(_addr_procwritev)), 3L, uintptr(fd), uintptr(@unsafe.Pointer(_p0)), uintptr(len(iovs)), 0L, 0L, 0L);
            n = int(r0);
            if (e1 != 0L)
            {
                err = e1;
            }

            return ;

        }

        // THIS FILE IS GENERATED BY THE COMMAND AT THE TOP; DO NOT EDIT

        private static (long, error) pwritev(long fd, slice<Iovec> iovs, long off)
        {
            long n = default;
            error err = default!;

            ptr<Iovec> _p0;
            if (len(iovs) > 0L)
            {
                _p0 = _addr_iovs[0L];
            }

            var (r0, _, e1) = sysvicall6(uintptr(@unsafe.Pointer(_addr_procpwritev)), 4L, uintptr(fd), uintptr(@unsafe.Pointer(_p0)), uintptr(len(iovs)), uintptr(off), 0L, 0L);
            n = int(r0);
            if (e1 != 0L)
            {
                err = e1;
            }

            return ;

        }
    }
}}}}}}
