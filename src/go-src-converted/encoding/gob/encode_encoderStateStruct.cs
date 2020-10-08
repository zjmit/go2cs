//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:42:40 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using encoding = go.encoding_package;
using binary = go.encoding.binary_package;
using math = go.math_package;
using bits = go.math.bits_package;
using reflect = go.reflect_package;
using sync = go.sync_package;
using go;

namespace go {
namespace encoding
{
    public static partial class gob_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct encoderState
        {
            // Constructors
            public encoderState(NilType _)
            {
                this.enc = default;
                this.b = default;
                this.sendZero = default;
                this.fieldnum = default;
                this.buf = default;
                this.next = default;
            }

            public encoderState(ref ptr<Encoder> enc = default, ref ptr<encBuffer> b = default, bool sendZero = default, long fieldnum = default, array<byte> buf = default, ref ptr<encoderState> next = default)
            {
                this.enc = enc;
                this.b = b;
                this.sendZero = sendZero;
                this.fieldnum = fieldnum;
                this.buf = buf;
                this.next = next;
            }

            // Enable comparisons between nil and encoderState struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(encoderState value, NilType nil) => value.Equals(default(encoderState));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(encoderState value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, encoderState value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, encoderState value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator encoderState(NilType nil) => default(encoderState);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static encoderState encoderState_cast(dynamic value)
        {
            return new encoderState(ref value.enc, ref value.b, value.sendZero, value.fieldnum, value.buf, ref value.next);
        }
    }
}}