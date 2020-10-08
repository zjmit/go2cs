// Copyright 2018 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package cipher -- go2cs converted at 2020 October 08 03:35:45 UTC
// import "crypto/cipher" ==> using cipher = go.crypto.cipher_package
// Original source: C:\Go\src\crypto\cipher\xor_amd64.go

using static go.builtin;

namespace go {
namespace crypto
{
    public static partial class cipher_package
    {
        // xorBytes xors the bytes in a and b. The destination should have enough
        // space, otherwise xorBytes will panic. Returns the number of bytes xor'd.
        private static long xorBytes(slice<byte> dst, slice<byte> a, slice<byte> b)
        {
            var n = len(a);
            if (len(b) < n)
            {
                n = len(b);
            }
            if (n == 0L)
            {
                return 0L;
            }
            _ = dst[n - 1L];
            xorBytesSSE2(_addr_dst[0L], _addr_a[0L], _addr_b[0L], n); // amd64 must have SSE2
            return n;

        }

        private static void xorWords(slice<byte> dst, slice<byte> a, slice<byte> b)
        {
            xorBytes(dst, a, b);
        }

        //go:noescape
        private static void xorBytesSSE2(ptr<byte> dst, ptr<byte> a, ptr<byte> b, long n)
;
    }
}}
