//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:30:42 UTC
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
        public partial struct IfData
        {
            // Constructors
            public IfData(NilType _)
            {
                this.Type = default;
                this.Addrlen = default;
                this.Hdrlen = default;
                this.Pad_cgo_0 = default;
                this.Mtu = default;
                this.Metric = default;
                this.Baudrate = default;
                this.Ipackets = default;
                this.Ierrors = default;
                this.Opackets = default;
                this.Oerrors = default;
                this.Collisions = default;
                this.Ibytes = default;
                this.Obytes = default;
                this.Imcasts = default;
                this.Omcasts = default;
                this.Iqdrops = default;
                this.Noproto = default;
                this.Lastchange = default;
            }

            public IfData(byte Type = default, byte Addrlen = default, byte Hdrlen = default, array<byte> Pad_cgo_0 = default, uint Mtu = default, uint Metric = default, uint Baudrate = default, uint Ipackets = default, uint Ierrors = default, uint Opackets = default, uint Oerrors = default, uint Collisions = default, uint Ibytes = default, uint Obytes = default, uint Imcasts = default, uint Omcasts = default, uint Iqdrops = default, uint Noproto = default, Timeval32 Lastchange = default)
            {
                this.Type = Type;
                this.Addrlen = Addrlen;
                this.Hdrlen = Hdrlen;
                this.Pad_cgo_0 = Pad_cgo_0;
                this.Mtu = Mtu;
                this.Metric = Metric;
                this.Baudrate = Baudrate;
                this.Ipackets = Ipackets;
                this.Ierrors = Ierrors;
                this.Opackets = Opackets;
                this.Oerrors = Oerrors;
                this.Collisions = Collisions;
                this.Ibytes = Ibytes;
                this.Obytes = Obytes;
                this.Imcasts = Imcasts;
                this.Omcasts = Omcasts;
                this.Iqdrops = Iqdrops;
                this.Noproto = Noproto;
                this.Lastchange = Lastchange;
            }

            // Enable comparisons between nil and IfData struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(IfData value, NilType nil) => value.Equals(default(IfData));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(IfData value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, IfData value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, IfData value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator IfData(NilType nil) => default(IfData);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static IfData IfData_cast(dynamic value)
        {
            return new IfData(value.Type, value.Addrlen, value.Hdrlen, value.Pad_cgo_0, value.Mtu, value.Metric, value.Baudrate, value.Ipackets, value.Ierrors, value.Opackets, value.Oerrors, value.Collisions, value.Ibytes, value.Obytes, value.Imcasts, value.Omcasts, value.Iqdrops, value.Noproto, value.Lastchange);
        }
    }
}