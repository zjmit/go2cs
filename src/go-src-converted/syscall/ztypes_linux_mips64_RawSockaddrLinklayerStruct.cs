//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:30:37 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct RawSockaddrLinklayer
        {
            // Constructors
            public RawSockaddrLinklayer(NilType _)
            {
                this.Family = default;
                this.Protocol = default;
                this.Ifindex = default;
                this.Hatype = default;
                this.Pkttype = default;
                this.Halen = default;
                this.Addr = default;
            }

            public RawSockaddrLinklayer(ushort Family = default, ushort Protocol = default, int Ifindex = default, ushort Hatype = default, byte Pkttype = default, byte Halen = default, array<byte> Addr = default)
            {
                this.Family = Family;
                this.Protocol = Protocol;
                this.Ifindex = Ifindex;
                this.Hatype = Hatype;
                this.Pkttype = Pkttype;
                this.Halen = Halen;
                this.Addr = Addr;
            }

            // Enable comparisons between nil and RawSockaddrLinklayer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(RawSockaddrLinklayer value, NilType nil) => value.Equals(default(RawSockaddrLinklayer));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(RawSockaddrLinklayer value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, RawSockaddrLinklayer value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, RawSockaddrLinklayer value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RawSockaddrLinklayer(NilType nil) => default(RawSockaddrLinklayer);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static RawSockaddrLinklayer RawSockaddrLinklayer_cast(dynamic value)
        {
            return new RawSockaddrLinklayer(value.Family, value.Protocol, value.Ifindex, value.Hatype, value.Pkttype, value.Halen, value.Addr);
        }
    }
}