//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:02:40 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace go
{
    public static partial class constant_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct boolVal
        {
            // Value of the boolVal struct
            private readonly bool m_value;

            public boolVal(bool value) => m_value = value;

            // Enable implicit conversions between bool and boolVal struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator boolVal(bool value) => new boolVal(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator bool(boolVal value) => value.m_value;
            
            // Enable comparisons between nil and boolVal struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(boolVal value, NilType nil) => value.Equals(default(boolVal));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(boolVal value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, boolVal value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, boolVal value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator boolVal(NilType nil) => default(boolVal);
        }
    }
}}
