//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:56:21 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace go {
namespace @internal
{
    public static partial class aliases_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct T0
        {
            // Value of the T0 struct
            private readonly array<long> m_value;

            public T0(array<long> value) => m_value = value;

            // Enable implicit conversions between array<long> and T0 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator T0(array<long> value) => new T0(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator array<long>(T0 value) => value.m_value;
            
            // Enable comparisons between nil and T0 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(T0 value, NilType nil) => value.Equals(default(T0));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(T0 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, T0 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, T0 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator T0(NilType nil) => default(T0);
        }
    }
}}}
