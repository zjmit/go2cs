//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:32:19 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class arm_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct shift
        {
            // Value of the shift struct
            private readonly long m_value;

            public shift(long value) => m_value = value;

            // Enable implicit conversions between long and shift struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator shift(long value) => new shift(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(shift value) => value.m_value;
            
            // Enable comparisons between nil and shift struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(shift value, NilType nil) => value.Equals(default(shift));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(shift value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, shift value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, shift value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator shift(NilType nil) => default(shift);
        }
    }
}}}}
