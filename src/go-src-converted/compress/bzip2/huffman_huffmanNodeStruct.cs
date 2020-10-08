//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:58:42 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using sort = go.sort_package;
using go;

namespace go {
namespace compress
{
    public static partial class bzip2_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct huffmanNode
        {
            // Constructors
            public huffmanNode(NilType _)
            {
                this.left = default;
                this.right = default;
                this.leftValue = default;
                this.rightValue = default;
            }

            public huffmanNode(ushort left = default, ushort right = default, ushort leftValue = default, ushort rightValue = default)
            {
                this.left = left;
                this.right = right;
                this.leftValue = leftValue;
                this.rightValue = rightValue;
            }

            // Enable comparisons between nil and huffmanNode struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(huffmanNode value, NilType nil) => value.Equals(default(huffmanNode));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(huffmanNode value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, huffmanNode value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, huffmanNode value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator huffmanNode(NilType nil) => default(huffmanNode);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static huffmanNode huffmanNode_cast(dynamic value)
        {
            return new huffmanNode(value.left, value.right, value.leftValue, value.rightValue);
        }
    }
}}