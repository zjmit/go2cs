//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:53:32 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class unix_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Tpacket2Hdr
        {
            // Constructors
            public Tpacket2Hdr(NilType _)
            {
                this.Status = default;
                this.Len = default;
                this.Snaplen = default;
                this.Mac = default;
                this.Net = default;
                this.Sec = default;
                this.Nsec = default;
                this.Vlan_tci = default;
                this.Vlan_tpid = default;
                this._ = default;
            }

            public Tpacket2Hdr(uint Status = default, uint Len = default, uint Snaplen = default, ushort Mac = default, ushort Net = default, uint Sec = default, uint Nsec = default, ushort Vlan_tci = default, ushort Vlan_tpid = default, array<byte> _ = default)
            {
                this.Status = Status;
                this.Len = Len;
                this.Snaplen = Snaplen;
                this.Mac = Mac;
                this.Net = Net;
                this.Sec = Sec;
                this.Nsec = Nsec;
                this.Vlan_tci = Vlan_tci;
                this.Vlan_tpid = Vlan_tpid;
                this._ = _;
            }

            // Enable comparisons between nil and Tpacket2Hdr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Tpacket2Hdr value, NilType nil) => value.Equals(default(Tpacket2Hdr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Tpacket2Hdr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Tpacket2Hdr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Tpacket2Hdr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tpacket2Hdr(NilType nil) => default(Tpacket2Hdr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Tpacket2Hdr Tpacket2Hdr_cast(dynamic value)
        {
            return new Tpacket2Hdr(value.Status, value.Len, value.Snaplen, value.Mac, value.Net, value.Sec, value.Nsec, value.Vlan_tci, value.Vlan_tpid, value._);
        }
    }
}}}}}}