//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:19:31 UTC
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
        private partial struct umtx_time
        {
            // Constructors
            public umtx_time(NilType _)
            {
                this._timeout = default;
                this._flags = default;
                this._clockid = default;
            }

            public umtx_time(timespec _timeout = default, uint _flags = default, uint _clockid = default)
            {
                this._timeout = _timeout;
                this._flags = _flags;
                this._clockid = _clockid;
            }

            // Enable comparisons between nil and umtx_time struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(umtx_time value, NilType nil) => value.Equals(default(umtx_time));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(umtx_time value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, umtx_time value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, umtx_time value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator umtx_time(NilType nil) => default(umtx_time);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static umtx_time umtx_time_cast(dynamic value)
        {
            return new umtx_time(value._timeout, value._flags, value._clockid);
        }
    }
}