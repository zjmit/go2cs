//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:30:40 UTC
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
        public partial struct RtMetrics
        {
            // Constructors
            public RtMetrics(NilType _)
            {
                this.Locks = default;
                this.Mtu = default;
                this.Hopcount = default;
                this.Recvpipe = default;
                this.Sendpipe = default;
                this.Ssthresh = default;
                this.Rtt = default;
                this.Rttvar = default;
                this.Expire = default;
                this.Pksent = default;
            }

            public RtMetrics(ulong Locks = default, ulong Mtu = default, ulong Hopcount = default, ulong Recvpipe = default, ulong Sendpipe = default, ulong Ssthresh = default, ulong Rtt = default, ulong Rttvar = default, long Expire = default, long Pksent = default)
            {
                this.Locks = Locks;
                this.Mtu = Mtu;
                this.Hopcount = Hopcount;
                this.Recvpipe = Recvpipe;
                this.Sendpipe = Sendpipe;
                this.Ssthresh = Ssthresh;
                this.Rtt = Rtt;
                this.Rttvar = Rttvar;
                this.Expire = Expire;
                this.Pksent = Pksent;
            }

            // Enable comparisons between nil and RtMetrics struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(RtMetrics value, NilType nil) => value.Equals(default(RtMetrics));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(RtMetrics value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, RtMetrics value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, RtMetrics value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RtMetrics(NilType nil) => default(RtMetrics);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static RtMetrics RtMetrics_cast(dynamic value)
        {
            return new RtMetrics(value.Locks, value.Mtu, value.Hopcount, value.Recvpipe, value.Sendpipe, value.Ssthresh, value.Rtt, value.Rttvar, value.Expire, value.Pksent);
        }
    }
}