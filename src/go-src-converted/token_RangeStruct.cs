//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:54:38 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using token = go.go.token_package;
using go;

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace @internal
{
    public static partial class span_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Range
        {
            // Constructors
            public Range(NilType _)
            {
                this.FileSet = default;
                this.Start = default;
                this.End = default;
                this.Converter = default;
            }

            public Range(ref ptr<token.FileSet> FileSet = default, token.Pos Start = default, token.Pos End = default, Converter Converter = default)
            {
                this.FileSet = FileSet;
                this.Start = Start;
                this.End = End;
                this.Converter = Converter;
            }

            // Enable comparisons between nil and Range struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Range value, NilType nil) => value.Equals(default(Range));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Range value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Range value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Range value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Range(NilType nil) => default(Range);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Range Range_cast(dynamic value)
        {
            return new Range(ref value.FileSet, value.Start, value.End, value.Converter);
        }
    }
}}}}}