//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:46:42 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using token = go.go.token_package;
using strings = go.strings_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using go;

namespace go {
namespace go
{
    public static partial class ast_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Comment
        {
            // Constructors
            public Comment(NilType _)
            {
                this.Slash = default;
                this.Text = default;
            }

            public Comment(token.Pos Slash = default, @string Text = default)
            {
                this.Slash = Slash;
                this.Text = Text;
            }

            // Enable comparisons between nil and Comment struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Comment value, NilType nil) => value.Equals(default(Comment));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Comment value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Comment value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Comment value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Comment(NilType nil) => default(Comment);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Comment Comment_cast(dynamic value)
        {
            return new Comment(value.Slash, value.Text);
        }
    }
}}