//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:21:26 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using atomic = go.runtime.@internal.atomic_package;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct memRecordCycle
        {
            // Constructors
            public memRecordCycle(NilType _)
            {
                this.allocs = default;
                this.frees = default;
                this.alloc_bytes = default;
                this.free_bytes = default;
            }

            public memRecordCycle(System.UIntPtr allocs = default, System.UIntPtr frees = default, System.UIntPtr alloc_bytes = default, System.UIntPtr free_bytes = default)
            {
                this.allocs = allocs;
                this.frees = frees;
                this.alloc_bytes = alloc_bytes;
                this.free_bytes = free_bytes;
            }

            // Enable comparisons between nil and memRecordCycle struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(memRecordCycle value, NilType nil) => value.Equals(default(memRecordCycle));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(memRecordCycle value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, memRecordCycle value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, memRecordCycle value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator memRecordCycle(NilType nil) => default(memRecordCycle);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static memRecordCycle memRecordCycle_cast(dynamic value)
        {
            return new memRecordCycle(value.allocs, value.frees, value.alloc_bytes, value.free_bytes);
        }
    }
}