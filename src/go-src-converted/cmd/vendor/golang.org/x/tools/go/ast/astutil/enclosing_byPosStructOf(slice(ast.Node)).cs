//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:58:22 UTC
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
namespace tools {
namespace go {
namespace ast
{
    public static partial class astutil_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct byPos
        {
            // Value of the byPos struct
            private readonly slice<ast.Node> m_value;

            public byPos(slice<ast.Node> value) => m_value = value;

            // Enable implicit conversions between slice<ast.Node> and byPos struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byPos(slice<ast.Node> value) => new byPos(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<ast.Node>(byPos value) => value.m_value;
            
            // Enable comparisons between nil and byPos struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(byPos value, NilType nil) => value.Equals(default(byPos));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(byPos value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, byPos value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, byPos value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byPos(NilType nil) => default(byPos);
        }
    }
}}}}}}}}
