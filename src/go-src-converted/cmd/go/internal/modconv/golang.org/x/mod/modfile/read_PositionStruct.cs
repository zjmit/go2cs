//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:35:25 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using os = go.os_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using go;

namespace go {
namespace golang.org {
namespace x {
namespace mod
{
    public static partial class modfile_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Position
        {
            // Constructors
            public Position(NilType _)
            {
                this.Line = default;
                this.LineRune = default;
                this.Byte = default;
            }

            public Position(long Line = default, long LineRune = default, long Byte = default)
            {
                this.Line = Line;
                this.LineRune = LineRune;
                this.Byte = Byte;
            }

            // Enable comparisons between nil and Position struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Position value, NilType nil) => value.Equals(default(Position));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Position value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Position value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Position value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Position(NilType nil) => default(Position);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Position Position_cast(dynamic value)
        {
            return new Position(value.Line, value.LineRune, value.Byte);
        }
    }
}}}}