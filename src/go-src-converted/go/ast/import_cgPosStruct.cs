//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:04:22 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using token = go.go.token_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using go;

namespace go {
namespace go
{
    public static partial class ast_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct cgPos
        {
            // Constructors
            public cgPos(NilType _)
            {
                this.left = default;
                this.cg = default;
            }

            public cgPos(bool left = default, ref ptr<CommentGroup> cg = default)
            {
                this.left = left;
                this.cg = cg;
            }

            // Enable comparisons between nil and cgPos struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(cgPos value, NilType nil) => value.Equals(default(cgPos));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(cgPos value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, cgPos value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, cgPos value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator cgPos(NilType nil) => default(cgPos);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static cgPos cgPos_cast(dynamic value)
        {
            return new cgPos(value.left, ref value.cg);
        }
    }
}}