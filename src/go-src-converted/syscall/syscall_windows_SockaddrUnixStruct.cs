//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:27:49 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errorspkg = go.errors_package;
using oserror = go.@internal.oserror_package;
using race = go.@internal.race_package;
using unsafeheader = go.@internal.unsafeheader_package;
using runtime = go.runtime_package;
using sync = go.sync_package;
using utf16 = go.unicode.utf16_package;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct SockaddrUnix
        {
            // Constructors
            public SockaddrUnix(NilType _)
            {
                this.Name = default;
                this.raw = default;
            }

            public SockaddrUnix(@string Name = default, RawSockaddrUnix raw = default)
            {
                this.Name = Name;
                this.raw = raw;
            }

            // Enable comparisons between nil and SockaddrUnix struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(SockaddrUnix value, NilType nil) => value.Equals(default(SockaddrUnix));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(SockaddrUnix value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, SockaddrUnix value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, SockaddrUnix value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SockaddrUnix(NilType nil) => default(SockaddrUnix);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static SockaddrUnix SockaddrUnix_cast(dynamic value)
        {
            return new SockaddrUnix(value.Name, value.raw);
        }
    }
}