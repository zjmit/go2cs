//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:40:09 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace golang.org {
namespace x {
namespace net {
namespace http2
{
    public static partial class hpack_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct indexType
        {
            // Value of the indexType struct
            private readonly long m_value;

            public indexType(long value) => m_value = value;

            // Enable implicit conversions between long and indexType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator indexType(long value) => new indexType(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(indexType value) => value.m_value;
            
            // Enable comparisons between nil and indexType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(indexType value, NilType nil) => value.Equals(default(indexType));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(indexType value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, indexType value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, indexType value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator indexType(NilType nil) => default(indexType);
        }
    }
}}}}}
