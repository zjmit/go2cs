//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:07:48 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using objabi = go.cmd.@internal.objabi_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using exec = go.os.exec_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using go;

namespace go {
namespace cmd {
namespace @internal
{
    public static partial class dwarf_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Range
        {
            // Constructors
            public Range(NilType _)
            {
                this.Start = default;
                this.End = default;
            }

            public Range(long Start = default, long End = default)
            {
                this.Start = Start;
                this.End = End;
            }

            // Enable comparisons between nil and Range struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Range value, NilType nil) => value.Equals(default(Range));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Range value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Range value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Range value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Range(NilType nil) => default(Range);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Range Range_cast(dynamic value)
        {
            return new Range(value.Start, value.End);
        }
    }
}}}