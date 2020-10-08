//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:35:09 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace crypto
{
    public static partial class tls_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct alert
        {
            // Value of the alert struct
            private readonly byte m_value;

            public alert(byte value) => m_value = value;

            // Enable implicit conversions between byte and alert struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator alert(byte value) => new alert(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byte(alert value) => value.m_value;
            
            // Enable comparisons between nil and alert struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(alert value, NilType nil) => value.Equals(default(alert));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(alert value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, alert value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, alert value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator alert(NilType nil) => default(alert);
        }
    }
}}
