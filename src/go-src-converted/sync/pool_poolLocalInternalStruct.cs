//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:36:44 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using race = go.@internal.race_package;
using runtime = go.runtime_package;
using atomic = go.sync.atomic_package;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class sync_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct poolLocalInternal
        {
            // Constructors
            public poolLocalInternal(NilType _)
            {
                this.shared = default;
                this.Mutex = default;
            }

            public poolLocalInternal(slice<object> shared = default, Mutex Mutex = default)
            {
                this.shared = shared;
                this.Mutex = Mutex;
            }

            // Enable comparisons between nil and poolLocalInternal struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(poolLocalInternal value, NilType nil) => value.Equals(default(poolLocalInternal));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(poolLocalInternal value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, poolLocalInternal value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, poolLocalInternal value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator poolLocalInternal(NilType nil) => default(poolLocalInternal);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static poolLocalInternal poolLocalInternal_cast(dynamic value)
        {
            return new poolLocalInternal(value.shared, value.Mutex);
        }
    }
}