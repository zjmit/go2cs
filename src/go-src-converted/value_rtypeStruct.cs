//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:57:27 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using types = go.go.types_package;
using io = go.io_package;
using reflect = go.reflect_package;
using strings = go.strings_package;
using sync = go.sync_package;
using @unsafe = go.@unsafe_package;
using ssa = go.golang.org.x.tools.go.ssa_package;
using typeutil = go.golang.org.x.tools.go.types.typeutil_package;
using go;

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go {
namespace ssa
{
    public static partial class interp_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct rtype
        {
            // Constructors
            public rtype(NilType _)
            {
                this.t = default;
            }

            public rtype(types.Type t = default)
            {
                this.t = t;
            }

            // Enable comparisons between nil and rtype struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(rtype value, NilType nil) => value.Equals(default(rtype));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(rtype value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, rtype value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, rtype value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator rtype(NilType nil) => default(rtype);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static rtype rtype_cast(dynamic value)
        {
            return new rtype(value.t);
        }
    }
}}}}}}