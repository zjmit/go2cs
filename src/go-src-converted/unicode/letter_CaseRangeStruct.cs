//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:24:47 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


namespace go
{
    public static partial class unicode_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct CaseRange
        {
            // Constructors
            public CaseRange(NilType _)
            {
                this.Lo = default;
                this.Hi = default;
                this.Delta = default;
            }

            public CaseRange(uint Lo = default, uint Hi = default, d Delta = default)
            {
                this.Lo = Lo;
                this.Hi = Hi;
                this.Delta = Delta;
            }

            // Enable comparisons between nil and CaseRange struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(CaseRange value, NilType nil) => value.Equals(default(CaseRange));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(CaseRange value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, CaseRange value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, CaseRange value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CaseRange(NilType nil) => default(CaseRange);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static CaseRange CaseRange_cast(dynamic value)
        {
            return new CaseRange(value.Lo, value.Hi, value.Delta);
        }
    }
}