//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:22:52 UTC
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
        private partial struct note
        {
            // Constructors
            public note(NilType _)
            {
                this.key = default;
            }

            public note(System.UIntPtr key = default)
            {
                this.key = key;
            }

            // Enable comparisons between nil and note struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(note value, NilType nil) => value.Equals(default(note));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(note value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, note value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, note value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator note(NilType nil) => default(note);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static note note_cast(dynamic value)
        {
            return new note(value.key);
        }
    }
}