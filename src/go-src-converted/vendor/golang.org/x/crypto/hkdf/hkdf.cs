// Copyright 2014 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// Package hkdf implements the HMAC-based Extract-and-Expand Key Derivation
// Function (HKDF) as defined in RFC 5869.
//
// HKDF is a cryptographic key derivation function (KDF) with the goal of
// expanding limited input keying material into one or more cryptographically
// strong secret keys.
// package hkdf -- go2cs converted at 2020 October 08 05:00:14 UTC
// import "vendor/golang.org/x/crypto/hkdf" ==> using hkdf = go.vendor.golang.org.x.crypto.hkdf_package
// Original source: C:\Go\src\vendor\golang.org\x\crypto\hkdf\hkdf.go
// import "golang.org/x/crypto/hkdf"

using hmac = go.crypto.hmac_package;
using errors = go.errors_package;
using hash = go.hash_package;
using io = go.io_package;
using static go.builtin;
using System;

namespace go {
namespace vendor {
namespace golang.org {
namespace x {
namespace crypto
{
    public static partial class hkdf_package
    {
        // Extract generates a pseudorandom key for use with Expand from an input secret
        // and an optional independent salt.
        //
        // Only use this function if you need to reuse the extracted key with multiple
        // Expand invocations and different context values. Most common scenarios,
        // including the generation of multiple keys, should use New instead.
        public static slice<byte> Extract(Func<hash.Hash> hash, slice<byte> secret, slice<byte> salt)
        {
            if (salt == null)
            {
                salt = make_slice<byte>(hash().Size());
            }
            var extractor = hmac.New(hash, salt);
            extractor.Write(secret);
            return extractor.Sum(null);

        }

        private partial struct hkdf
        {
            public hash.Hash expander;
            public long size;
            public slice<byte> info;
            public byte counter;
            public slice<byte> prev;
            public slice<byte> buf;
        }

        private static (long, error) Read(this ptr<hkdf> _addr_f, slice<byte> p)
        {
            long _p0 = default;
            error _p0 = default!;
            ref hkdf f = ref _addr_f.val;
 
            // Check whether enough data can be generated
            var need = len(p);
            var remains = len(f.buf) + int(255L - f.counter + 1L) * f.size;
            if (remains < need)
            {
                return (0L, error.As(errors.New("hkdf: entropy limit reached"))!);
            } 
            // Read any leftover from the buffer
            var n = copy(p, f.buf);
            p = p[n..]; 

            // Fill the rest of the buffer
            while (len(p) > 0L)
            {
                f.expander.Reset();
                f.expander.Write(f.prev);
                f.expander.Write(f.info);
                f.expander.Write(new slice<byte>(new byte[] { f.counter }));
                f.prev = f.expander.Sum(f.prev[..0L]);
                f.counter++; 

                // Copy the new batch into p
                f.buf = f.prev;
                n = copy(p, f.buf);
                p = p[n..];

            } 
            // Save leftovers for next run
 
            // Save leftovers for next run
            f.buf = f.buf[n..];

            return (need, error.As(null!)!);

        }

        // Expand returns a Reader, from which keys can be read, using the given
        // pseudorandom key and optional context info, skipping the extraction step.
        //
        // The pseudorandomKey should have been generated by Extract, or be a uniformly
        // random or pseudorandom cryptographically strong key. See RFC 5869, Section
        // 3.3. Most common scenarios will want to use New instead.
        public static io.Reader Expand(Func<hash.Hash> hash, slice<byte> pseudorandomKey, slice<byte> info)
        {
            var expander = hmac.New(hash, pseudorandomKey);
            return addr(new hkdf(expander,expander.Size(),info,1,nil,nil));
        }

        // New returns a Reader, from which keys can be read, using the given hash,
        // secret, salt and context info. Salt and info can be nil.
        public static io.Reader New(Func<hash.Hash> hash, slice<byte> secret, slice<byte> salt, slice<byte> info)
        {
            var prk = Extract(hash, secret, salt);
            return Expand(hash, prk, info);
        }
    }
}}}}}
