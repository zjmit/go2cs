//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:57:01 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go
{
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct domFrontier
        {
            // Value of the domFrontier struct
            private readonly slice<slice<ptr<BasicBlock>>> m_value;

            public domFrontier(slice<slice<ptr<BasicBlock>>> value) => m_value = value;

            // Enable implicit conversions between slice<slice<ptr<BasicBlock>>> and domFrontier struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator domFrontier(slice<slice<ptr<BasicBlock>>> value) => new domFrontier(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<slice<ptr<BasicBlock>>>(domFrontier value) => value.m_value;
            
            // Enable comparisons between nil and domFrontier struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(domFrontier value, NilType nil) => value.Equals(default(domFrontier));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(domFrontier value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, domFrontier value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, domFrontier value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator domFrontier(NilType nil) => default(domFrontier);
        }
    }
}}}}}
