//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:45:48 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct pthreadcond
        {
            // Constructors
            public pthreadcond(NilType _)
            {
                this.X__sig = default;
                this.X__opaque = default;
            }

            public pthreadcond(long X__sig = default, array<sbyte> X__opaque = default)
            {
                this.X__sig = X__sig;
                this.X__opaque = X__opaque;
            }

            // Enable comparisons between nil and pthreadcond struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(pthreadcond value, NilType nil) => value.Equals(default(pthreadcond));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(pthreadcond value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, pthreadcond value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, pthreadcond value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator pthreadcond(NilType nil) => default(pthreadcond);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static pthreadcond pthreadcond_cast(dynamic value)
        {
            return new pthreadcond(value.X__sig, value.X__opaque);
        }
    }
}