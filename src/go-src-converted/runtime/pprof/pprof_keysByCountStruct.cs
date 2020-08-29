//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:22:50 UTC
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
using runtime = go.runtime_package;
using sort = go.sort_package;
using strings = go.strings_package;
using sync = go.sync_package;
using tabwriter = go.text.tabwriter_package;
using time = go.time_package;
using @unsafe = go.@unsafe_package;
using go;

namespace go {
namespace runtime
{
    public static partial class pprof_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct keysByCount
        {
            // Constructors
            public keysByCount(NilType _)
            {
                this.keys = default;
                this.count = default;
            }

            public keysByCount(slice<@string> keys = default, map<@string, long> count = default)
            {
                this.keys = keys;
                this.count = count;
            }

            // Enable comparisons between nil and keysByCount struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(keysByCount value, NilType nil) => value.Equals(default(keysByCount));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(keysByCount value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, keysByCount value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, keysByCount value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator keysByCount(NilType nil) => default(keysByCount);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static keysByCount keysByCount_cast(dynamic value)
        {
            return new keysByCount(value.keys, value.count);
        }
    }
}}