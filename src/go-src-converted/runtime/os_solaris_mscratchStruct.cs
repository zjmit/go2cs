//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:22:08 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct mscratch
        {
            // Constructors
            public mscratch(NilType _)
            {
                this.v = default;
            }

            public mscratch(array<System.UIntPtr> v = default)
            {
                this.v = v;
            }

            // Enable comparisons between nil and mscratch struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(mscratch value, NilType nil) => value.Equals(default(mscratch));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(mscratch value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, mscratch value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, mscratch value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator mscratch(NilType nil) => default(mscratch);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static mscratch mscratch_cast(dynamic value)
        {
            return new mscratch(value.v);
        }
    }
}