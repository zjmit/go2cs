//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:25:30 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using math = go.math_package;
using bits = go.math.bits_package;
using go;

namespace go {
namespace math
{
    public static partial class big_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct ErrNaN
        {
            // Constructors
            public ErrNaN(NilType _)
            {
                this.msg = default;
            }

            public ErrNaN(@string msg = default)
            {
                this.msg = msg;
            }

            // Enable comparisons between nil and ErrNaN struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ErrNaN value, NilType nil) => value.Equals(default(ErrNaN));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ErrNaN value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ErrNaN value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ErrNaN value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ErrNaN(NilType nil) => default(ErrNaN);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static ErrNaN ErrNaN_cast(dynamic value)
        {
            return new ErrNaN(value.msg);
        }
    }
}}