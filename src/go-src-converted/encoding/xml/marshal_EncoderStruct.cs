//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:42:59 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using bytes = go.bytes_package;
using encoding = go.encoding_package;
using fmt = go.fmt_package;
using io = go.io_package;
using reflect = go.reflect_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using go;

namespace go {
namespace encoding
{
    public static partial class xml_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Encoder
        {
            // Constructors
            public Encoder(NilType _)
            {
                this.p = default;
            }

            public Encoder(printer p = default)
            {
                this.p = p;
            }

            // Enable comparisons between nil and Encoder struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Encoder value, NilType nil) => value.Equals(default(Encoder));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Encoder value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Encoder value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Encoder value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Encoder(NilType nil) => default(Encoder);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Encoder Encoder_cast(dynamic value)
        {
            return new Encoder(value.p);
        }
    }
}}