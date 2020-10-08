//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:42:35 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using encoding = go.encoding_package;
using errors = go.errors_package;
using io = go.io_package;
using math = go.math_package;
using bits = go.math.bits_package;
using reflect = go.reflect_package;
using go;

namespace go {
namespace encoding
{
    public static partial class gob_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct decoderState
        {
            // Constructors
            public decoderState(NilType _)
            {
                this.dec = default;
                this.b = default;
                this.fieldnum = default;
                this.next = default;
            }

            public decoderState(ref ptr<Decoder> dec = default, ref ptr<decBuffer> b = default, long fieldnum = default, ref ptr<decoderState> next = default)
            {
                this.dec = dec;
                this.b = b;
                this.fieldnum = fieldnum;
                this.next = next;
            }

            // Enable comparisons between nil and decoderState struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(decoderState value, NilType nil) => value.Equals(default(decoderState));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(decoderState value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, decoderState value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, decoderState value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator decoderState(NilType nil) => default(decoderState);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static decoderState decoderState_cast(dynamic value)
        {
            return new decoderState(ref value.dec, ref value.b, value.fieldnum, ref value.next);
        }
    }
}}