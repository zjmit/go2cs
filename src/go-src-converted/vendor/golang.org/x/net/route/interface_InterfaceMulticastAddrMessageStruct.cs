//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 05:01:36 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

namespace go {
namespace vendor {
namespace golang.org {
namespace x {
namespace net
{
    public static partial class route_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct InterfaceMulticastAddrMessage
        {
            // Constructors
            public InterfaceMulticastAddrMessage(NilType _)
            {
                this.Version = default;
                this.Type = default;
                this.Flags = default;
                this.Index = default;
                this.Addrs = default;
                this.raw = default;
            }

            public InterfaceMulticastAddrMessage(long Version = default, long Type = default, long Flags = default, long Index = default, slice<Addr> Addrs = default, slice<byte> raw = default)
            {
                this.Version = Version;
                this.Type = Type;
                this.Flags = Flags;
                this.Index = Index;
                this.Addrs = Addrs;
                this.raw = raw;
            }

            // Enable comparisons between nil and InterfaceMulticastAddrMessage struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(InterfaceMulticastAddrMessage value, NilType nil) => value.Equals(default(InterfaceMulticastAddrMessage));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(InterfaceMulticastAddrMessage value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, InterfaceMulticastAddrMessage value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, InterfaceMulticastAddrMessage value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator InterfaceMulticastAddrMessage(NilType nil) => default(InterfaceMulticastAddrMessage);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static InterfaceMulticastAddrMessage InterfaceMulticastAddrMessage_cast(dynamic value)
        {
            return new InterfaceMulticastAddrMessage(value.Version, value.Type, value.Flags, value.Index, value.Addrs, value.raw);
        }
    }
}}}}}