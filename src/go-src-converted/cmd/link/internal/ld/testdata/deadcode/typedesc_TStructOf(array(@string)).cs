//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:39:52 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct T
        {
            // Value of the T struct
            private readonly array<@string> m_value;

            public T(array<@string> value) => m_value = value;

            // Enable implicit conversions between array<@string> and T struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator T(array<@string> value) => new T(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator array<@string>(T value) => value.m_value;
            
            // Enable comparisons between nil and T struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(T value, NilType nil) => value.Equals(default(T));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(T value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, T value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, T value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator T(NilType nil) => default(T);
        }
    }
}
