//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:04:36 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace cmd {
namespace asm {
namespace @internal
{
    public static partial class flags_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct MultiFlag
        {
            // Value of the MultiFlag struct
            private readonly slice<@string> m_value;

            public MultiFlag(slice<@string> value) => m_value = value;

            // Enable implicit conversions between slice<@string> and MultiFlag struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator MultiFlag(slice<@string> value) => new MultiFlag(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<@string>(MultiFlag value) => value.m_value;
            
            // Enable comparisons between nil and MultiFlag struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(MultiFlag value, NilType nil) => value.Equals(default(MultiFlag));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(MultiFlag value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, MultiFlag value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, MultiFlag value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator MultiFlag(NilType nil) => default(MultiFlag);
        }
    }
}}}}
