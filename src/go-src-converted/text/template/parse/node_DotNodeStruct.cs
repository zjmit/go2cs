//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:41:59 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
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
        public partial struct DotNode
        {
            // Constructors
            public DotNode(NilType _)
            {
                this.NodeType = default;
                this.Pos = default;
                this.tr = default;
            }

            public DotNode(NodeType NodeType = default, Pos Pos = default, ref ptr<Tree> tr = default)
            {
                this.NodeType = NodeType;
                this.Pos = Pos;
                this.tr = tr;
            }

            // Enable comparisons between nil and DotNode struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(DotNode value, NilType nil) => value.Equals(default(DotNode));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(DotNode value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, DotNode value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, DotNode value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator DotNode(NilType nil) => default(DotNode);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static DotNode DotNode_cast(dynamic value)
        {
            return new DotNode(value.NodeType, value.Pos, ref value.tr);
        }
    }
}}}