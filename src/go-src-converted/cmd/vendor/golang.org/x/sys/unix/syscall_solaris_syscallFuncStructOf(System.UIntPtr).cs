//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:47:53 UTC
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
        private partial struct syscallFunc
        {
            // Value of the syscallFunc struct
            private readonly System.UIntPtr m_value;

            public syscallFunc(System.UIntPtr value) => m_value = value;

            // Enable implicit conversions between System.UIntPtr and syscallFunc struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator syscallFunc(System.UIntPtr value) => new syscallFunc(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator System.UIntPtr(syscallFunc value) => value.m_value;
            
            // Enable comparisons between nil and syscallFunc struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(syscallFunc value, NilType nil) => value.Equals(default(syscallFunc));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(syscallFunc value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, syscallFunc value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, syscallFunc value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator syscallFunc(NilType nil) => default(syscallFunc);
        }
    }
}}}}}}
