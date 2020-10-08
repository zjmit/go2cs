//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:39:20 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using io = go.io_package;
using os = go.os_package;
using runtime = go.runtime_package;
using pprof = go.runtime.pprof_package;
using time = go.time_package;
using unicode = go.unicode_package;
using go;

namespace go {
namespace cmd {
namespace link {
namespace @internal
{
    public static partial class benchmark_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Metrics
        {
            // Constructors
            public Metrics(NilType _)
            {
                this.gc = default;
                this.marks = default;
                this.curMark = default;
                this.filebase = default;
                this.pprofFile = default;
            }

            public Metrics(Flags gc = default, slice<ptr<mark>> marks = default, ref ptr<mark> curMark = default, @string filebase = default, ref ptr<os.File> pprofFile = default)
            {
                this.gc = gc;
                this.marks = marks;
                this.curMark = curMark;
                this.filebase = filebase;
                this.pprofFile = pprofFile;
            }

            // Enable comparisons between nil and Metrics struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Metrics value, NilType nil) => value.Equals(default(Metrics));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Metrics value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Metrics value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Metrics value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Metrics(NilType nil) => default(Metrics);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Metrics Metrics_cast(dynamic value)
        {
            return new Metrics(value.gc, value.marks, ref value.curMark, value.filebase, ref value.pprofFile);
        }
    }
}}}}