//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:35:22 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace crypto
{
    public static partial class cipher_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct cbcEncrypter
        {
            // Value of the cbcEncrypter struct
            private readonly cbc m_value;

            public cbcEncrypter(cbc value) => m_value = value;

            // Enable implicit conversions between cbc and cbcEncrypter struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator cbcEncrypter(cbc value) => new cbcEncrypter(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator cbc(cbcEncrypter value) => value.m_value;
            
            // Enable comparisons between nil and cbcEncrypter struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(cbcEncrypter value, NilType nil) => value.Equals(default(cbcEncrypter));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(cbcEncrypter value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, cbcEncrypter value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, cbcEncrypter value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator cbcEncrypter(NilType nil) => default(cbcEncrypter);
        }
    }
}}
