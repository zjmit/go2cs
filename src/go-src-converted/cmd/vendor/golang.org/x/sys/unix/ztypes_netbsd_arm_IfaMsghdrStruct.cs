//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:53:39 UTC
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
        public partial struct IfaMsghdr
        {
            // Constructors
            public IfaMsghdr(NilType _)
            {
                this.Msglen = default;
                this.Version = default;
                this.Type = default;
                this.Addrs = default;
                this.Flags = default;
                this.Metric = default;
                this.Index = default;
                this.Pad_cgo_0 = default;
            }

            public IfaMsghdr(ushort Msglen = default, byte Version = default, byte Type = default, int Addrs = default, int Flags = default, int Metric = default, ushort Index = default, array<byte> Pad_cgo_0 = default)
            {
                this.Msglen = Msglen;
                this.Version = Version;
                this.Type = Type;
                this.Addrs = Addrs;
                this.Flags = Flags;
                this.Metric = Metric;
                this.Index = Index;
                this.Pad_cgo_0 = Pad_cgo_0;
            }

            // Enable comparisons between nil and IfaMsghdr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(IfaMsghdr value, NilType nil) => value.Equals(default(IfaMsghdr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(IfaMsghdr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, IfaMsghdr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, IfaMsghdr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator IfaMsghdr(NilType nil) => default(IfaMsghdr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static IfaMsghdr IfaMsghdr_cast(dynamic value)
        {
            return new IfaMsghdr(value.Msglen, value.Version, value.Type, value.Addrs, value.Flags, value.Metric, value.Index, value.Pad_cgo_0);
        }
    }
}}}}}}