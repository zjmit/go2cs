//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:53:36 UTC
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
        public partial struct TIPCSIOCNodeIDReq
        {
            // Constructors
            public TIPCSIOCNodeIDReq(NilType _)
            {
                this.Peer = default;
                this.Id = default;
            }

            public TIPCSIOCNodeIDReq(uint Peer = default, array<sbyte> Id = default)
            {
                this.Peer = Peer;
                this.Id = Id;
            }

            // Enable comparisons between nil and TIPCSIOCNodeIDReq struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(TIPCSIOCNodeIDReq value, NilType nil) => value.Equals(default(TIPCSIOCNodeIDReq));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(TIPCSIOCNodeIDReq value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, TIPCSIOCNodeIDReq value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, TIPCSIOCNodeIDReq value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator TIPCSIOCNodeIDReq(NilType nil) => default(TIPCSIOCNodeIDReq);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static TIPCSIOCNodeIDReq TIPCSIOCNodeIDReq_cast(dynamic value)
        {
            return new TIPCSIOCNodeIDReq(value.Peer, value.Id);
        }
    }
}}}}}}