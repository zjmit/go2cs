//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:19:09 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

namespace go {
namespace @internal
{
    public static partial class cpu_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct CacheLinePad
        {
            // Constructors
            public CacheLinePad(NilType _)
            {
                this._ = default;
            }

            public CacheLinePad(array<byte> _ = default)
            {
                this._ = _;
            }

            // Enable comparisons between nil and CacheLinePad struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(CacheLinePad value, NilType nil) => value.Equals(default(CacheLinePad));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(CacheLinePad value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, CacheLinePad value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, CacheLinePad value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CacheLinePad(NilType nil) => default(CacheLinePad);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static CacheLinePad CacheLinePad_cast(dynamic value)
        {
            return new CacheLinePad(value._);
        }
    }
}}