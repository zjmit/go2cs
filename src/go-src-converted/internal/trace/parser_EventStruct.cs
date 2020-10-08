//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:42:30 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using io = go.io_package;
using rand = go.math.rand_package;
using os = go.os_package;
using exec = go.os.exec_package;
using filepath = go.path.filepath_package;
using runtime = go.runtime_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using _@unsafe_ = go.@unsafe_package;
using go;

namespace go {
namespace @internal
{
    public static partial class trace_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Event
        {
            // Constructors
            public Event(NilType _)
            {
                this.Off = default;
                this.Type = default;
                this.seq = default;
                this.Ts = default;
                this.P = default;
                this.G = default;
                this.StkID = default;
                this.Stk = default;
                this.Args = default;
                this.SArgs = default;
                this.Link = default;
            }

            public Event(long Off = default, byte Type = default, long seq = default, long Ts = default, long P = default, ulong G = default, ulong StkID = default, slice<ptr<Frame>> Stk = default, array<ulong> Args = default, slice<@string> SArgs = default, ref ptr<Event> Link = default)
            {
                this.Off = Off;
                this.Type = Type;
                this.seq = seq;
                this.Ts = Ts;
                this.P = P;
                this.G = G;
                this.StkID = StkID;
                this.Stk = Stk;
                this.Args = Args;
                this.SArgs = SArgs;
                this.Link = Link;
            }

            // Enable comparisons between nil and Event struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Event value, NilType nil) => value.Equals(default(Event));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Event value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Event value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Event value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Event(NilType nil) => default(Event);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Event Event_cast(dynamic value)
        {
            return new Event(value.Off, value.Type, value.seq, value.Ts, value.P, value.G, value.StkID, value.Stk, value.Args, value.SArgs, ref value.Link);
        }
    }
}}