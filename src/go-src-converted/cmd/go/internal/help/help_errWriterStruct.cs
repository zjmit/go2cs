//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:00:39 UTC
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
using fmt = go.fmt_package;
using io = go.io_package;
using os = go.os_package;
using strings = go.strings_package;
using template = go.text.template_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using @base = go.cmd.go.@internal.@base_package;
using go;

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class help_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct errWriter
        {
            // Constructors
            public errWriter(NilType _)
            {
                this.w = default;
                this.err = default;
            }

            public errWriter(io.Writer w = default, error err = default)
            {
                this.w = w;
                this.err = err;
            }

            // Enable comparisons between nil and errWriter struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(errWriter value, NilType nil) => value.Equals(default(errWriter));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(errWriter value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, errWriter value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, errWriter value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator errWriter(NilType nil) => default(errWriter);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static errWriter errWriter_cast(dynamic value)
        {
            return new errWriter(value.w, value.err);
        }
    }
}}}}