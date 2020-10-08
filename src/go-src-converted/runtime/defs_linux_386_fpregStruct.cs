//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:19:33 UTC
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
        private partial struct fpreg
        {
            // Constructors
            public fpreg(NilType _)
            {
                this.significand = default;
                this.exponent = default;
            }

            public fpreg(array<ushort> significand = default, ushort exponent = default)
            {
                this.significand = significand;
                this.exponent = exponent;
            }

            // Enable comparisons between nil and fpreg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(fpreg value, NilType nil) => value.Equals(default(fpreg));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(fpreg value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, fpreg value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, fpreg value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fpreg(NilType nil) => default(fpreg);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static fpreg fpreg_cast(dynamic value)
        {
            return new fpreg(value.significand, value.exponent);
        }
    }
}