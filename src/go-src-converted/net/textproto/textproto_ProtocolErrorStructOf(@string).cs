//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:38:29 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace net
{
    public static partial class textproto_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct ProtocolError
        {
            // Value of the ProtocolError struct
            private readonly @string m_value;

            public ProtocolError(@string value) => m_value = value;

            // Enable implicit conversions between @string and ProtocolError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ProtocolError(@string value) => new ProtocolError(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator @string(ProtocolError value) => value.m_value;
            
            // Enable comparisons between nil and ProtocolError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ProtocolError value, NilType nil) => value.Equals(default(ProtocolError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ProtocolError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ProtocolError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ProtocolError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ProtocolError(NilType nil) => default(ProtocolError);
        }
    }
}}
