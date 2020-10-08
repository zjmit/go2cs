//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 05:00:16 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using binary = go.encoding.binary_package;
using go;

namespace go {
namespace vendor {
namespace golang.org {
namespace x {
namespace crypto
{
    public static partial class poly1305_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct macState
        {
            // Constructors
            public macState(NilType _)
            {
                this.h = default;
                this.r = default;
                this.s = default;
            }

            public macState(array<ulong> h = default, array<ulong> r = default, array<ulong> s = default)
            {
                this.h = h;
                this.r = r;
                this.s = s;
            }

            // Enable comparisons between nil and macState struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(macState value, NilType nil) => value.Equals(default(macState));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(macState value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, macState value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, macState value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator macState(NilType nil) => default(macState);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static macState macState_cast(dynamic value)
        {
            return new macState(value.h, value.r, value.s);
        }
    }
}}}}}