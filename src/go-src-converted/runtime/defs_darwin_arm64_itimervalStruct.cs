//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:19:29 UTC
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
        private partial struct itimerval
        {
            // Constructors
            public itimerval(NilType _)
            {
                this.it_interval = default;
                this.it_value = default;
            }

            public itimerval(timeval it_interval = default, timeval it_value = default)
            {
                this.it_interval = it_interval;
                this.it_value = it_value;
            }

            // Enable comparisons between nil and itimerval struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(itimerval value, NilType nil) => value.Equals(default(itimerval));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(itimerval value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, itimerval value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, itimerval value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator itimerval(NilType nil) => default(itimerval);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static itimerval itimerval_cast(dynamic value)
        {
            return new itimerval(value.it_interval, value.it_value);
        }
    }
}