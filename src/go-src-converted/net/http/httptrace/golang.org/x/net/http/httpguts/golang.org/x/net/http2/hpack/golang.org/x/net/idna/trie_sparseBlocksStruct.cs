//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:40:08 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

namespace go {
namespace golang.org {
namespace x {
namespace net
{
    public static partial class idna_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct sparseBlocks
        {
            // Constructors
            public sparseBlocks(NilType _)
            {
                this.values = default;
                this.offset = default;
            }

            public sparseBlocks(slice<valueRange> values = default, slice<ushort> offset = default)
            {
                this.values = values;
                this.offset = offset;
            }

            // Enable comparisons between nil and sparseBlocks struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(sparseBlocks value, NilType nil) => value.Equals(default(sparseBlocks));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(sparseBlocks value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, sparseBlocks value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, sparseBlocks value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator sparseBlocks(NilType nil) => default(sparseBlocks);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static sparseBlocks sparseBlocks_cast(dynamic value)
        {
            return new sparseBlocks(value.values, value.offset);
        }
    }
}}}}