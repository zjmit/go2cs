//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:09:12 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using sort = go.sort_package;
using go;

namespace go {
namespace cmd {
namespace @internal
{
    public static partial class edit_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct edit
        {
            // Constructors
            public edit(NilType _)
            {
                this.start = default;
                this.end = default;
                this.@new = default;
            }

            public edit(long start = default, long end = default, @string @new = default)
            {
                this.start = start;
                this.end = end;
                this.@new = @new;
            }

            // Enable comparisons between nil and edit struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(edit value, NilType nil) => value.Equals(default(edit));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(edit value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, edit value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, edit value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator edit(NilType nil) => default(edit);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static edit edit_cast(dynamic value)
        {
            return new edit(value.start, value.end, value.@new);
        }
    }
}}}