//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:10:05 UTC
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
using src = go.cmd.@internal.src_package;
using fmt = go.fmt_package;
using crc32 = go.hash.crc32_package;
using log = go.log_package;
using rand = go.math.rand_package;
using os = go.os_package;
using regexp = go.regexp_package;
using runtime = go.runtime_package;
using sort = go.sort_package;
using strings = go.strings_package;
using time = go.time_package;
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct constraint
        {
            // Constructors
            public constraint(NilType _)
            {
                this.a = default;
                this.b = default;
            }

            public constraint(@string a = default, @string b = default)
            {
                this.a = a;
                this.b = b;
            }

            // Enable comparisons between nil and constraint struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(constraint value, NilType nil) => value.Equals(default(constraint));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(constraint value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, constraint value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, constraint value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator constraint(NilType nil) => default(constraint);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static constraint constraint_cast(dynamic value)
        {
            return new constraint(value.a, value.b);
        }
    }
}}}}