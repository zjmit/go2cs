//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:21:55 UTC
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
        private partial struct sigset
        {
            // Constructors
            public sigset(NilType _)
            {
            }
            // Enable comparisons between nil and sigset struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(sigset value, NilType nil) => value.Equals(default(sigset));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(sigset value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, sigset value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, sigset value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator sigset(NilType nil) => default(sigset);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static sigset sigset_cast(dynamic value)
        {
            return new sigset();
        }
    }
}