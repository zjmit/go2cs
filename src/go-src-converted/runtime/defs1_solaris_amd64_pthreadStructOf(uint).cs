//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:19:28 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct pthread
        {
            // Value of the pthread struct
            private readonly uint m_value;

            public pthread(uint value) => m_value = value;

            // Enable implicit conversions between uint and pthread struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator pthread(uint value) => new pthread(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator uint(pthread value) => value.m_value;
            
            // Enable comparisons between nil and pthread struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(pthread value, NilType nil) => value.Equals(default(pthread));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(pthread value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, pthread value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, pthread value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator pthread(NilType nil) => default(pthread);
        }
    }
}
