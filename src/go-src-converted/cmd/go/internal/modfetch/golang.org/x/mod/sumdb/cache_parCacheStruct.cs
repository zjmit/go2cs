//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:36:13 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;
using go;

namespace go {
namespace golang.org {
namespace x {
namespace mod
{
    public static partial class sumdb_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct parCache
        {
            // Constructors
            public parCache(NilType _)
            {
                this.m = default;
            }

            public parCache(sync.Map m = default)
            {
                this.m = m;
            }

            // Enable comparisons between nil and parCache struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(parCache value, NilType nil) => value.Equals(default(parCache));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(parCache value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, parCache value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, parCache value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator parCache(NilType nil) => default(parCache);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static parCache parCache_cast(dynamic value)
        {
            return new parCache(value.m);
        }
    }
}}}}