//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:42:52 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace encoding
{
    public static partial class json_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct byIndex
        {
            // Value of the byIndex struct
            private readonly slice<field> m_value;

            public byIndex(slice<field> value) => m_value = value;

            // Enable implicit conversions between slice<field> and byIndex struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byIndex(slice<field> value) => new byIndex(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<field>(byIndex value) => value.m_value;
            
            // Enable comparisons between nil and byIndex struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(byIndex value, NilType nil) => value.Equals(default(byIndex));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(byIndex value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, byIndex value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, byIndex value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byIndex(NilType nil) => default(byIndex);
        }
    }
}}
