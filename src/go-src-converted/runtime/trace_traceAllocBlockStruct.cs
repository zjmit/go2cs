//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:24:11 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using sys = go.runtime.@internal.sys_package;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct traceAllocBlock
        {
            // Constructors
            public traceAllocBlock(NilType _)
            {
                this.next = default;
                this.data = default;
            }

            public traceAllocBlock(traceAllocBlockPtr next = default, array<byte> data = default)
            {
                this.next = next;
                this.data = data;
            }

            // Enable comparisons between nil and traceAllocBlock struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(traceAllocBlock value, NilType nil) => value.Equals(default(traceAllocBlock));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(traceAllocBlock value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, traceAllocBlock value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, traceAllocBlock value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator traceAllocBlock(NilType nil) => default(traceAllocBlock);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static traceAllocBlock traceAllocBlock_cast(dynamic value)
        {
            return new traceAllocBlock(value.next, value.data);
        }
    }
}