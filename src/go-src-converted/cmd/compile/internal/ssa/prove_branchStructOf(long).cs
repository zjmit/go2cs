//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:11:35 UTC
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
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct branch
        {
            // Value of the branch struct
            private readonly long m_value;

            public branch(long value) => m_value = value;

            // Enable implicit conversions between long and branch struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator branch(long value) => new branch(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(branch value) => value.m_value;
            
            // Enable comparisons between nil and branch struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(branch value, NilType nil) => value.Equals(default(branch));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(branch value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, branch value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, branch value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator branch(NilType nil) => default(branch);
        }
    }
}}}}
