//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:36:28 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using flag = go.flag_package;
using fmt = go.fmt_package;
using race = go.@internal.race_package;
using io = go.io_package;
using math = go.math_package;
using os = go.os_package;
using runtime = go.runtime_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;
using time = go.time_package;
using unicode = go.unicode_package;

namespace go
{
    public static partial class testing_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct BenchmarkResult
        {
            // Constructors
            public BenchmarkResult(NilType _)
            {
                this.N = default;
                this.T = default;
                this.Bytes = default;
                this.MemAllocs = default;
                this.MemBytes = default;
                this.Extra = default;
            }

            public BenchmarkResult(long N = default, time.Duration T = default, long Bytes = default, ulong MemAllocs = default, ulong MemBytes = default, map<@string, double> Extra = default)
            {
                this.N = N;
                this.T = T;
                this.Bytes = Bytes;
                this.MemAllocs = MemAllocs;
                this.MemBytes = MemBytes;
                this.Extra = Extra;
            }

            // Enable comparisons between nil and BenchmarkResult struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(BenchmarkResult value, NilType nil) => value.Equals(default(BenchmarkResult));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(BenchmarkResult value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, BenchmarkResult value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, BenchmarkResult value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator BenchmarkResult(NilType nil) => default(BenchmarkResult);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static BenchmarkResult BenchmarkResult_cast(dynamic value)
        {
            return new BenchmarkResult(value.N, value.T, value.Bytes, value.MemAllocs, value.MemBytes, value.Extra);
        }
    }
}