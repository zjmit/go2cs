//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:48:23 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace go
{
    public static partial class scanner_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct ErrorList
        {
            // Value of the ErrorList struct
            private readonly slice<ref Error> m_value;

            public ErrorList(slice<ref Error> value) => m_value = value;

            // Enable implicit conversions between slice<ref Error> and ErrorList struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ErrorList(slice<ref Error> value) => new ErrorList(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<ref Error>(ErrorList value) => value.m_value;
            
            // Enable comparisons between nil and ErrorList struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ErrorList value, NilType nil) => value.Equals(default(ErrorList));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ErrorList value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ErrorList value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ErrorList value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ErrorList(NilType nil) => default(ErrorList);
        }
    }
}}