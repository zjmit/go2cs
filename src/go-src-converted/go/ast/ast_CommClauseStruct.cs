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
        public partial struct CommClause
        {
            // Constructors
            public CommClause(NilType _)
            {
                this.Case = default;
                this.Comm = default;
                this.Colon = default;
                this.Body = default;
            }

            public CommClause(token.Pos Case = default, Stmt Comm = default, token.Pos Colon = default, slice<Stmt> Body = default)
            {
                this.Case = Case;
                this.Comm = Comm;
                this.Colon = Colon;
                this.Body = Body;
            }

            // Enable comparisons between nil and CommClause struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(CommClause value, NilType nil) => value.Equals(default(CommClause));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(CommClause value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, CommClause value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, CommClause value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CommClause(NilType nil) => default(CommClause);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static CommClause CommClause_cast(dynamic value)
        {
            return new CommClause(value.Case, value.Comm, value.Colon, value.Body);
        }
    }
}}