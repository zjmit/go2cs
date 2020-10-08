//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:42:02 UTC
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
using runtime = go.runtime_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using go;

namespace go {
namespace text {
namespace template
{
    public static partial class parse_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Tree
        {
            // Constructors
            public Tree(NilType _)
            {
                this.Name = default;
                this.ParseName = default;
                this.Root = default;
                this.text = default;
                this.funcs = default;
                this.lex = default;
                this.token = default;
                this.peekCount = default;
                this.vars = default;
                this.treeSet = default;
            }

            public Tree(@string Name = default, @string ParseName = default, ref ptr<ListNode> Root = default, @string text = default, slice<object> funcs = default, ref ptr<lexer> lex = default, array<item> token = default, long peekCount = default, slice<@string> vars = default, map<@string, ptr<Tree>> treeSet = default)
            {
                this.Name = Name;
                this.ParseName = ParseName;
                this.Root = Root;
                this.text = text;
                this.funcs = funcs;
                this.lex = lex;
                this.token = token;
                this.peekCount = peekCount;
                this.vars = vars;
                this.treeSet = treeSet;
            }

            // Enable comparisons between nil and Tree struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Tree value, NilType nil) => value.Equals(default(Tree));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Tree value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Tree value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Tree value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tree(NilType nil) => default(Tree);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Tree Tree_cast(dynamic value)
        {
            return new Tree(value.Name, value.ParseName, ref value.Root, value.text, value.funcs, ref value.lex, value.token, value.peekCount, value.vars, value.treeSet);
        }
    }
}}}