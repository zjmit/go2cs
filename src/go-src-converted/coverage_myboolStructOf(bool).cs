//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:57:30 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct mybool
        {
            // Value of the mybool struct
            private readonly bool m_value;

            public mybool(bool value) => m_value = value;

            // Enable implicit conversions between bool and mybool struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator mybool(bool value) => new mybool(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator bool(mybool value) => value.m_value;
            
            // Enable comparisons between nil and mybool struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(mybool value, NilType nil) => value.Equals(default(mybool));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(mybool value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, mybool value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, mybool value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator mybool(NilType nil) => default(mybool);
        }
    }
}
