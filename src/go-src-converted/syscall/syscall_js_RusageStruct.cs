//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:27:24 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using oserror = go.@internal.oserror_package;
using sync = go.sync_package;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Rusage
        {
            // Constructors
            public Rusage(NilType _)
            {
                this.Utime = default;
                this.Stime = default;
            }

            public Rusage(Timeval Utime = default, Timeval Stime = default)
            {
                this.Utime = Utime;
                this.Stime = Stime;
            }

            // Enable comparisons between nil and Rusage struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Rusage value, NilType nil) => value.Equals(default(Rusage));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Rusage value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Rusage value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Rusage value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Rusage(NilType nil) => default(Rusage);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Rusage Rusage_cast(dynamic value)
        {
            return new Rusage(value.Utime, value.Stime);
        }
    }
}