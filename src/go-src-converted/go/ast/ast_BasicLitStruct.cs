//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:02:23 UTC
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
using go;

namespace go {
namespace go
{
    public static partial class ast_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct BasicLit
        {
            // Constructors
            public BasicLit(NilType _)
            {
                this.ValuePos = default;
                this.Kind = default;
                this.Value = default;
            }

            public BasicLit(token.Pos ValuePos = default, token.Token Kind = default, @string Value = default)
            {
                this.ValuePos = ValuePos;
                this.Kind = Kind;
                this.Value = Value;
            }

            // Enable comparisons between nil and BasicLit struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(BasicLit value, NilType nil) => value.Equals(default(BasicLit));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(BasicLit value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, BasicLit value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, BasicLit value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator BasicLit(NilType nil) => default(BasicLit);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static BasicLit BasicLit_cast(dynamic value)
        {
            return new BasicLit(value.ValuePos, value.Kind, value.Value);
        }
    }
}}