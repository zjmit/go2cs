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
        private partial struct specialfinalizer
        {
            // Constructors
            public specialfinalizer(NilType _)
            {
                this.special = default;
                this.fn = default;
                this.nret = default;
                this.fint = default;
                this.ot = default;
            }

            public specialfinalizer(special special = default, ref ptr<funcval> fn = default, System.UIntPtr nret = default, ref ptr<_type> fint = default, ref ptr<ptrtype> ot = default)
            {
                this.special = special;
                this.fn = fn;
                this.nret = nret;
                this.fint = fint;
                this.ot = ot;
            }

            // Enable comparisons between nil and specialfinalizer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(specialfinalizer value, NilType nil) => value.Equals(default(specialfinalizer));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(specialfinalizer value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, specialfinalizer value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, specialfinalizer value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator specialfinalizer(NilType nil) => default(specialfinalizer);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static specialfinalizer specialfinalizer_cast(dynamic value)
        {
            return new specialfinalizer(value.special, ref value.fn, value.nret, ref value.fint, ref value.ot);
        }
    }
}