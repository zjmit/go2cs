//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:45:49 UTC
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
namespace mod
{
    public static partial class modfile_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct tokenKind
        {
            // Value of the tokenKind struct
            private readonly long m_value;

            public tokenKind(long value) => m_value = value;

            // Enable implicit conversions between long and tokenKind struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator tokenKind(long value) => new tokenKind(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(tokenKind value) => value.m_value;
            
            // Enable comparisons between nil and tokenKind struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(tokenKind value, NilType nil) => value.Equals(default(tokenKind));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(tokenKind value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, tokenKind value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, tokenKind value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator tokenKind(NilType nil) => default(tokenKind);
        }
    }
}}}}}}
