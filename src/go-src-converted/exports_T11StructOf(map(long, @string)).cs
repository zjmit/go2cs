//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:55:37 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go {
namespace @internal
{
    public static partial class exports_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct T11
        {
            // Value of the T11 struct
            private readonly map<long, @string> m_value;

            public T11(map<long, @string> value) => m_value = value;

            // Enable implicit conversions between map<long, @string> and T11 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator T11(map<long, @string> value) => new T11(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator map<long, @string>(T11 value) => value.m_value;
            
            // Enable comparisons between nil and T11 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(T11 value, NilType nil) => value.Equals(default(T11));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(T11 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, T11 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, T11 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator T11(NilType nil) => default(T11);
        }
    }
}}}}}}
