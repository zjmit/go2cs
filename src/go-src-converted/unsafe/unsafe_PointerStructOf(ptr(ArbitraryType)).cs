//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 00:33:52 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace go
{
    public static partial class @unsafe_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Pointer
        {
            // Value of the Pointer struct
            private readonly ptr<ArbitraryType> m_value;

            public Pointer(ptr<ArbitraryType> value) => m_value = value;

            // Enable implicit conversions between ptr<ArbitraryType> and Pointer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Pointer(ptr<ArbitraryType> value) => new Pointer(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ptr<ArbitraryType>(Pointer value) => value.m_value;
            
            // Enable comparisons between nil and Pointer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Pointer value, NilType nil) => value.Equals(default(Pointer));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Pointer value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Pointer value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Pointer value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Pointer(NilType nil) => default(Pointer);
        }
    }
}
