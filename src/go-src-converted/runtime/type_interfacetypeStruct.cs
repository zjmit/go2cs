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
        private partial struct interfacetype
        {
            // Constructors
            public interfacetype(NilType _)
            {
                this.typ = default;
                this.pkgpath = default;
                this.mhdr = default;
            }

            public interfacetype(_type typ = default, name pkgpath = default, slice<imethod> mhdr = default)
            {
                this.typ = typ;
                this.pkgpath = pkgpath;
                this.mhdr = mhdr;
            }

            // Enable comparisons between nil and interfacetype struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(interfacetype value, NilType nil) => value.Equals(default(interfacetype));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(interfacetype value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, interfacetype value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, interfacetype value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator interfacetype(NilType nil) => default(interfacetype);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static interfacetype interfacetype_cast(dynamic value)
        {
            return new interfacetype(value.typ, value.pkgpath, value.mhdr);
        }
    }
}