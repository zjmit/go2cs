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
        private partial struct headerV7
        {
            // Value of the headerV7 struct
            private readonly array<byte> m_value;

            public headerV7(array<byte> value) => m_value = value;

            // Enable implicit conversions between array<byte> and headerV7 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator headerV7(array<byte> value) => new headerV7(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator array<byte>(headerV7 value) => value.m_value;
            
            // Enable comparisons between nil and headerV7 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(headerV7 value, NilType nil) => value.Equals(default(headerV7));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(headerV7 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, headerV7 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, headerV7 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator headerV7(NilType nil) => default(headerV7);
        }
    }
}}
