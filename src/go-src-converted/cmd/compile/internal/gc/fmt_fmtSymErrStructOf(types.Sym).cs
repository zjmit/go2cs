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
        private partial struct fmtSymErr
        {
            // Value of the fmtSymErr struct
            private readonly types.Sym m_value;

            public fmtSymErr(types.Sym value) => m_value = value;

            // Enable implicit conversions between types.Sym and fmtSymErr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fmtSymErr(types.Sym value) => new fmtSymErr(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator types.Sym(fmtSymErr value) => value.m_value;
            
            // Enable comparisons between nil and fmtSymErr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(fmtSymErr value, NilType nil) => value.Equals(default(fmtSymErr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(fmtSymErr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, fmtSymErr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, fmtSymErr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fmtSymErr(NilType nil) => default(fmtSymErr);
        }
    }
}}}}
