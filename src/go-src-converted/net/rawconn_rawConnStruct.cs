//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:34:10 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using runtime = go.runtime_package;
using syscall = go.syscall_package;

namespace go
{
    public static partial class net_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct rawConn
        {
            // Constructors
            public rawConn(NilType _)
            {
                this.fd = default;
            }

            public rawConn(ref ptr<netFD> fd = default)
            {
                this.fd = fd;
            }

            // Enable comparisons between nil and rawConn struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(rawConn value, NilType nil) => value.Equals(default(rawConn));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(rawConn value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, rawConn value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, rawConn value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator rawConn(NilType nil) => default(rawConn);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static rawConn rawConn_cast(dynamic value)
        {
            return new rawConn(ref value.fd);
        }
    }
}