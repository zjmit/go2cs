//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:34:11 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using bytes = go.bytes_package;
using binary = go.encoding.binary_package;
using errors = go.errors_package;
using io = go.io_package;
using sync = go.sync_package;
using go;

namespace go {
namespace net {
namespace http
{
    public static partial class fcgi_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct beginRequest
        {
            // Constructors
            public beginRequest(NilType _)
            {
                this.role = default;
                this.flags = default;
                this.reserved = default;
            }

            public beginRequest(ushort role = default, byte flags = default, array<byte> reserved = default)
            {
                this.role = role;
                this.flags = flags;
                this.reserved = reserved;
            }

            // Enable comparisons between nil and beginRequest struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(beginRequest value, NilType nil) => value.Equals(default(beginRequest));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(beginRequest value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, beginRequest value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, beginRequest value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator beginRequest(NilType nil) => default(beginRequest);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static beginRequest beginRequest_cast(dynamic value)
        {
            return new beginRequest(value.role, value.flags, value.reserved);
        }
    }
}}}