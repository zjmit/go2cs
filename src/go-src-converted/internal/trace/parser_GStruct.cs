//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:42:31 UTC
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
        public partial struct G
        {
            // Constructors
            public G(NilType _)
            {
                this.futile = default;
                this.wakeup = default;
            }

            public G(bool futile = default, slice<ptr<Event>> wakeup = default)
            {
                this.futile = futile;
                this.wakeup = wakeup;
            }

            // Enable comparisons between nil and G struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(G value, NilType nil) => value.Equals(default(G));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(G value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, G value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, G value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator G(NilType nil) => default(G);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static G G_cast(dynamic value)
        {
            return new G(value.futile, value.wakeup);
        }
    }
}}