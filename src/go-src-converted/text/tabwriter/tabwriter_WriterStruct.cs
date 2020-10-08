//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:26:19 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using io = go.io_package;
using utf8 = go.unicode.utf8_package;
using go;

namespace go {
namespace text
{
    public static partial class tabwriter_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Writer
        {
            // Constructors
            public Writer(NilType _)
            {
                this.output = default;
                this.minwidth = default;
                this.tabwidth = default;
                this.padding = default;
                this.padbytes = default;
                this.flags = default;
                this.buf = default;
                this.pos = default;
                this.cell = default;
                this.endChar = default;
                this.lines = default;
                this.widths = default;
            }

            public Writer(io.Writer output = default, long minwidth = default, long tabwidth = default, long padding = default, array<byte> padbytes = default, ulong flags = default, slice<byte> buf = default, long pos = default, cell cell = default, byte endChar = default, slice<slice<cell>> lines = default, slice<long> widths = default)
            {
                this.output = output;
                this.minwidth = minwidth;
                this.tabwidth = tabwidth;
                this.padding = padding;
                this.padbytes = padbytes;
                this.flags = flags;
                this.buf = buf;
                this.pos = pos;
                this.cell = cell;
                this.endChar = endChar;
                this.lines = lines;
                this.widths = widths;
            }

            // Enable comparisons between nil and Writer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Writer value, NilType nil) => value.Equals(default(Writer));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Writer value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Writer value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Writer value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Writer(NilType nil) => default(Writer);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Writer Writer_cast(dynamic value)
        {
            return new Writer(value.output, value.minwidth, value.tabwidth, value.padding, value.padbytes, value.flags, value.buf, value.pos, value.cell, value.endChar, value.lines, value.widths);
        }
    }
}}