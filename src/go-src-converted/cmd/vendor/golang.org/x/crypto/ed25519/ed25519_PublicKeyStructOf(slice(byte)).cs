//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:45:25 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace crypto
{
    public static partial class ed25519_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct PublicKey
        {
            // Value of the PublicKey struct
            private readonly slice<byte> m_value;

            public PublicKey(slice<byte> value) => m_value = value;

            // Enable implicit conversions between slice<byte> and PublicKey struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator PublicKey(slice<byte> value) => new PublicKey(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<byte>(PublicKey value) => value.m_value;
            
            // Enable comparisons between nil and PublicKey struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(PublicKey value, NilType nil) => value.Equals(default(PublicKey));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(PublicKey value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, PublicKey value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, PublicKey value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator PublicKey(NilType nil) => default(PublicKey);
        }
    }
}}}}}}
