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
        public partial struct IndexExpr
        {
            // expr structure promotion - sourced from value copy
            private readonly ptr<expr> m_exprRef;

            private ref expr expr_val => ref m_exprRef.Value;

            // Constructors
            public IndexExpr(NilType _)
            {
                this.X = default;
                this.Index = default;
                this.m_exprRef = new ptr<expr>(new expr(nil));
            }

            public IndexExpr(Expr X = default, Expr Index = default, expr expr = default)
            {
                this.X = X;
                this.Index = Index;
                this.m_exprRef = new ptr<expr>(expr);
            }

            // Enable comparisons between nil and IndexExpr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(IndexExpr value, NilType nil) => value.Equals(default(IndexExpr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(IndexExpr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, IndexExpr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, IndexExpr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator IndexExpr(NilType nil) => default(IndexExpr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static IndexExpr IndexExpr_cast(dynamic value)
        {
            return new IndexExpr(value.X, value.Index, value.expr);
        }
    }
}}}}