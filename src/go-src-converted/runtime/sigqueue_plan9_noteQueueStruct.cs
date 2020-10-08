//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:23:34 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using _@unsafe_ = go.@unsafe_package;

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct noteQueue
        {
            // Constructors
            public noteQueue(NilType _)
            {
                this.@lock = default;
                this.data = default;
                this.ri = default;
                this.wi = default;
                this.full = default;
            }

            public noteQueue(mutex @lock = default, array<noteData> data = default, long ri = default, long wi = default, bool full = default)
            {
                this.@lock = @lock;
                this.data = data;
                this.ri = ri;
                this.wi = wi;
                this.full = full;
            }

            // Enable comparisons between nil and noteQueue struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(noteQueue value, NilType nil) => value.Equals(default(noteQueue));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(noteQueue value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, noteQueue value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, noteQueue value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator noteQueue(NilType nil) => default(noteQueue);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static noteQueue noteQueue_cast(dynamic value)
        {
            return new noteQueue(value.@lock, value.data, value.ri, value.wi, value.full);
        }
    }
}