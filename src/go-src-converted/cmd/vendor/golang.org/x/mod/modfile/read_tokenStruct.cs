//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:45:49 UTC
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
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace mod
{
    public static partial class modfile_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct token
        {
            // Constructors
            public token(NilType _)
            {
                this.kind = default;
                this.pos = default;
                this.endPos = default;
                this.text = default;
            }

            public token(tokenKind kind = default, Position pos = default, Position endPos = default, @string text = default)
            {
                this.kind = kind;
                this.pos = pos;
                this.endPos = endPos;
                this.text = text;
            }

            // Enable comparisons between nil and token struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(token value, NilType nil) => value.Equals(default(token));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(token value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, token value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, token value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator token(NilType nil) => default(token);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static token token_cast(dynamic value)
        {
            return new token(value.kind, value.pos, value.endPos, value.text);
        }
    }
}}}}}}