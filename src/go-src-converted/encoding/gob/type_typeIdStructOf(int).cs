//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:42:45 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace encoding
{
    public static partial class gob_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct typeId
        {
            // Value of the typeId struct
            private readonly int m_value;

            public typeId(int value) => m_value = value;

            // Enable implicit conversions between int and typeId struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator typeId(int value) => new typeId(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator int(typeId value) => value.m_value;
            
            // Enable comparisons between nil and typeId struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(typeId value, NilType nil) => value.Equals(default(typeId));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(typeId value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, typeId value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, typeId value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator typeId(NilType nil) => default(typeId);
        }
    }
}}
