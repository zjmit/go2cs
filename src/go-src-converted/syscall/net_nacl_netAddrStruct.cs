//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:37:23 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct netAddr
        {
            // Constructors
            public netAddr(NilType _)
            {
                this.proto = default;
                this.sotype = default;
            }

            public netAddr(ref ptr<netproto> proto = default, long sotype = default)
            {
                this.proto = proto;
                this.sotype = sotype;
            }

            // Enable comparisons between nil and netAddr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(netAddr value, NilType nil) => value.Equals(default(netAddr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(netAddr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, netAddr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, netAddr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator netAddr(NilType nil) => default(netAddr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static netAddr netAddr_cast(dynamic value)
        {
            return new netAddr(ref value.proto, value.sotype);
        }
    }
}