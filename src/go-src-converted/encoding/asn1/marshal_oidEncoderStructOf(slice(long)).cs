//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:36:54 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace encoding
{
    public static partial class asn1_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct oidEncoder
        {
            // Value of the oidEncoder struct
            private readonly slice<long> m_value;

            public oidEncoder(slice<long> value) => m_value = value;

            // Enable implicit conversions between slice<long> and oidEncoder struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator oidEncoder(slice<long> value) => new oidEncoder(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<long>(oidEncoder value) => value.m_value;
            
            // Enable comparisons between nil and oidEncoder struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(oidEncoder value, NilType nil) => value.Equals(default(oidEncoder));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(oidEncoder value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, oidEncoder value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, oidEncoder value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator oidEncoder(NilType nil) => default(oidEncoder);
        }
    }
}}
