// Copyright 2016 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.
//
// +build 386 amd64 arm arm64 ppc64le mips64le mipsle riscv64 wasm

// package syscall -- go2cs converted at 2020 October 08 03:26:21 UTC
// import "syscall" ==> using syscall = go.syscall_package
// Original source: C:\Go\src\syscall\endian_little.go

using static go.builtin;

namespace go
{
    public static partial class syscall_package
    {
        private static readonly var isBigEndian = (var)false;

    }
}
