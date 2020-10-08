//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:22:25 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using atomic = go.runtime.@internal.atomic_package;
using sys = go.runtime.@internal.sys_package;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct suspendGState
        {
            // Constructors
            public suspendGState(NilType _)
            {
                this.g = default;
                this.dead = default;
                this.stopped = default;
            }

            public suspendGState(ref ptr<g> g = default, bool dead = default, bool stopped = default)
            {
                this.g = g;
                this.dead = dead;
                this.stopped = stopped;
            }

            // Enable comparisons between nil and suspendGState struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(suspendGState value, NilType nil) => value.Equals(default(suspendGState));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(suspendGState value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, suspendGState value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, suspendGState value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator suspendGState(NilType nil) => default(suspendGState);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static suspendGState suspendGState_cast(dynamic value)
        {
            return new suspendGState(ref value.g, value.dead, value.stopped);
        }
    }
}