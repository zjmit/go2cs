// Copyright 2020 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// +build goexperiment.staticlockranking

// package sync -- go2cs converted at 2020 October 08 03:18:57 UTC
// import "sync" ==> using sync = go.sync_package
// Original source: C:\Go\src\sync\runtime2_lockrank.go
using @unsafe = go.@unsafe_package;
using static go.builtin;

namespace go
{
    public static partial class sync_package
    {
        // Approximation of notifyList in runtime/sema.go. Size and alignment must
        // agree.
        private partial struct notifyList
        {
            public uint wait;
            public uint notify;
            public long rank; // rank field of the mutex
            public long pad; // pad field of the mutex
            public System.UIntPtr @lock; // key field of the mutex

            public unsafe.Pointer head;
            public unsafe.Pointer tail;
        }
    }
}
