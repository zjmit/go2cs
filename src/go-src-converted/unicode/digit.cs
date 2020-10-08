// Copyright 2009 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package unicode -- go2cs converted at 2020 October 08 03:24:46 UTC
// import "unicode" ==> using unicode = go.unicode_package
// Original source: C:\Go\src\unicode\digit.go

using static go.builtin;

namespace go
{
    public static partial class unicode_package
    {
        // IsDigit reports whether the rune is a decimal digit.
        public static bool IsDigit(int r)
        {
            if (r <= MaxLatin1)
            {
                return '0' <= r && r <= '9';
            }
            return isExcludingLatin(Digit, r);

        }
    }
}
