//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:49:31 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace go
{
    public static partial class builtin_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct complex64
        {
            // Value of the complex64 struct
            private readonly complex64 m_value;

            public complex64(complex64 value) => m_value = value;

            // Enable implicit conversions between complex64 and complex64 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator complex64(complex64 value) => new complex64(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator complex64(complex64 value) => value.m_value;
            
            // Enable comparisons between nil and complex64 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(complex64 value, NilType nil) => value.Equals(default(complex64));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(complex64 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, complex64 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, complex64 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator complex64(NilType nil) => default(complex64);
        }
    }
}
