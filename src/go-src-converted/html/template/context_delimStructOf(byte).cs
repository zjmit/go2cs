//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:41:52 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace html
{
    public static partial class template_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct delim
        {
            // Value of the delim struct
            private readonly byte m_value;

            public delim(byte value) => m_value = value;

            // Enable implicit conversions between byte and delim struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator delim(byte value) => new delim(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byte(delim value) => value.m_value;
            
            // Enable comparisons between nil and delim struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(delim value, NilType nil) => value.Equals(default(delim));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(delim value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, delim value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, delim value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator delim(NilType nil) => default(delim);
        }
    }
}}
