//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:21:14 UTC
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
using sys = go.runtime.@internal.sys_package;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct specialprofile
        {
            // Constructors
            public specialprofile(NilType _)
            {
                this.special = default;
                this.b = default;
            }

            public specialprofile(special special = default, ref ptr<bucket> b = default)
            {
                this.special = special;
                this.b = b;
            }

            // Enable comparisons between nil and specialprofile struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(specialprofile value, NilType nil) => value.Equals(default(specialprofile));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(specialprofile value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, specialprofile value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, specialprofile value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator specialprofile(NilType nil) => default(specialprofile);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static specialprofile specialprofile_cast(dynamic value)
        {
            return new specialprofile(value.special, ref value.b);
        }
    }
}