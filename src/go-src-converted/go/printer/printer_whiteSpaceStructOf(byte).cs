//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:08:59 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace go
{
    public static partial class printer_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct whiteSpace
        {
            // Value of the whiteSpace struct
            private readonly byte m_value;

            public whiteSpace(byte value) => m_value = value;

            // Enable implicit conversions between byte and whiteSpace struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator whiteSpace(byte value) => new whiteSpace(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byte(whiteSpace value) => value.m_value;
            
            // Enable comparisons between nil and whiteSpace struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(whiteSpace value, NilType nil) => value.Equals(default(whiteSpace));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(whiteSpace value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, whiteSpace value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, whiteSpace value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator whiteSpace(NilType nil) => default(whiteSpace);
        }
    }
}}
