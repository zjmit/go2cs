//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:54:17 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using token = go.go.token_package;
using go;

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace tools {
namespace go
{
    public static partial class analysis_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct TextEdit
        {
            // Constructors
            public TextEdit(NilType _)
            {
                this.Pos = default;
                this.End = default;
                this.NewText = default;
            }

            public TextEdit(token.Pos Pos = default, token.Pos End = default, slice<byte> NewText = default)
            {
                this.Pos = Pos;
                this.End = End;
                this.NewText = NewText;
            }

            // Enable comparisons between nil and TextEdit struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(TextEdit value, NilType nil) => value.Equals(default(TextEdit));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(TextEdit value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, TextEdit value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, TextEdit value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator TextEdit(NilType nil) => default(TextEdit);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static TextEdit TextEdit_cast(dynamic value)
        {
            return new TextEdit(value.Pos, value.End, value.NewText);
        }
    }
}}}}}}}