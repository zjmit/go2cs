// Copyright 2019 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// +build gccgo

// package cpu -- go2cs converted at 2020 October 08 05:01:49 UTC
// import "vendor/golang.org/x/sys/cpu" ==> using cpu = go.vendor.golang.org.x.sys.cpu_package
// Original source: C:\Go\src\vendor\golang.org\x\sys\cpu\cpu_gccgo_arm64.go

using static go.builtin;

namespace go {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class cpu_package
    {
        private static ulong getisar0()
        {
            return 0L;
        }
        private static ulong getisar1()
        {
            return 0L;
        }
        private static ulong getpfr0()
        {
            return 0L;
        }
    }
}}}}}
