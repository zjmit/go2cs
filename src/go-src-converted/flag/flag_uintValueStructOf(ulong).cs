//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:41:31 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace go
{
    public static partial class flag_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct uintValue
        {
            // Value of the uintValue struct
            private readonly ulong m_value;

            public uintValue(ulong value) => m_value = value;

            // Enable implicit conversions between ulong and uintValue struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator uintValue(ulong value) => new uintValue(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ulong(uintValue value) => value.m_value;
            
            // Enable comparisons between nil and uintValue struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(uintValue value, NilType nil) => value.Equals(default(uintValue));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(uintValue value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, uintValue value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, uintValue value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator uintValue(NilType nil) => default(uintValue);
        }
    }
}
