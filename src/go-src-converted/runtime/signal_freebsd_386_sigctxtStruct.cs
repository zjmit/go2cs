//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:23:06 UTC
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
        private partial struct sigctxt
        {
            // Constructors
            public sigctxt(NilType _)
            {
                this.info = default;
                this.ctxt = default;
            }

            public sigctxt(ref ptr<siginfo> info = default, unsafe.Pointer ctxt = default)
            {
                this.info = info;
                this.ctxt = ctxt;
            }

            // Enable comparisons between nil and sigctxt struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(sigctxt value, NilType nil) => value.Equals(default(sigctxt));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(sigctxt value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, sigctxt value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, sigctxt value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator sigctxt(NilType nil) => default(sigctxt);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static sigctxt sigctxt_cast(dynamic value)
        {
            return new sigctxt(ref value.info, value.ctxt);
        }
    }
}