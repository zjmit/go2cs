//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:50:09 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using binary = go.encoding.binary_package;
using go;

namespace go {
namespace cmd {
namespace @internal
{
    public static partial class goobj2_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct InlTreeNode
        {
            // Constructors
            public InlTreeNode(NilType _)
            {
                this.Parent = default;
                this.File = default;
                this.Line = default;
                this.Func = default;
                this.ParentPC = default;
            }

            public InlTreeNode(int Parent = default, SymRef File = default, int Line = default, SymRef Func = default, int ParentPC = default)
            {
                this.Parent = Parent;
                this.File = File;
                this.Line = Line;
                this.Func = Func;
                this.ParentPC = ParentPC;
            }

            // Enable comparisons between nil and InlTreeNode struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(InlTreeNode value, NilType nil) => value.Equals(default(InlTreeNode));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(InlTreeNode value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, InlTreeNode value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, InlTreeNode value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator InlTreeNode(NilType nil) => default(InlTreeNode);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static InlTreeNode InlTreeNode_cast(dynamic value)
        {
            return new InlTreeNode(value.Parent, value.File, value.Line, value.Func, value.ParentPC);
        }
    }
}}}