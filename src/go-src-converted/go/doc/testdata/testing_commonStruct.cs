//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:02:56 UTC
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
using os = go.os_package;
using runtime = go.runtime_package;
using pprof = go.runtime.pprof_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using time = go.time_package;
using go;

namespace go {
namespace go
{
    public static partial class testing_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct common
        {
            // Constructors
            public common(NilType _)
            {
                this.output = default;
                this.failed = default;
                this.start = default;
                this.duration = default;
                this.signal = default;
            }

            public common(slice<byte> output = default, bool failed = default, time.Time start = default, time.Duration duration = default, channel<object> signal = default)
            {
                this.output = output;
                this.failed = failed;
                this.start = start;
                this.duration = duration;
                this.signal = signal;
            }

            // Enable comparisons between nil and common struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(common value, NilType nil) => value.Equals(default(common));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(common value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, common value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, common value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator common(NilType nil) => default(common);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static common common_cast(dynamic value)
        {
            return new common(value.output, value.failed, value.start, value.duration, value.signal);
        }
    }
}}