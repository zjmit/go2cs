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
        public partial struct CompositeLit
        {
            // Constructors
            public CompositeLit(NilType _)
            {
                this.Type = default;
                this.Lbrace = default;
                this.Elts = default;
                this.Rbrace = default;
                this.Incomplete = default;
            }

            public CompositeLit(Expr Type = default, token.Pos Lbrace = default, slice<Expr> Elts = default, token.Pos Rbrace = default, bool Incomplete = default)
            {
                this.Type = Type;
                this.Lbrace = Lbrace;
                this.Elts = Elts;
                this.Rbrace = Rbrace;
                this.Incomplete = Incomplete;
            }

            // Enable comparisons between nil and CompositeLit struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(CompositeLit value, NilType nil) => value.Equals(default(CompositeLit));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(CompositeLit value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, CompositeLit value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, CompositeLit value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CompositeLit(NilType nil) => default(CompositeLit);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static CompositeLit CompositeLit_cast(dynamic value)
        {
            return new CompositeLit(value.Type, value.Lbrace, value.Elts, value.Rbrace, value.Incomplete);
        }
    }
}}