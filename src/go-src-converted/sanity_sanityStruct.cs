//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:57:08 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using types = go.go.types_package;
using io = go.io_package;
using os = go.os_package;
using strings = go.strings_package;
using go;

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go
{
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct sanity
        {
            // Constructors
            public sanity(NilType _)
            {
                this.reporter = default;
                this.fn = default;
                this.block = default;
                this.insane = default;
            }

            public sanity(io.Writer reporter = default, ref ptr<Function> fn = default, ref ptr<BasicBlock> block = default, bool insane = default)
            {
                this.reporter = reporter;
                this.fn = fn;
                this.block = block;
                this.insane = insane;
            }

            // Enable comparisons between nil and sanity struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(sanity value, NilType nil) => value.Equals(default(sanity));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(sanity value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, sanity value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, sanity value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator sanity(NilType nil) => default(sanity);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static sanity sanity_cast(dynamic value)
        {
            return new sanity(value.reporter, ref value.fn, ref value.block, value.insane);
        }
    }
}}}}}