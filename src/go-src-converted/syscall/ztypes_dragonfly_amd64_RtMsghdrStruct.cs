//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:30:33 UTC
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
        public partial struct RtMsghdr
        {
            // Constructors
            public RtMsghdr(NilType _)
            {
                this.Msglen = default;
                this.Version = default;
                this.Type = default;
                this.Index = default;
                this.Pad_cgo_0 = default;
                this.Flags = default;
                this.Addrs = default;
                this.Pid = default;
                this.Seq = default;
                this.Errno = default;
                this.Use = default;
                this.Inits = default;
                this.Rmx = default;
            }

            public RtMsghdr(ushort Msglen = default, byte Version = default, byte Type = default, ushort Index = default, array<byte> Pad_cgo_0 = default, int Flags = default, int Addrs = default, int Pid = default, int Seq = default, int Errno = default, int Use = default, ulong Inits = default, RtMetrics Rmx = default)
            {
                this.Msglen = Msglen;
                this.Version = Version;
                this.Type = Type;
                this.Index = Index;
                this.Pad_cgo_0 = Pad_cgo_0;
                this.Flags = Flags;
                this.Addrs = Addrs;
                this.Pid = Pid;
                this.Seq = Seq;
                this.Errno = Errno;
                this.Use = Use;
                this.Inits = Inits;
                this.Rmx = Rmx;
            }

            // Enable comparisons between nil and RtMsghdr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(RtMsghdr value, NilType nil) => value.Equals(default(RtMsghdr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(RtMsghdr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, RtMsghdr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, RtMsghdr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RtMsghdr(NilType nil) => default(RtMsghdr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static RtMsghdr RtMsghdr_cast(dynamic value)
        {
            return new RtMsghdr(value.Msglen, value.Version, value.Type, value.Index, value.Pad_cgo_0, value.Flags, value.Addrs, value.Pid, value.Seq, value.Errno, value.Use, value.Inits, value.Rmx);
        }
    }
}