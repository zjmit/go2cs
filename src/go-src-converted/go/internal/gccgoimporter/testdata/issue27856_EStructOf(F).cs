//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:56:22 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace go {
namespace @internal
{
    public static partial class lib_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct E
        {
            // Value of the E struct
            private readonly F m_value;

            public E(F value) => m_value = value;

            // Enable implicit conversions between F and E struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator E(F value) => new E(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator F(E value) => value.m_value;
            
            // Enable comparisons between nil and E struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(E value, NilType nil) => value.Equals(default(E));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(E value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, E value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, E value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator E(NilType nil) => default(E);
        }
    }
}}}
