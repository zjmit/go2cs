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
        public partial struct TypeAssertExpr
        {
            // Constructors
            public TypeAssertExpr(NilType _)
            {
                this.X = default;
                this.Lparen = default;
                this.Type = default;
                this.Rparen = default;
            }

            public TypeAssertExpr(Expr X = default, token.Pos Lparen = default, Expr Type = default, token.Pos Rparen = default)
            {
                this.X = X;
                this.Lparen = Lparen;
                this.Type = Type;
                this.Rparen = Rparen;
            }

            // Enable comparisons between nil and TypeAssertExpr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(TypeAssertExpr value, NilType nil) => value.Equals(default(TypeAssertExpr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(TypeAssertExpr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, TypeAssertExpr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, TypeAssertExpr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator TypeAssertExpr(NilType nil) => default(TypeAssertExpr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static TypeAssertExpr TypeAssertExpr_cast(dynamic value)
        {
            return new TypeAssertExpr(value.X, value.Lparen, value.Type, value.Rparen);
        }
    }
}}