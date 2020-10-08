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
        [PromotedStruct(typeof(Comments))]
        public partial struct LParen
        {
            // Comments structure promotion - sourced from value copy
            private readonly ptr<Comments> m_CommentsRef;

            private ref Comments Comments_val => ref m_CommentsRef.Value;

            public ref slice<Comment> Before => ref m_CommentsRef.Value.Before;

            public ref slice<Comment> Suffix => ref m_CommentsRef.Value.Suffix;

            public ref slice<Comment> After => ref m_CommentsRef.Value.After;

            // Constructors
            public LParen(NilType _)
            {
                this.m_CommentsRef = new ptr<Comments>(new Comments(nil));
                this.Pos = default;
            }

            public LParen(Comments Comments = default, Position Pos = default)
            {
                this.m_CommentsRef = new ptr<Comments>(Comments);
                this.Pos = Pos;
            }

            // Enable comparisons between nil and LParen struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(LParen value, NilType nil) => value.Equals(default(LParen));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(LParen value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, LParen value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, LParen value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator LParen(NilType nil) => default(LParen);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static LParen LParen_cast(dynamic value)
        {
            return new LParen(value.Comments, value.Pos);
        }
    }
}}}}