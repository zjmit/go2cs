//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:24:46 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using unsafeheader = go.@internal.unsafeheader_package;
using strconv = go.strconv_package;
using sync = go.sync_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class reflect_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct layoutType
        {
            // Constructors
            public layoutType(NilType _)
            {
                this.t = default;
                this.argSize = default;
                this.retOffset = default;
                this.stack = default;
                this.framePool = default;
            }

            public layoutType(ref ptr<rtype> t = default, System.UIntPtr argSize = default, System.UIntPtr retOffset = default, ref ptr<bitVector> stack = default, ref ptr<sync.Pool> framePool = default)
            {
                this.t = t;
                this.argSize = argSize;
                this.retOffset = retOffset;
                this.stack = stack;
                this.framePool = framePool;
            }

            // Enable comparisons between nil and layoutType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(layoutType value, NilType nil) => value.Equals(default(layoutType));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(layoutType value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, layoutType value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, layoutType value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator layoutType(NilType nil) => default(layoutType);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static layoutType layoutType_cast(dynamic value)
        {
            return new layoutType(ref value.t, value.argSize, value.retOffset, ref value.stack, ref value.framePool);
        }
    }
}