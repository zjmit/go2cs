//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:02:31 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace go
{
    public static partial class types_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct ImportMode
        {
            // Value of the ImportMode struct
            private readonly long m_value;

            public ImportMode(long value) => m_value = value;

            // Enable implicit conversions between long and ImportMode struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ImportMode(long value) => new ImportMode(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(ImportMode value) => value.m_value;
            
            // Enable comparisons between nil and ImportMode struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ImportMode value, NilType nil) => value.Equals(default(ImportMode));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ImportMode value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ImportMode value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ImportMode value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ImportMode(NilType nil) => default(ImportMode);
        }
    }
}}
