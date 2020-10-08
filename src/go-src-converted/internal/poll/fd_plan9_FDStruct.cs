//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:32:15 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;
using io = go.io_package;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;
using time = go.time_package;
using go;

namespace go {
namespace @internal
{
    public static partial class poll_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct FD
        {
            // Constructors
            public FD(NilType _)
            {
                this.fdmu = default;
                this.Destroy = default;
                this.rmu = default;
                this.wmu = default;
                this.raio = default;
                this.waio = default;
                this.rtimer = default;
                this.wtimer = default;
                this.rtimedout = default;
                this.wtimedout = default;
                this.isFile = default;
            }

            public FD(fdMutex fdmu = default, Action Destroy = default, sync.Mutex rmu = default, sync.Mutex wmu = default, ref ptr<asyncIO> raio = default, ref ptr<asyncIO> waio = default, ref ptr<time.Timer> rtimer = default, ref ptr<time.Timer> wtimer = default, atomicBool rtimedout = default, atomicBool wtimedout = default, bool isFile = default)
            {
                this.fdmu = fdmu;
                this.Destroy = Destroy;
                this.rmu = rmu;
                this.wmu = wmu;
                this.raio = raio;
                this.waio = waio;
                this.rtimer = rtimer;
                this.wtimer = wtimer;
                this.rtimedout = rtimedout;
                this.wtimedout = wtimedout;
                this.isFile = isFile;
            }

            // Enable comparisons between nil and FD struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(FD value, NilType nil) => value.Equals(default(FD));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(FD value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, FD value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, FD value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator FD(NilType nil) => default(FD);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static FD FD_cast(dynamic value)
        {
            return new FD(value.fdmu, value.Destroy, value.rmu, value.wmu, ref value.raio, ref value.waio, ref value.rtimer, ref value.wtimer, value.rtimedout, value.wtimedout, value.isFile);
        }
    }
}}