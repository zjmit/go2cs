//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:43:52 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using strings = go.strings_package;
using go;

namespace go {
namespace cmd {
namespace vendor {
namespace github.com {
namespace ianlancetaylor
{
    public static partial class demangle_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Special
        {
            // Constructors
            public Special(NilType _)
            {
                this.Prefix = default;
                this.Val = default;
            }

            public Special(@string Prefix = default, AST Val = default)
            {
                this.Prefix = Prefix;
                this.Val = Val;
            }

            // Enable comparisons between nil and Special struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Special value, NilType nil) => value.Equals(default(Special));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Special value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Special value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Special value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Special(NilType nil) => default(Special);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Special Special_cast(dynamic value)
        {
            return new Special(value.Prefix, value.Val);
        }
    }
}}}}}