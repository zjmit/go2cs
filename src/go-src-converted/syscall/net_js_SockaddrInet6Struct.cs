//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:26:50 UTC
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
        public partial struct SockaddrInet6
        {
            // Constructors
            public SockaddrInet6(NilType _)
            {
                this.Port = default;
                this.ZoneId = default;
                this.Addr = default;
            }

            public SockaddrInet6(long Port = default, uint ZoneId = default, array<byte> Addr = default)
            {
                this.Port = Port;
                this.ZoneId = ZoneId;
                this.Addr = Addr;
            }

            // Enable comparisons between nil and SockaddrInet6 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(SockaddrInet6 value, NilType nil) => value.Equals(default(SockaddrInet6));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(SockaddrInet6 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, SockaddrInet6 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, SockaddrInet6 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SockaddrInet6(NilType nil) => default(SockaddrInet6);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static SockaddrInet6 SockaddrInet6_cast(dynamic value)
        {
            return new SockaddrInet6(value.Port, value.ZoneId, value.Addr);
        }
    }
}