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
        public partial struct ParenExpr
        {
            // Constructors
            public ParenExpr(NilType _)
            {
                this.Lparen = default;
                this.X = default;
                this.Rparen = default;
            }

            public ParenExpr(token.Pos Lparen = default, Expr X = default, token.Pos Rparen = default)
            {
                this.Lparen = Lparen;
                this.X = X;
                this.Rparen = Rparen;
            }

            // Enable comparisons between nil and ParenExpr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ParenExpr value, NilType nil) => value.Equals(default(ParenExpr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ParenExpr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ParenExpr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ParenExpr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ParenExpr(NilType nil) => default(ParenExpr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static ParenExpr ParenExpr_cast(dynamic value)
        {
            return new ParenExpr(value.Lparen, value.X, value.Rparen);
        }
    }
}}