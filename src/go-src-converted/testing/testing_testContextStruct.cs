//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:36:38 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using errors = go.errors_package;
using flag = go.flag_package;
using fmt = go.fmt_package;
using race = go.@internal.race_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using os = go.os_package;
using runtime = go.runtime_package;
using debug = go.runtime.debug_package;
using trace = go.runtime.trace_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;
using time = go.time_package;

namespace go
{
    public static partial class testing_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct testContext
        {
            // Constructors
            public testContext(NilType _)
            {
                this.match = default;
                this.deadline = default;
                this.mu = default;
                this.startParallel = default;
                this.running = default;
                this.numWaiting = default;
                this.maxParallel = default;
            }

            public testContext(ref ptr<matcher> match = default, time.Time deadline = default, sync.Mutex mu = default, channel<bool> startParallel = default, long running = default, long numWaiting = default, long maxParallel = default)
            {
                this.match = match;
                this.deadline = deadline;
                this.mu = mu;
                this.startParallel = startParallel;
                this.running = running;
                this.numWaiting = numWaiting;
                this.maxParallel = maxParallel;
            }

            // Enable comparisons between nil and testContext struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(testContext value, NilType nil) => value.Equals(default(testContext));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(testContext value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, testContext value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, testContext value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator testContext(NilType nil) => default(testContext);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static testContext testContext_cast(dynamic value)
        {
            return new testContext(ref value.match, value.deadline, value.mu, value.startParallel, value.running, value.numWaiting, value.maxParallel);
        }
    }
}