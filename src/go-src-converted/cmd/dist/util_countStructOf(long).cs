//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:33:01 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct count
        {
            // Value of the count struct
            private readonly long m_value;

            public count(long value) => m_value = value;

            // Enable implicit conversions between long and count struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator count(long value) => new count(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(count value) => value.m_value;
            
            // Enable comparisons between nil and count struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(count value, NilType nil) => value.Equals(default(count));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(count value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, count value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, count value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator count(NilType nil) => default(count);
        }
    }
}
