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
        public partial struct TCPMD5Sig
        {
            // Constructors
            public TCPMD5Sig(NilType _)
            {
                this.Addr = default;
                this.Flags = default;
                this.Prefixlen = default;
                this.Keylen = default;
                this._ = default;
                this.Key = default;
            }

            public TCPMD5Sig(SockaddrStorage Addr = default, byte Flags = default, byte Prefixlen = default, ushort Keylen = default, uint _ = default, array<byte> Key = default)
            {
                this.Addr = Addr;
                this.Flags = Flags;
                this.Prefixlen = Prefixlen;
                this.Keylen = Keylen;
                this._ = _;
                this.Key = Key;
            }

            // Enable comparisons between nil and TCPMD5Sig struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(TCPMD5Sig value, NilType nil) => value.Equals(default(TCPMD5Sig));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(TCPMD5Sig value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, TCPMD5Sig value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, TCPMD5Sig value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator TCPMD5Sig(NilType nil) => default(TCPMD5Sig);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static TCPMD5Sig TCPMD5Sig_cast(dynamic value)
        {
            return new TCPMD5Sig(value.Addr, value.Flags, value.Prefixlen, value.Keylen, value._, value.Key);
        }
    }
}}}}}}