//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:38:09 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using strings = go.strings_package;
using cryptobyte = go.golang.org.x.crypto.cryptobyte_package;
using go;

namespace go {
namespace crypto
{
    public static partial class tls_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct finishedMsg
        {
            // Constructors
            public finishedMsg(NilType _)
            {
                this.raw = default;
                this.verifyData = default;
            }

            public finishedMsg(slice<byte> raw = default, slice<byte> verifyData = default)
            {
                this.raw = raw;
                this.verifyData = verifyData;
            }

            // Enable comparisons between nil and finishedMsg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(finishedMsg value, NilType nil) => value.Equals(default(finishedMsg));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(finishedMsg value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, finishedMsg value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, finishedMsg value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator finishedMsg(NilType nil) => default(finishedMsg);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static finishedMsg finishedMsg_cast(dynamic value)
        {
            return new finishedMsg(value.raw, value.verifyData);
        }
    }
}}