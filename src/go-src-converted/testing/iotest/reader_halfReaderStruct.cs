//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:36:39 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;
using io = go.io_package;
using go;

namespace go {
namespace testing
{
    public static partial class iotest_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct halfReader
        {
            // Constructors
            public halfReader(NilType _)
            {
                this.r = default;
            }

            public halfReader(io.Reader r = default)
            {
                this.r = r;
            }

            // Enable comparisons between nil and halfReader struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(halfReader value, NilType nil) => value.Equals(default(halfReader));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(halfReader value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, halfReader value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, halfReader value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator halfReader(NilType nil) => default(halfReader);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static halfReader halfReader_cast(dynamic value)
        {
            return new halfReader(value.r);
        }
    }
}}