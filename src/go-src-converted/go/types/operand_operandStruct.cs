//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:03:36 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using ast = go.go.ast_package;
using constant = go.go.constant_package;
using token = go.go.token_package;
using go;

namespace go {
namespace go
{
    public static partial class types_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct operand
        {
            // Constructors
            public operand(NilType _)
            {
                this.mode = default;
                this.expr = default;
                this.typ = default;
                this.val = default;
                this.id = default;
            }

            public operand(operandMode mode = default, ast.Expr expr = default, Type typ = default, constant.Value val = default, builtinId id = default)
            {
                this.mode = mode;
                this.expr = expr;
                this.typ = typ;
                this.val = val;
                this.id = id;
            }

            // Enable comparisons between nil and operand struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(operand value, NilType nil) => value.Equals(default(operand));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(operand value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, operand value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, operand value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator operand(NilType nil) => default(operand);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static operand operand_cast(dynamic value)
        {
            return new operand(value.mode, value.expr, value.typ, value.val, value.id);
        }
    }
}}