//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:30:35 UTC
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
        public partial struct RawSockaddrInet6
        {
            // Constructors
            public RawSockaddrInet6(NilType _)
            {
                this.Family = default;
                this.Port = default;
                this.Flowinfo = default;
                this.Addr = default;
                this.Scope_id = default;
            }

            public RawSockaddrInet6(ushort Family = default, ushort Port = default, uint Flowinfo = default, array<byte> Addr = default, uint Scope_id = default)
            {
                this.Family = Family;
                this.Port = Port;
                this.Flowinfo = Flowinfo;
                this.Addr = Addr;
                this.Scope_id = Scope_id;
            }

            // Enable comparisons between nil and RawSockaddrInet6 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(RawSockaddrInet6 value, NilType nil) => value.Equals(default(RawSockaddrInet6));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(RawSockaddrInet6 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, RawSockaddrInet6 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, RawSockaddrInet6 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RawSockaddrInet6(NilType nil) => default(RawSockaddrInet6);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static RawSockaddrInet6 RawSockaddrInet6_cast(dynamic value)
        {
            return new RawSockaddrInet6(value.Family, value.Port, value.Flowinfo, value.Addr, value.Scope_id);
        }
    }
}