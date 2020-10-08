//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:42:55 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using errors = go.errors_package;
using io = go.io_package;
using go;

namespace go {
namespace encoding
{
    public static partial class json_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Encoder
        {
            // Constructors
            public Encoder(NilType _)
            {
                this.w = default;
                this.err = default;
                this.escapeHTML = default;
                this.indentBuf = default;
                this.indentPrefix = default;
                this.indentValue = default;
            }

            public Encoder(io.Writer w = default, error err = default, bool escapeHTML = default, ref ptr<bytes.Buffer> indentBuf = default, @string indentPrefix = default, @string indentValue = default)
            {
                this.w = w;
                this.err = err;
                this.escapeHTML = escapeHTML;
                this.indentBuf = indentBuf;
                this.indentPrefix = indentPrefix;
                this.indentValue = indentValue;
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
            return new Encoder(value.w, value.err, value.escapeHTML, ref value.indentBuf, value.indentPrefix, value.indentValue);
        }
    }
}}