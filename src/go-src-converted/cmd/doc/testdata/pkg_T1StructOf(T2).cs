//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:33:09 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace cmd
{
    public static partial class pkg_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct T1
        {
            // Value of the T1 struct
            private readonly T2 m_value;

            public T1(T2 value) => m_value = value;

            // Enable implicit conversions between T2 and T1 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator T1(T2 value) => new T1(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator T2(T1 value) => value.m_value;
            
            // Enable comparisons between nil and T1 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(T1 value, NilType nil) => value.Equals(default(T1));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(T1 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, T1 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, T1 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator T1(NilType nil) => default(T1);
        }
    }
}}
