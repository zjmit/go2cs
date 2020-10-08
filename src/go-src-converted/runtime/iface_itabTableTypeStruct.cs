//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:19:53 UTC
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
        private partial struct itabTableType
        {
            // Constructors
            public itabTableType(NilType _)
            {
                this.size = default;
                this.count = default;
                this.entries = default;
            }

            public itabTableType(System.UIntPtr size = default, System.UIntPtr count = default, array<ptr<itab>> entries = default)
            {
                this.size = size;
                this.count = count;
                this.entries = entries;
            }

            // Enable comparisons between nil and itabTableType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(itabTableType value, NilType nil) => value.Equals(default(itabTableType));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(itabTableType value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, itabTableType value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, itabTableType value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator itabTableType(NilType nil) => default(itabTableType);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static itabTableType itabTableType_cast(dynamic value)
        {
            return new itabTableType(value.size, value.count, value.entries);
        }
    }
}