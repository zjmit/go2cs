//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:28:57 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class gc_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct fmtNodeTypeId
        {
            // Value of the fmtNodeTypeId struct
            private readonly Node m_value;

            public fmtNodeTypeId(Node value) => m_value = value;

            // Enable implicit conversions between Node and fmtNodeTypeId struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fmtNodeTypeId(Node value) => new fmtNodeTypeId(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Node(fmtNodeTypeId value) => value.m_value;
            
            // Enable comparisons between nil and fmtNodeTypeId struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(fmtNodeTypeId value, NilType nil) => value.Equals(default(fmtNodeTypeId));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(fmtNodeTypeId value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, fmtNodeTypeId value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, fmtNodeTypeId value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fmtNodeTypeId(NilType nil) => default(fmtNodeTypeId);
        }
    }
}}}}
