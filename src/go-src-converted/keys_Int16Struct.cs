//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:54:52 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using io = go.io_package;
using math = go.math_package;
using strconv = go.strconv_package;
using label = go.golang.org.x.tools.@internal.@event.label_package;
using go;

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace @internal {
namespace @event
{
    public static partial class keys_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Int16
        {
            // Constructors
            public Int16(NilType _)
            {
                this.name = default;
                this.description = default;
            }

            public Int16(@string name = default, @string description = default)
            {
                this.name = name;
                this.description = description;
            }

            // Enable comparisons between nil and Int16 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Int16 value, NilType nil) => value.Equals(default(Int16));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Int16 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Int16 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Int16 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Int16(NilType nil) => default(Int16);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Int16 Int16_cast(dynamic value)
        {
            return new Int16(value.name, value.description);
        }
    }
}}}}}}