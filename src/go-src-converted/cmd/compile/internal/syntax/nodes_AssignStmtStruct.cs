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
        [PromotedStruct(typeof(simpleStmt))]
        public partial struct AssignStmt
        {
            // simpleStmt structure promotion - sourced from value copy
            private readonly ptr<simpleStmt> m_simpleStmtRef;

            private ref simpleStmt simpleStmt_val => ref m_simpleStmtRef.Value;

            // Constructors
            public AssignStmt(NilType _)
            {
                this.Op = default;
                this.Lhs = default;
                this.Rhs = default;
                this.m_simpleStmtRef = new ptr<simpleStmt>(new simpleStmt(nil));
            }

            public AssignStmt(Operator Op = default, Expr Lhs = default, Expr Rhs = default, simpleStmt simpleStmt = default)
            {
                this.Op = Op;
                this.Lhs = Lhs;
                this.Rhs = Rhs;
                this.m_simpleStmtRef = new ptr<simpleStmt>(simpleStmt);
            }

            // Enable comparisons between nil and AssignStmt struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(AssignStmt value, NilType nil) => value.Equals(default(AssignStmt));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(AssignStmt value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, AssignStmt value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, AssignStmt value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator AssignStmt(NilType nil) => default(AssignStmt);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static AssignStmt AssignStmt_cast(dynamic value)
        {
            return new AssignStmt(value.Op, value.Lhs, value.Rhs, value.simpleStmt);
        }
    }
}}}}