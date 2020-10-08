//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:28:07 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class syntax_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(expr))]
        public partial struct KeyValueExpr
        {
            // expr structure promotion - sourced from value copy
            private readonly ptr<expr> m_exprRef;

            private ref expr expr_val => ref m_exprRef.Value;

            // Constructors
            public KeyValueExpr(NilType _)
            {
                this.Key = default;
                this.Value = default;
                this.m_exprRef = new ptr<expr>(new expr(nil));
            }

            public KeyValueExpr(Expr Key = default, Expr Value = default, expr expr = default)
            {
                this.Key = Key;
                this.Value = Value;
                this.m_exprRef = new ptr<expr>(expr);
            }

            // Enable comparisons between nil and KeyValueExpr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(KeyValueExpr value, NilType nil) => value.Equals(default(KeyValueExpr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(KeyValueExpr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, KeyValueExpr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, KeyValueExpr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator KeyValueExpr(NilType nil) => default(KeyValueExpr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static KeyValueExpr KeyValueExpr_cast(dynamic value)
        {
            return new KeyValueExpr(value.Key, value.Value, value.expr);
        }
    }
}}}}