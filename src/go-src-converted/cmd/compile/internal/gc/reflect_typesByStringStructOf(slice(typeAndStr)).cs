//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:30:14 UTC
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
    public static partial class gc_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct typesByString
        {
            // Value of the typesByString struct
            private readonly slice<typeAndStr> m_value;

            public typesByString(slice<typeAndStr> value) => m_value = value;

            // Enable implicit conversions between slice<typeAndStr> and typesByString struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator typesByString(slice<typeAndStr> value) => new typesByString(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<typeAndStr>(typesByString value) => value.m_value;
            
            // Enable comparisons between nil and typesByString struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(typesByString value, NilType nil) => value.Equals(default(typesByString));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(typesByString value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, typesByString value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, typesByString value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator typesByString(NilType nil) => default(typesByString);
        }
    }
}}}}
