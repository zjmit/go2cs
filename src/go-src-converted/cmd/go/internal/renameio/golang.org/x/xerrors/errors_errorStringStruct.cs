//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:34:14 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using go;

namespace go {
namespace golang.org {
namespace x
{
    public static partial class xerrors_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct errorString
        {
            // Constructors
            public errorString(NilType _)
            {
                this.s = default;
                this.frame = default;
            }

            public errorString(@string s = default, Frame frame = default)
            {
                this.s = s;
                this.frame = frame;
            }

            // Enable comparisons between nil and errorString struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(errorString value, NilType nil) => value.Equals(default(errorString));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(errorString value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, errorString value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, errorString value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator errorString(NilType nil) => default(errorString);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static errorString errorString_cast(dynamic value)
        {
            return new errorString(value.s, value.frame);
        }
    }
}}}