//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:34:17 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using errors = go.errors_package;
using io = go.io_package;
using utf8 = go.unicode.utf8_package;
using go;

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class imports_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct importReader
        {
            // Constructors
            public importReader(NilType _)
            {
                this.b = default;
                this.buf = default;
                this.peek = default;
                this.err = default;
                this.eof = default;
                this.nerr = default;
            }

            public importReader(ref ptr<bufio.Reader> b = default, slice<byte> buf = default, byte peek = default, error err = default, bool eof = default, long nerr = default)
            {
                this.b = b;
                this.buf = buf;
                this.peek = peek;
                this.err = err;
                this.eof = eof;
                this.nerr = nerr;
            }

            // Enable comparisons between nil and importReader struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(importReader value, NilType nil) => value.Equals(default(importReader));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(importReader value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, importReader value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, importReader value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator importReader(NilType nil) => default(importReader);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static importReader importReader_cast(dynamic value)
        {
            return new importReader(ref value.b, value.buf, value.peek, value.err, value.eof, value.nerr);
        }
    }
}}}}