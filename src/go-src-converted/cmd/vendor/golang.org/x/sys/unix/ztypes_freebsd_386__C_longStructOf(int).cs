//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:53:28 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class unix_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct _C_long
        {
            // Value of the _C_long struct
            private readonly int m_value;

            public _C_long(int value) => m_value = value;

            // Enable implicit conversions between int and _C_long struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator _C_long(int value) => new _C_long(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator int(_C_long value) => value.m_value;
            
            // Enable comparisons between nil and _C_long struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(_C_long value, NilType nil) => value.Equals(default(_C_long));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(_C_long value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, _C_long value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, _C_long value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator _C_long(NilType nil) => default(_C_long);
        }
    }
}}}}}}
