//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:33:41 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytealg = go.@internal.bytealg_package;

namespace go
{
    public static partial class net_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct IPNet
        {
            // Constructors
            public IPNet(NilType _)
            {
                this.IP = default;
                this.Mask = default;
            }

            public IPNet(IP IP = default, IPMask Mask = default)
            {
                this.IP = IP;
                this.Mask = Mask;
            }

            // Enable comparisons between nil and IPNet struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(IPNet value, NilType nil) => value.Equals(default(IPNet));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(IPNet value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, IPNet value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, IPNet value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator IPNet(NilType nil) => default(IPNet);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static IPNet IPNet_cast(dynamic value)
        {
            return new IPNet(value.IP, value.Mask);
        }
    }
}