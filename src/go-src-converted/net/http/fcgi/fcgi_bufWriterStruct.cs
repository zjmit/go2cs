//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:41:24 UTC
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
using binary = go.encoding.binary_package;
using errors = go.errors_package;
using io = go.io_package;
using sync = go.sync_package;
using go;

namespace go {
namespace net {
namespace http
{
    public static partial class fcgi_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct bufWriter
        {
            // Constructors
            public bufWriter(NilType _)
            {
                this.closer = default;
                this.Writer> = default;
            }

            public bufWriter(io.Closer closer = default, ref ptr<bufio.Writer> Writer> = default)
            {
                this.closer = closer;
                this.Writer> = Writer>;
            }

            // Enable comparisons between nil and bufWriter struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(bufWriter value, NilType nil) => value.Equals(default(bufWriter));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(bufWriter value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, bufWriter value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, bufWriter value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator bufWriter(NilType nil) => default(bufWriter);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static bufWriter bufWriter_cast(dynamic value)
        {
            return new bufWriter(value.closer, ref value.Writer>);
        }
    }
}}}