//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:58:43 UTC
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
using fmt = go.fmt_package;
using io = go.io_package;
using go;

namespace go {
namespace compress
{
    public static partial class lzw_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct errWriteCloser
        {
            // Constructors
            public errWriteCloser(NilType _)
            {
                this.err = default;
            }

            public errWriteCloser(error err = default)
            {
                this.err = err;
            }

            // Enable comparisons between nil and errWriteCloser struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(errWriteCloser value, NilType nil) => value.Equals(default(errWriteCloser));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(errWriteCloser value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, errWriteCloser value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, errWriteCloser value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator errWriteCloser(NilType nil) => default(errWriteCloser);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static errWriteCloser errWriteCloser_cast(dynamic value)
        {
            return new errWriteCloser(value.err);
        }
    }
}}