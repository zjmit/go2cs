//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:03:56 UTC
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
        private partial struct byUniqueMethodName
        {
            // Value of the byUniqueMethodName struct
            private readonly slice<ptr<Func>> m_value;

            public byUniqueMethodName(slice<ptr<Func>> value) => m_value = value;

            // Enable implicit conversions between slice<ptr<Func>> and byUniqueMethodName struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byUniqueMethodName(slice<ptr<Func>> value) => new byUniqueMethodName(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<ptr<Func>>(byUniqueMethodName value) => value.m_value;
            
            // Enable comparisons between nil and byUniqueMethodName struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(byUniqueMethodName value, NilType nil) => value.Equals(default(byUniqueMethodName));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(byUniqueMethodName value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, byUniqueMethodName value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, byUniqueMethodName value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byUniqueMethodName(NilType nil) => default(byUniqueMethodName);
        }
    }
}}
