//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:56:43 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using binary = go.encoding.binary_package;
using runtime = go.runtime_package;
using syscall = go.syscall_package;
using @unsafe = go.@unsafe_package;
using go;

#nullable enable

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
        public partial struct SockaddrCAN
        {
            // Constructors
            public SockaddrCAN(NilType _)
            {
                this.Ifindex = default;
                this.RxID = default;
                this.TxID = default;
                this.raw = default;
            }

            public SockaddrCAN(long Ifindex = default, uint RxID = default, uint TxID = default, RawSockaddrCAN raw = default)
            {
                this.Ifindex = Ifindex;
                this.RxID = RxID;
                this.TxID = TxID;
                this.raw = raw;
            }

            // Enable comparisons between nil and SockaddrCAN struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(SockaddrCAN value, NilType nil) => value.Equals(default(SockaddrCAN));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(SockaddrCAN value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, SockaddrCAN value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, SockaddrCAN value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SockaddrCAN(NilType nil) => default(SockaddrCAN);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static SockaddrCAN SockaddrCAN_cast(dynamic value)
        {
            return new SockaddrCAN(value.Ifindex, value.RxID, value.TxID, value.raw);
        }
    }
}}}}}}