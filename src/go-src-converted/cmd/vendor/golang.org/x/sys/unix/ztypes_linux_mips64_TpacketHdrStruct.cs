//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:38 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

#nullable enable

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
        public partial struct TpacketHdr
        {
            // Constructors
            public TpacketHdr(NilType _)
            {
                this.Status = default;
                this.Len = default;
                this.Snaplen = default;
                this.Mac = default;
                this.Net = default;
                this.Sec = default;
                this.Usec = default;
                this._ = default;
            }

            public TpacketHdr(ulong Status = default, uint Len = default, uint Snaplen = default, ushort Mac = default, ushort Net = default, uint Sec = default, uint Usec = default, array<byte> _ = default)
            {
                this.Status = Status;
                this.Len = Len;
                this.Snaplen = Snaplen;
                this.Mac = Mac;
                this.Net = Net;
                this.Sec = Sec;
                this.Usec = Usec;
                this._ = _;
            }

            // Enable comparisons between nil and TpacketHdr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(TpacketHdr value, NilType nil) => value.Equals(default(TpacketHdr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(TpacketHdr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, TpacketHdr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, TpacketHdr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator TpacketHdr(NilType nil) => default(TpacketHdr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static TpacketHdr TpacketHdr_cast(dynamic value)
        {
            return new TpacketHdr(value.Status, value.Len, value.Snaplen, value.Mac, value.Net, value.Sec, value.Usec, value._);
        }
    }
}}}}}}