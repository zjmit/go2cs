//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:32:17 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;
using sync = go.sync_package;
using syscall = go.syscall_package;
using time = go.time_package;
using _@unsafe_ = go.@unsafe_package;
using go;

namespace go {
namespace @internal
{
    public static partial class poll_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct pollDesc
        {
            // Constructors
            public pollDesc(NilType _)
            {
                this.runtimeCtx = default;
            }

            public pollDesc(System.UIntPtr runtimeCtx = default)
            {
                this.runtimeCtx = runtimeCtx;
            }

            // Enable comparisons between nil and pollDesc struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(pollDesc value, NilType nil) => value.Equals(default(pollDesc));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(pollDesc value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, pollDesc value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, pollDesc value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator pollDesc(NilType nil) => default(pollDesc);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static pollDesc pollDesc_cast(dynamic value)
        {
            return new pollDesc(value.runtimeCtx);
        }
    }
}}