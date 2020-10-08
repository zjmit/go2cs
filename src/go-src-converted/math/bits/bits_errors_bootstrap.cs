// Copyright 2019 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// +build compiler_bootstrap

// This version used only for bootstrap (on this path we want
// to avoid use of go:linkname as applied to variables).

// package bits -- go2cs converted at 2020 October 08 03:25:15 UTC
// import "math/bits" ==> using bits = go.math.bits_package
// Original source: C:\Go\src\math\bits\bits_errors_bootstrap.go

using static go.builtin;

namespace go {
namespace math
{
    public static partial class bits_package
    {
        private partial struct errorString // : @string
        {
        }

        private static void RuntimeError(this errorString e)
        {
        }

        private static @string Error(this errorString e)
        {
            return "runtime error: " + string(e);
        }

        private static var overflowError = error(errorString("integer overflow"));

        private static var divideError = error(errorString("integer divide by zero"));
    }
}}
