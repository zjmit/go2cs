//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:19:16 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using atomic = go.runtime.@internal.atomic_package;
using math = go.runtime.@internal.math_package;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct waitq
        {
            // Constructors
            public waitq(NilType _)
            {
                this.first = default;
                this.last = default;
            }

            public waitq(ref ptr<sudog> first = default, ref ptr<sudog> last = default)
            {
                this.first = first;
                this.last = last;
            }

            // Enable comparisons between nil and waitq struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(waitq value, NilType nil) => value.Equals(default(waitq));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(waitq value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, waitq value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, waitq value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator waitq(NilType nil) => default(waitq);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static waitq waitq_cast(dynamic value)
        {
            return new waitq(ref value.first, ref value.last);
        }
    }
}