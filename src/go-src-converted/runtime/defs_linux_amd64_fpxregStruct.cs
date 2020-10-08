//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:19:34 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct fpxreg
        {
            // Constructors
            public fpxreg(NilType _)
            {
                this.significand = default;
                this.exponent = default;
                this.padding = default;
            }

            public fpxreg(array<ushort> significand = default, ushort exponent = default, array<ushort> padding = default)
            {
                this.significand = significand;
                this.exponent = exponent;
                this.padding = padding;
            }

            // Enable comparisons between nil and fpxreg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(fpxreg value, NilType nil) => value.Equals(default(fpxreg));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(fpxreg value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, fpxreg value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, fpxreg value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fpxreg(NilType nil) => default(fpxreg);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static fpxreg fpxreg_cast(dynamic value)
        {
            return new fpxreg(value.significand, value.exponent, value.padding);
        }
    }
}