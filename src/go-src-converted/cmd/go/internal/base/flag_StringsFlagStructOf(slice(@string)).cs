//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:36:56 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class @base_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct StringsFlag
        {
            // Value of the StringsFlag struct
            private readonly slice<@string> m_value;

            public StringsFlag(slice<@string> value) => m_value = value;

            // Enable implicit conversions between slice<@string> and StringsFlag struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator StringsFlag(slice<@string> value) => new StringsFlag(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<@string>(StringsFlag value) => value.m_value;
            
            // Enable comparisons between nil and StringsFlag struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(StringsFlag value, NilType nil) => value.Equals(default(StringsFlag));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(StringsFlag value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, StringsFlag value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, StringsFlag value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator StringsFlag(NilType nil) => default(StringsFlag);
        }
    }
}}}}
