//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:53:41 UTC
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
        private partial struct _Fsblkcnt_t
        {
            // Value of the _Fsblkcnt_t struct
            private readonly ulong m_value;

            public _Fsblkcnt_t(ulong value) => m_value = value;

            // Enable implicit conversions between ulong and _Fsblkcnt_t struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator _Fsblkcnt_t(ulong value) => new _Fsblkcnt_t(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ulong(_Fsblkcnt_t value) => value.m_value;
            
            // Enable comparisons between nil and _Fsblkcnt_t struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(_Fsblkcnt_t value, NilType nil) => value.Equals(default(_Fsblkcnt_t));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(_Fsblkcnt_t value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, _Fsblkcnt_t value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, _Fsblkcnt_t value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator _Fsblkcnt_t(NilType nil) => default(_Fsblkcnt_t);
        }
    }
}}}}}}
