//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:22:23 UTC
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
        private partial struct ptabEntry
        {
            // Constructors
            public ptabEntry(NilType _)
            {
                this.name = default;
                this.typ = default;
            }

            public ptabEntry(nameOff name = default, typeOff typ = default)
            {
                this.name = name;
                this.typ = typ;
            }

            // Enable comparisons between nil and ptabEntry struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ptabEntry value, NilType nil) => value.Equals(default(ptabEntry));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ptabEntry value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ptabEntry value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ptabEntry value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ptabEntry(NilType nil) => default(ptabEntry);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static ptabEntry ptabEntry_cast(dynamic value)
        {
            return new ptabEntry(value.name, value.typ);
        }
    }
}