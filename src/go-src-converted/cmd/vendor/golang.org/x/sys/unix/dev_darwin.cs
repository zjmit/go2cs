// Copyright 2017 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// Functions to access/create device major and minor numbers matching the
// encoding used in Darwin's sys/types.h header.

// package unix -- go2cs converted at 2020 October 08 04:46:13 UTC
// import "cmd/vendor/golang.org/x/sys/unix" ==> using unix = go.cmd.vendor.golang.org.x.sys.unix_package
// Original source: C:\Go\src\cmd\vendor\golang.org\x\sys\unix\dev_darwin.go

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
        // Major returns the major component of a Darwin device number.
        public static uint Major(ulong dev)
        {
            return uint32((dev >> (int)(24L)) & 0xffUL);
        }

        // Minor returns the minor component of a Darwin device number.
        public static uint Minor(ulong dev)
        {
            return uint32(dev & 0xffffffUL);
        }

        // Mkdev returns a Darwin device number generated from the given major and minor
        // components.
        public static ulong Mkdev(uint major, uint minor)
        {
            return (uint64(major) << (int)(24L)) | uint64(minor);
        }
    }
}}}}}}
