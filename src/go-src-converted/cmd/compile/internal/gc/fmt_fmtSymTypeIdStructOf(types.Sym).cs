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
        private partial struct fmtSymTypeId
        {
            // Value of the fmtSymTypeId struct
            private readonly types.Sym m_value;

            public fmtSymTypeId(types.Sym value) => m_value = value;

            // Enable implicit conversions between types.Sym and fmtSymTypeId struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fmtSymTypeId(types.Sym value) => new fmtSymTypeId(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator types.Sym(fmtSymTypeId value) => value.m_value;
            
            // Enable comparisons between nil and fmtSymTypeId struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(fmtSymTypeId value, NilType nil) => value.Equals(default(fmtSymTypeId));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(fmtSymTypeId value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, fmtSymTypeId value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, fmtSymTypeId value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fmtSymTypeId(NilType nil) => default(fmtSymTypeId);
        }
    }
}}}}
