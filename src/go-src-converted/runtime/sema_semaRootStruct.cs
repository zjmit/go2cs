//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:22:57 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using cpu = go.@internal.cpu_package;
using atomic = go.runtime.@internal.atomic_package;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct semaRoot
        {
            // Constructors
            public semaRoot(NilType _)
            {
                this.@lock = default;
                this.treap = default;
                this.nwait = default;
            }

            public semaRoot(mutex @lock = default, ref ptr<sudog> treap = default, uint nwait = default)
            {
                this.@lock = @lock;
                this.treap = treap;
                this.nwait = nwait;
            }

            // Enable comparisons between nil and semaRoot struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(semaRoot value, NilType nil) => value.Equals(default(semaRoot));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(semaRoot value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, semaRoot value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, semaRoot value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator semaRoot(NilType nil) => default(semaRoot);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static semaRoot semaRoot_cast(dynamic value)
        {
            return new semaRoot(value.@lock, ref value.treap, value.nwait);
        }
    }
}