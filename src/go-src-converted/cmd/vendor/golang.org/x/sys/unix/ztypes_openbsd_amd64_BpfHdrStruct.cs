//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:53:40 UTC
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
        public partial struct BpfHdr
        {
            // Constructors
            public BpfHdr(NilType _)
            {
                this.Tstamp = default;
                this.Caplen = default;
                this.Datalen = default;
                this.Hdrlen = default;
                this._ = default;
            }

            public BpfHdr(BpfTimeval Tstamp = default, uint Caplen = default, uint Datalen = default, ushort Hdrlen = default, array<byte> _ = default)
            {
                this.Tstamp = Tstamp;
                this.Caplen = Caplen;
                this.Datalen = Datalen;
                this.Hdrlen = Hdrlen;
                this._ = _;
            }

            // Enable comparisons between nil and BpfHdr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(BpfHdr value, NilType nil) => value.Equals(default(BpfHdr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(BpfHdr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, BpfHdr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, BpfHdr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator BpfHdr(NilType nil) => default(BpfHdr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static BpfHdr BpfHdr_cast(dynamic value)
        {
            return new BpfHdr(value.Tstamp, value.Caplen, value.Datalen, value.Hdrlen, value._);
        }
    }
}}}}}}