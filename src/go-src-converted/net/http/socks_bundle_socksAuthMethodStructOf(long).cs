//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:40:35 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct socksAuthMethod
        {
            // Value of the socksAuthMethod struct
            private readonly long m_value;

            public socksAuthMethod(long value) => m_value = value;

            // Enable implicit conversions between long and socksAuthMethod struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator socksAuthMethod(long value) => new socksAuthMethod(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(socksAuthMethod value) => value.m_value;
            
            // Enable comparisons between nil and socksAuthMethod struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(socksAuthMethod value, NilType nil) => value.Equals(default(socksAuthMethod));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(socksAuthMethod value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, socksAuthMethod value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, socksAuthMethod value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator socksAuthMethod(NilType nil) => default(socksAuthMethod);
        }
    }
}}
