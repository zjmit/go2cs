//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:27:59 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class gc_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct bitset8
        {
            // Value of the bitset8 struct
            private readonly byte m_value;

            public bitset8(byte value) => m_value = value;

            // Enable implicit conversions between byte and bitset8 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator bitset8(byte value) => new bitset8(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byte(bitset8 value) => value.m_value;
            
            // Enable comparisons between nil and bitset8 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(bitset8 value, NilType nil) => value.Equals(default(bitset8));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(bitset8 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, bitset8 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, bitset8 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator bitset8(NilType nil) => default(bitset8);
        }
    }
}}}}
