//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:25:47 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace math
{
    public static partial class big_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct nat
        {
            // Value of the nat struct
            private readonly slice<Word> m_value;

            public nat(slice<Word> value) => m_value = value;

            // Enable implicit conversions between slice<Word> and nat struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nat(slice<Word> value) => new nat(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<Word>(nat value) => value.m_value;
            
            // Enable comparisons between nil and nat struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(nat value, NilType nil) => value.Equals(default(nat));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(nat value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, nat value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, nat value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nat(NilType nil) => default(nat);
        }
    }
}}
