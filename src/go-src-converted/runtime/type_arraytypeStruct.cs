//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:24:19 UTC
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
        private partial struct arraytype
        {
            // Constructors
            public arraytype(NilType _)
            {
                this.typ = default;
                this.elem = default;
                this.slice = default;
                this.len = default;
            }

            public arraytype(_type typ = default, ref ptr<_type> elem = default, ref ptr<_type> slice = default, System.UIntPtr len = default)
            {
                this.typ = typ;
                this.elem = elem;
                this.slice = slice;
                this.len = len;
            }

            // Enable comparisons between nil and arraytype struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(arraytype value, NilType nil) => value.Equals(default(arraytype));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(arraytype value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, arraytype value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, arraytype value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator arraytype(NilType nil) => default(arraytype);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static arraytype arraytype_cast(dynamic value)
        {
            return new arraytype(value.typ, ref value.elem, ref value.slice, value.len);
        }
    }
}