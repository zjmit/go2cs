//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:04:23 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using token = go.go.token_package;
using io = go.io_package;
using os = go.os_package;
using reflect = go.reflect_package;
using go;

namespace go {
namespace go
{
    public static partial class ast_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct printer
        {
            // Constructors
            public printer(NilType _)
            {
                this.output = default;
                this.fset = default;
                this.filter = default;
                this.indent = default;
                this.last = default;
                this.line = default;
            }

            public printer(io.Writer output = default, ref ptr<token.FileSet> fset = default, FieldFilter filter = default, long indent = default, byte last = default, long line = default)
            {
                this.output = output;
                this.fset = fset;
                this.filter = filter;
                this.indent = indent;
                this.last = last;
                this.line = line;
            }

            // Enable comparisons between nil and printer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(printer value, NilType nil) => value.Equals(default(printer));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(printer value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, printer value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, printer value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator printer(NilType nil) => default(printer);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static printer printer_cast(dynamic value)
        {
            return new printer(value.output, ref value.fset, value.filter, value.indent, value.last, value.line);
        }
    }
}}