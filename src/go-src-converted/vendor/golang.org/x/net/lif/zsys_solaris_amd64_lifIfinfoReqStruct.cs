//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 05:01:26 UTC
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
    public static partial class lif_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct lifIfinfoReq
        {
            // Constructors
            public lifIfinfoReq(NilType _)
            {
                this.Maxhops = default;
                this.Pad_cgo_0 = default;
                this.Reachtime = default;
                this.Reachretrans = default;
                this.Maxmtu = default;
            }

            public lifIfinfoReq(byte Maxhops = default, array<byte> Pad_cgo_0 = default, uint Reachtime = default, uint Reachretrans = default, uint Maxmtu = default)
            {
                this.Maxhops = Maxhops;
                this.Pad_cgo_0 = Pad_cgo_0;
                this.Reachtime = Reachtime;
                this.Reachretrans = Reachretrans;
                this.Maxmtu = Maxmtu;
            }

            // Enable comparisons between nil and lifIfinfoReq struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(lifIfinfoReq value, NilType nil) => value.Equals(default(lifIfinfoReq));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(lifIfinfoReq value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, lifIfinfoReq value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, lifIfinfoReq value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator lifIfinfoReq(NilType nil) => default(lifIfinfoReq);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static lifIfinfoReq lifIfinfoReq_cast(dynamic value)
        {
            return new lifIfinfoReq(value.Maxhops, value.Pad_cgo_0, value.Reachtime, value.Reachretrans, value.Maxmtu);
        }
    }
}}}}}