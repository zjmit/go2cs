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
        public partial struct Nullary
        {
            // Constructors
            public Nullary(NilType _)
            {
                this.Op = default;
            }

            public Nullary(AST Op = default)
            {
                this.Op = Op;
            }

            // Enable comparisons between nil and Nullary struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Nullary value, NilType nil) => value.Equals(default(Nullary));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Nullary value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Nullary value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Nullary value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Nullary(NilType nil) => default(Nullary);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Nullary Nullary_cast(dynamic value)
        {
            return new Nullary(value.Op);
        }
    }
}}}}}