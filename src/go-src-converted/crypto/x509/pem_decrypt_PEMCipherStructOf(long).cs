//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:31:40 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace crypto
{
    public static partial class x509_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct PEMCipher
        {
            // Value of the PEMCipher struct
            private readonly long m_value;

            public PEMCipher(long value) => m_value = value;

            // Enable implicit conversions between long and PEMCipher struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator PEMCipher(long value) => new PEMCipher(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(PEMCipher value) => value.m_value;
            
            // Enable comparisons between nil and PEMCipher struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(PEMCipher value, NilType nil) => value.Equals(default(PEMCipher));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(PEMCipher value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, PEMCipher value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, PEMCipher value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator PEMCipher(NilType nil) => default(PEMCipher);
        }
    }
}}