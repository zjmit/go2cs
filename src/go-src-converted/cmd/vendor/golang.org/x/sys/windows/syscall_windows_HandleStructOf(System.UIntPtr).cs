//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:53:54 UTC
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
    public static partial class windows_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Handle
        {
            // Value of the Handle struct
            private readonly System.UIntPtr m_value;

            public Handle(System.UIntPtr value) => m_value = value;

            // Enable implicit conversions between System.UIntPtr and Handle struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Handle(System.UIntPtr value) => new Handle(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator System.UIntPtr(Handle value) => value.m_value;
            
            // Enable comparisons between nil and Handle struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Handle value, NilType nil) => value.Equals(default(Handle));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Handle value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Handle value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Handle value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Handle(NilType nil) => default(Handle);
        }
    }
}}}}}}
