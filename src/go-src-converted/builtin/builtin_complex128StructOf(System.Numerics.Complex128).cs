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
        private partial struct complex128
        {
            // Value of the complex128 struct
            private readonly System.Numerics.Complex128 m_value;

            public complex128(System.Numerics.Complex128 value) => m_value = value;

            // Enable implicit conversions between System.Numerics.Complex128 and complex128 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator complex128(System.Numerics.Complex128 value) => new complex128(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator System.Numerics.Complex128(complex128 value) => value.m_value;
            
            // Enable comparisons between nil and complex128 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(complex128 value, NilType nil) => value.Equals(default(complex128));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(complex128 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, complex128 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, complex128 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator complex128(NilType nil) => default(complex128);
        }
    }
}
