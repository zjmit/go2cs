//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 01:30:41 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace archive
{
    public static partial class tar_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct block
        {
            // Value of the block struct
            private readonly array<byte> m_value;

            public block(array<byte> value) => m_value = value;

            // Enable implicit conversions between array<byte> and block struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator block(array<byte> value) => new block(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator array<byte>(block value) => value.m_value;
            
            // Enable comparisons between nil and block struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(block value, NilType nil) => value.Equals(default(block));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(block value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, block value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, block value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator block(NilType nil) => default(block);
        }
    }
}}
