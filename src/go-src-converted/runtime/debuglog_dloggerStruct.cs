//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:19:27 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using atomic = go.runtime.@internal.atomic_package;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct dlogger
        {
            // Constructors
            public dlogger(NilType _)
            {
                this.w = default;
                this.allLink = default;
                this.owned = default;
            }

            public dlogger(debugLogWriter w = default, ref ptr<dlogger> allLink = default, uint owned = default)
            {
                this.w = w;
                this.allLink = allLink;
                this.owned = owned;
            }

            // Enable comparisons between nil and dlogger struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(dlogger value, NilType nil) => value.Equals(default(dlogger));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(dlogger value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, dlogger value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, dlogger value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator dlogger(NilType nil) => default(dlogger);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static dlogger dlogger_cast(dynamic value)
        {
            return new dlogger(value.w, ref value.allLink, value.owned);
        }
    }
}