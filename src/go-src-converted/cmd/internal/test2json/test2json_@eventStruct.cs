//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:35:14 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using json = go.encoding.json_package;
using fmt = go.fmt_package;
using io = go.io_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using time = go.time_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using go;

namespace go {
namespace cmd {
namespace @internal
{
    public static partial class test2json_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct @event
        {
            // Constructors
            public @event(NilType _)
            {
                this.Time = default;
                this.Action = default;
                this.Package = default;
                this.Test = default;
                this.Elapsed = default;
                this.Output = default;
            }

            public @event(ref ptr<time.Time> Time = default, @string Action = default, @string Package = default, @string Test = default, ref ptr<double> Elapsed = default, ref ptr<textBytes> Output = default)
            {
                this.Time = Time;
                this.Action = Action;
                this.Package = Package;
                this.Test = Test;
                this.Elapsed = Elapsed;
                this.Output = Output;
            }

            // Enable comparisons between nil and @event struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(@event value, NilType nil) => value.Equals(default(@event));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(@event value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, @event value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, @event value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator @event(NilType nil) => default(@event);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static @event @event_cast(dynamic value)
        {
            return new @event(ref value.Time, value.Action, value.Package, value.Test, ref value.Elapsed, ref value.Output);
        }
    }
}}}