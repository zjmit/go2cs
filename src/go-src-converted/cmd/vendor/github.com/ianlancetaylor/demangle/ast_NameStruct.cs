//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:43:51 UTC
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
        public partial struct Name
        {
            // Constructors
            public Name(NilType _)
            {
                this.Name = default;
            }

            public Name(@string Name = default)
            {
                this.Name = Name;
            }

            // Enable comparisons between nil and Name struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Name value, NilType nil) => value.Equals(default(Name));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Name value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Name value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Name value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Name(NilType nil) => default(Name);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Name Name_cast(dynamic value)
        {
            return new Name(value.Name);
        }
    }
}}}}}