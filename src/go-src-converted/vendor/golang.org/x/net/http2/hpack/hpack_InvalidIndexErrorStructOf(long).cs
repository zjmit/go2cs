//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 05:00:34 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace vendor {
namespace golang.org {
namespace x {
namespace net {
namespace http2
{
    public static partial class hpack_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct InvalidIndexError
        {
            // Value of the InvalidIndexError struct
            private readonly long m_value;

            public InvalidIndexError(long value) => m_value = value;

            // Enable implicit conversions between long and InvalidIndexError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator InvalidIndexError(long value) => new InvalidIndexError(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(InvalidIndexError value) => value.m_value;
            
            // Enable comparisons between nil and InvalidIndexError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(InvalidIndexError value, NilType nil) => value.Equals(default(InvalidIndexError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(InvalidIndexError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, InvalidIndexError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, InvalidIndexError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator InvalidIndexError(NilType nil) => default(InvalidIndexError);
        }
    }
}}}}}}
