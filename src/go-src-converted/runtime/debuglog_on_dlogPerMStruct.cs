//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:19:28 UTC
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
        private partial struct dlogPerM
        {
            // Constructors
            public dlogPerM(NilType _)
            {
                this.dlogCache = default;
            }

            public dlogPerM(ref ptr<dlogger> dlogCache = default)
            {
                this.dlogCache = dlogCache;
            }

            // Enable comparisons between nil and dlogPerM struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(dlogPerM value, NilType nil) => value.Equals(default(dlogPerM));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(dlogPerM value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, dlogPerM value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, dlogPerM value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator dlogPerM(NilType nil) => default(dlogPerM);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static dlogPerM dlogPerM_cast(dynamic value)
        {
            return new dlogPerM(ref value.dlogCache);
        }
    }
}