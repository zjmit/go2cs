//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:09:51 UTC
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
    public static partial class types_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct ChanDir
        {
            // Value of the ChanDir struct
            private readonly byte m_value;

            public ChanDir(byte value) => m_value = value;

            // Enable implicit conversions between byte and ChanDir struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ChanDir(byte value) => new ChanDir(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byte(ChanDir value) => value.m_value;
            
            // Enable comparisons between nil and ChanDir struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ChanDir value, NilType nil) => value.Equals(default(ChanDir));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ChanDir value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ChanDir value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ChanDir value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ChanDir(NilType nil) => default(ChanDir);
        }
    }
}}}}
