//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:54:41 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using strings = go.strings_package;
using go;

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace @internal {
namespace lsp
{
    public static partial class diff_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Unified
        {
            // Constructors
            public Unified(NilType _)
            {
                this.From = default;
                this.To = default;
                this.Hunks = default;
            }

            public Unified(@string From = default, @string To = default, slice<ptr<Hunk>> Hunks = default)
            {
                this.From = From;
                this.To = To;
                this.Hunks = Hunks;
            }

            // Enable comparisons between nil and Unified struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Unified value, NilType nil) => value.Equals(default(Unified));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Unified value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Unified value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Unified value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Unified(NilType nil) => default(Unified);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Unified Unified_cast(dynamic value)
        {
            return new Unified(value.From, value.To, value.Hunks);
        }
    }
}}}}}}