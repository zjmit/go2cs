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
        public partial struct RawSockaddrAny
        {
            // Constructors
            public RawSockaddrAny(NilType _)
            {
                this.Addr = default;
                this.Pad = default;
            }

            public RawSockaddrAny(RawSockaddr Addr = default, array<sbyte> Pad = default)
            {
                this.Addr = Addr;
                this.Pad = Pad;
            }

            // Enable comparisons between nil and RawSockaddrAny struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(RawSockaddrAny value, NilType nil) => value.Equals(default(RawSockaddrAny));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(RawSockaddrAny value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, RawSockaddrAny value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, RawSockaddrAny value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RawSockaddrAny(NilType nil) => default(RawSockaddrAny);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static RawSockaddrAny RawSockaddrAny_cast(dynamic value)
        {
            return new RawSockaddrAny(value.Addr, value.Pad);
        }
    }
}