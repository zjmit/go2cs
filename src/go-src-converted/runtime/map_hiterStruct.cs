//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:20:13 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using atomic = go.runtime.@internal.atomic_package;
using math = go.runtime.@internal.math_package;
using sys = go.runtime.@internal.sys_package;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct hiter
        {
            // Constructors
            public hiter(NilType _)
            {
                this.key = default;
                this.elem = default;
                this.t = default;
                this.h = default;
                this.buckets = default;
                this.bptr = default;
                this.overflow = default;
                this.oldoverflow = default;
                this.startBucket = default;
                this.offset = default;
                this.wrapped = default;
                this.B = default;
                this.i = default;
                this.bucket = default;
                this.checkBucket = default;
            }

            public hiter(unsafe.Pointer key = default, unsafe.Pointer elem = default, ref ptr<maptype> t = default, ref ptr<hmap> h = default, unsafe.Pointer buckets = default, ref ptr<bmap> bptr = default, ref ptr<slice<ptr<bmap>>> overflow = default, ref ptr<slice<ptr<bmap>>> oldoverflow = default, System.UIntPtr startBucket = default, byte offset = default, bool wrapped = default, byte B = default, byte i = default, System.UIntPtr bucket = default, System.UIntPtr checkBucket = default)
            {
                this.key = key;
                this.elem = elem;
                this.t = t;
                this.h = h;
                this.buckets = buckets;
                this.bptr = bptr;
                this.overflow = overflow;
                this.oldoverflow = oldoverflow;
                this.startBucket = startBucket;
                this.offset = offset;
                this.wrapped = wrapped;
                this.B = B;
                this.i = i;
                this.bucket = bucket;
                this.checkBucket = checkBucket;
            }

            // Enable comparisons between nil and hiter struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(hiter value, NilType nil) => value.Equals(default(hiter));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(hiter value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, hiter value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, hiter value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator hiter(NilType nil) => default(hiter);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static hiter hiter_cast(dynamic value)
        {
            return new hiter(value.key, value.elem, ref value.t, ref value.h, value.buckets, ref value.bptr, ref value.overflow, ref value.oldoverflow, value.startBucket, value.offset, value.wrapped, value.B, value.i, value.bucket, value.checkBucket);
        }
    }
}