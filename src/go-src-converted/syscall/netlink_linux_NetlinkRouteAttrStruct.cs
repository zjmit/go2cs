//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:26:49 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct NetlinkRouteAttr
        {
            // Constructors
            public NetlinkRouteAttr(NilType _)
            {
                this.Attr = default;
                this.Value = default;
            }

            public NetlinkRouteAttr(RtAttr Attr = default, slice<byte> Value = default)
            {
                this.Attr = Attr;
                this.Value = Value;
            }

            // Enable comparisons between nil and NetlinkRouteAttr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NetlinkRouteAttr value, NilType nil) => value.Equals(default(NetlinkRouteAttr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NetlinkRouteAttr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, NetlinkRouteAttr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, NetlinkRouteAttr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator NetlinkRouteAttr(NilType nil) => default(NetlinkRouteAttr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static NetlinkRouteAttr NetlinkRouteAttr_cast(dynamic value)
        {
            return new NetlinkRouteAttr(value.Attr, value.Value);
        }
    }
}