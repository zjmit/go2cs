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
        public partial struct A11
        {
            // Value of the A11 struct
            private readonly slice<byte> m_value;

            public A11(slice<byte> value) => m_value = value;

            // Enable implicit conversions between slice<byte> and A11 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator A11(slice<byte> value) => new A11(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<byte>(A11 value) => value.m_value;
            
            // Enable comparisons between nil and A11 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(A11 value, NilType nil) => value.Equals(default(A11));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(A11 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, A11 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, A11 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator A11(NilType nil) => default(A11);
        }
    }
}}}
