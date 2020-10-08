//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:38:09 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using strings = go.strings_package;
using cryptobyte = go.golang.org.x.crypto.cryptobyte_package;
using go;

namespace go {
namespace crypto
{
    public static partial class tls_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct newSessionTicketMsg
        {
            // Constructors
            public newSessionTicketMsg(NilType _)
            {
                this.raw = default;
                this.ticket = default;
            }

            public newSessionTicketMsg(slice<byte> raw = default, slice<byte> ticket = default)
            {
                this.raw = raw;
                this.ticket = ticket;
            }

            // Enable comparisons between nil and newSessionTicketMsg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(newSessionTicketMsg value, NilType nil) => value.Equals(default(newSessionTicketMsg));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(newSessionTicketMsg value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, newSessionTicketMsg value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, newSessionTicketMsg value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator newSessionTicketMsg(NilType nil) => default(newSessionTicketMsg);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static newSessionTicketMsg newSessionTicketMsg_cast(dynamic value)
        {
            return new newSessionTicketMsg(value.raw, value.ticket);
        }
    }
}}