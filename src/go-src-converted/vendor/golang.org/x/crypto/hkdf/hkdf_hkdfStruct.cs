//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:06:32 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using hmac = go.crypto.hmac_package;
using errors = go.errors_package;
using hash = go.hash_package;
using io = go.io_package;
using go;

#nullable enable

namespace go {
namespace vendor {
namespace golang.org {
namespace x {
namespace crypto
{
    public static partial class hkdf_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct hkdf
        {
            // Constructors
            public hkdf(NilType _)
            {
                this.expander = default;
                this.size = default;
                this.info = default;
                this.counter = default;
                this.prev = default;
                this.buf = default;
            }

            public hkdf(hash.Hash expander = default, long size = default, slice<byte> info = default, byte counter = default, slice<byte> prev = default, slice<byte> buf = default)
            {
                this.expander = expander;
                this.size = size;
                this.info = info;
                this.counter = counter;
                this.prev = prev;
                this.buf = buf;
            }

            // Enable comparisons between nil and hkdf struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(hkdf value, NilType nil) => value.Equals(default(hkdf));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(hkdf value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, hkdf value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, hkdf value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator hkdf(NilType nil) => default(hkdf);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static hkdf hkdf_cast(dynamic value)
        {
            return new hkdf(value.expander, value.size, value.info, value.counter, value.prev, value.buf);
        }
    }
}}}}}