//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:19:32 UTC
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
        private partial struct stackt
        {
            // Constructors
            public stackt(NilType _)
            {
                this.ss_sp = default;
                this.ss_size = default;
                this.ss_flags = default;
            }

            public stackt(System.UIntPtr ss_sp = default, System.UIntPtr ss_size = default, int ss_flags = default)
            {
                this.ss_sp = ss_sp;
                this.ss_size = ss_size;
                this.ss_flags = ss_flags;
            }

            // Enable comparisons between nil and stackt struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(stackt value, NilType nil) => value.Equals(default(stackt));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(stackt value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, stackt value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, stackt value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator stackt(NilType nil) => default(stackt);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static stackt stackt_cast(dynamic value)
        {
            return new stackt(value.ss_sp, value.ss_size, value.ss_flags);
        }
    }
}